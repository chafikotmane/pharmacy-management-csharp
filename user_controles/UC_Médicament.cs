using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Xml.Linq;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Data.Common;
using DocumentFormat.OpenXml;
using System.Windows.Forms.Design;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using Control = System.Windows.Forms.Control;
using System.Drawing.Printing;
using DocumentFormat.OpenXml.EMMA;
using DocumentFormat.OpenXml.Office2010.Excel;





namespace proj_pharmacell.user_controles
{
    public partial class UC_Médicament : UserControl
    {
        methodes m = new methodes();


        public UC_Médicament()
        {
            InitializeComponent();
            methodes m = new methodes();
            m.RemplirComboBox(comb_stock, "MovementID_Mouvements_stock", "Mouvements_stock");
            m.RemplirComboBox(comb_vente_stock, "Num_Vente_Ventes", "Ventes_");
            m.RemplirComboBox(comb_categorie, "CategorieID_Categories", "Categories");
            m.RemplirGrid("Categories", dgv_cat);
            



        }
        private List<Image> images = new List<Image>();
        private int currentIndex = 0;
        ADO d = new ADO();
        private void UC_Médicament_Load(object sender, EventArgs e)
        {
            d.connecter();
            d.cmd.CommandText = "select * from Medicament ";
            d.cmd.Connection = d.con;
            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            dgv_médicament.DataSource = d.dt;
            d.dr.Close();
            LoadImages();

        }


        //-----------------------------------------------Chargement des photos lors de la selection ---------------------------//
        private void LoadImages()
        {
          
            try
            {
                d.connecter();
                flowLayoutPanel1.Controls.Clear();

                string query = "SELECT Photo_Chemin_Medicament, Designation_Medicament, Quantite_Disponible_Medicament FROM Medicament";

                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    query += " WHERE Designation_Medicament LIKE @search";
                }

                d.cmd.CommandText = query;
                d.cmd.Parameters.Clear();

                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    d.cmd.Parameters.AddWithValue("@search", "%" + txtSearch.Text + "%");
                }

                SqlDataReader reader = d.cmd.ExecuteReader();

                while (reader.Read())
                {
                    byte[] imageData = (byte[])reader["Photo_Chemin_Medicament"];
                    string imageName = reader["Designation_Medicament"].ToString();
                    long quantite = Convert.ToInt64(reader["Quantite_Disponible_Medicament"]);

                    // Convertir les données binaires en image
                    Image image;
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        image = Image.FromStream(ms);
                    }

                    // Créer une PictureBox
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = image;
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Size = new Size(200, 200);

                    // Créer un Label pour le texte sous l’image
                    Label label = new Label();
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Dock = DockStyle.Fill;

                    if (quantite > 0)
                    {
                        label.Text = $"{imageName} ({quantite} en stock)";
                        label.ForeColor = System.Drawing.Color.Black;
                    }
                    else
                    {
                        label.Text = $"{imageName} (EN RUPTURE)";
                        label.ForeColor = System.Drawing.Color.Red;
                    }

                    // Créer le panneau contenant l’image + texte
                    TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
                    tableLayoutPanel.RowCount = 2;
                    tableLayoutPanel.ColumnCount = 1;
                    tableLayoutPanel.Size = new Size(200, 230);
                    tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
                    tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
                    tableLayoutPanel.Controls.Add(pictureBox, 0, 0);
                    tableLayoutPanel.Controls.Add(label, 0, 1);

                    flowLayoutPanel1.Controls.Add(tableLayoutPanel);
                }

                reader.Close();
                d.deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des images : " + ex.Message);
            }
        }

        //---------------------------------------------------------------------------------------------------------------
       



        // Méthode pour ajouter une image à la liste
        private void AddImage(Image image)
        {
            images.Add(image);
        }
        //declaration de la methode nombre
        public int nombre()
        {
            int cpt;
            d.connecter();
            d.cmd.CommandText = "select count (MedicamentID_Medicament) from Medicament where MedicamentID_Medicament='" + txt_id_médicament.Text + "'";
            d.cmd.Connection = d.con;
            cpt = (int)d.cmd.ExecuteScalar();
            return cpt;
        }
        // declration de la methode Ajouter
        public bool Ajouter()
        {
            if (nombre() == 0)
            {
                // Convertir l'image en tableau de bytes
                byte[] imageBytes = File.ReadAllBytes(txt_photo.Text);
                // Activation de IDENTITY_INSERT pour la table Ventes_
                d.cmd.CommandText = "SET IDENTITY_INSERT Medicament ON; " +
                                    "INSERT INTO Medicament (MedicamentID_Medicament, Photo_Chemin_Medicament, Designation_Medicament, Prix_Achat_Medicament,Prix_Vente_Medicament,Quantite_Minimal_Medicament,Quantite_Disponible_Medicament,Utilisation_Medicament,Contre_Indication_Medicament,Effets_Secondaire_Medicament,Taux_de_PC_Medicament,Code_Barre_Medicament,Date_Expiration_Medicament,MovementID_Mouvements_stock,Num_Vente_Ventes,CategorieID_Categories) " +
                                    "VALUES (@MedicamentID, @Photo, @Designation, @Prix_Achat,@Prix_Vente,@Quantite_Minimal,@Quantite_Disponible,@Utilisation,@Contre_Indication,@Effets_Secondaire,@Taux_de_PC,@Code_Barre,@Date_Expiration,@MovementID,@Num_Vente,@CategorieID); " +
                                    "SET IDENTITY_INSERT Medicament OFF;";
                d.cmd.Parameters.Clear();

                // Affectation des valeurs aux paramètres de la commande
                d.cmd.Parameters.AddWithValue("@MedicamentID", txt_id_médicament.Text);
                d.cmd.Parameters.AddWithValue("@Photo", imageBytes);
                d.cmd.Parameters.AddWithValue("@Designation", txt_désignation.Text);
                d.cmd.Parameters.AddWithValue("@Prix_Achat", txt_prix_achat.Text);
                d.cmd.Parameters.AddWithValue("@Prix_Vente", txt_prix_vente.Text);
                d.cmd.Parameters.AddWithValue("@Quantite_Minimal", txt_quantité_min.Text);
                d.cmd.Parameters.AddWithValue("@Quantite_Disponible", txt_quantité_max.Text);
                d.cmd.Parameters.AddWithValue("@Utilisation", txt_utilisation.Text);
                d.cmd.Parameters.AddWithValue("@Contre_Indication", txt_contre_indication.Text);
                d.cmd.Parameters.AddWithValue("@Effets_Secondaire", txt_effet_sec.Text);
                d.cmd.Parameters.AddWithValue("@Taux_de_PC", txt_taux_pc.Text);
                d.cmd.Parameters.AddWithValue("@Code_Barre", txt_code_barre.Text);
                d.cmd.Parameters.AddWithValue("@Date_Expiration", DateTime.Parse(TB_date.Text));
                d.cmd.Parameters.AddWithValue("@MovementID", comb_stock.Text);
                d.cmd.Parameters.AddWithValue("@Num_Vente", comb_vente_stock.Text);
                d.cmd.Parameters.AddWithValue("@CategorieID", comb_categorie.Text);

                d.cmd.Connection = d.con;
                d.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }
        //declaration de la methode Modifier

        public bool Modifier()
        {
            d.connecter();
            if (nombre() != 0)
            {
                byte[] imageBytes = File.ReadAllBytes(txt_photo.Text);
                d.cmd.CommandText = "UPDATE Medicament SET Photo_Chemin_Medicament=@Photo, Designation_Medicament=@Designation, Prix_Achat_Medicament=@PrixAchat, Prix_Vente_Medicament=@PrixVente, Quantite_Minimal_Medicament=@QuantiteMin, Quantite_Disponible_Medicament=@QuantiteMax, Utilisation_Medicament=@Utilisation, Contre_Indication_Medicament=@ContreIndication, Effets_Secondaire_Medicament=@EffetsSecondaire, Taux_de_PC_Medicament=@TauxPC, Code_Barre_Medicament=@CodeBarre, Date_Expiration_Medicament=@DateExpiration, MovementID_Mouvements_stock=@Stock, Num_Vente_Ventes=@NumVente, CategorieID_Categories=@Categorie WHERE MedicamentID_Medicament=@MedicamentID";

                // Clear existing parameters to avoid duplicates
                d.cmd.Parameters.Clear();

                // Add parameters
                d.cmd.Parameters.AddWithValue("@Photo", imageBytes);
                d.cmd.Parameters.AddWithValue("@Designation", txt_désignation.Text);
                d.cmd.Parameters.AddWithValue("@PrixAchat", txt_prix_achat.Text);
                d.cmd.Parameters.AddWithValue("@PrixVente", txt_prix_vente.Text);
                d.cmd.Parameters.AddWithValue("@QuantiteMin", txt_quantité_min.Text);
                d.cmd.Parameters.AddWithValue("@QuantiteMax", txt_quantité_max.Text);
                d.cmd.Parameters.AddWithValue("@Utilisation", txt_utilisation.Text);
                d.cmd.Parameters.AddWithValue("@ContreIndication", txt_contre_indication.Text);
                d.cmd.Parameters.AddWithValue("@EffetsSecondaire", txt_effet_sec.Text);
                d.cmd.Parameters.AddWithValue("@TauxPC", txt_taux_pc.Text);
                d.cmd.Parameters.AddWithValue("@CodeBarre", txt_code_barre.Text);
                d.cmd.Parameters.AddWithValue("@DateExpiration", DateTime.Parse(TB_date.Text));
                d.cmd.Parameters.AddWithValue("@Stock", comb_stock.Text);
                d.cmd.Parameters.AddWithValue("@NumVente", comb_vente_stock.Text);
                d.cmd.Parameters.AddWithValue("@Categorie", comb_categorie.Text);
                d.cmd.Parameters.AddWithValue("@MedicamentID", txt_id_médicament.Text);

                d.cmd.Connection = d.con;
                d.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }


        //declration de la methode Supprimer
        public bool Supprimer()
        {
            if (nombre() != 0)
            {
                d.cmd.CommandText = "delete from Medicament where MedicamentID_Medicament='" + txt_id_médicament.Text + "' ";
                d.cmd.Connection = d.con;
                d.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }
        //Méthode pour afficher l'image suivante dans le panel


        // declration de la methode Vider
        public void VIDER(Control f)
        {
            foreach (Control ct in f.Controls)
            {
                if (ct.GetType() == typeof(TextBox))
                    ct.Text = "";
                if (ct.GetType() == typeof(ComboBox))
                    ct.Text = "";
                if (ct.Controls.Count != 0)
                    VIDER(ct);

            }


        }




        private void dtp_date_expire_ValueChanged_1(object sender, EventArgs e)
        {
            TB_date.Text = dtp_date_expire.Value.ToString();
        }

        private void dgv_médicament_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_médicament.SelectedRows.Count > 0)
            {
                // Supposons que la colonne contenant le chemin de l'image soit la deuxième colonne.
                string cheminImage = dgv_médicament.SelectedRows[0].Cells["Photo_Chemin_Medicament"].Value.ToString();

                // Charger l'image dans la PictureBox.
                if (!string.IsNullOrEmpty(cheminImage) && File.Exists(cheminImage))
                {
                    pb_médicament.Image = Image.FromFile(cheminImage);
                }
                else
                {
                    // Si le chemin de l'image est vide ou l'image n'existe pas, afficher une image par défaut.
                    pb_médicament.Image = Properties.Resources.icons8_medicament_64;
                }
            }
        }



        private void dgv_médicament_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id_médicament.Text = ToString();
            byte[] imgData = (byte[])dgv_médicament.CurrentRow.Cells[1].Value;
            MemoryStream ms = new MemoryStream(imgData);
            pb_médicament.Image = Image.FromStream(ms);
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_médicament.Rows[e.RowIndex];

                // Remplir les TextBox avec les valeurs de chaque colonne
                txt_id_médicament.Text = row.Cells["MedicamentID_Medicament"].Value.ToString();
                txt_photo.Text = row.Cells["Photo_Chemin_Medicament"].Value.ToString();
                txt_désignation.Text = row.Cells["Designation_Medicament"].Value.ToString();
                txt_prix_achat.Text = row.Cells["Prix_Achat_Medicament"].Value.ToString();
                txt_prix_vente.Text = row.Cells["Prix_Vente_Medicament"].Value.ToString();
                txt_quantité_min.Text = row.Cells["Quantite_Minimal_Medicament"].Value.ToString();
                txt_quantité_max.Text = row.Cells["Quantite_Disponible_Medicament"].Value.ToString();
                txt_utilisation.Text = row.Cells["Utilisation_Medicament"].Value.ToString();
                txt_contre_indication.Text = row.Cells["Contre_Indication_Medicament"].Value.ToString();
                txt_effet_sec.Text = row.Cells["Effets_Secondaire_Medicament"].Value.ToString();
                txt_taux_pc.Text = row.Cells["Taux_de_PC_Medicament"].Value.ToString();
                txt_code_barre.Text = row.Cells["Code_Barre_Medicament"].Value.ToString();
                TB_date.Text = row.Cells["Date_Expiration_Medicament"].Value.ToString();
                comb_stock.Text = row.Cells["MovementID_Mouvements_stock"].Value.ToString();
                comb_vente_stock.Text = row.Cells["Num_Vente_Ventes"].Value.ToString();
                comb_categorie.Text = row.Cells["CategorieID_Categories"].Value.ToString();

            }

        }



        private void bt_Ajouter_Click(object sender, EventArgs e)
        {
            if (txt_id_médicament.Text == "" || txt_photo.Text == "" || txt_désignation.Text == "" || txt_prix_achat.Text == "" || txt_prix_vente.Text == "" || txt_quantité_min.Text == "" || txt_quantité_max.Text == "" || txt_utilisation.Text == "" || txt_contre_indication.Text == "" || txt_effet_sec.Text == "" || txt_taux_pc.Text == "" || txt_code_barre.Text == "" || dtp_date_expire.Text == "" || comb_stock.Text == "" || comb_vente_stock.Text == "" || comb_categorie.Text == "")
            {
                MessageBox.Show("vous devez remplir tous les champs !", "Message");
                return;
            }
            if (Ajouter() == true)
            {
                MessageBox.Show("Opération Réussit ", "Message");
                m.RemplirGrid("Medicament", dgv_médicament);
                LoadImages();
            }
            else
            {
                MessageBox.Show("CE Médicament existe Déja !", "Message");
            }
        }

        private void bt_supprimer_Click(object sender, EventArgs e)
        {
            if (txt_id_médicament.Text == "")
            {
                MessageBox.Show("vous devez remplir tous les champs !", "Message");
                return;
            }
            if (Supprimer() == true)
            {
                MessageBox.Show("Opération Réussit ", "Message");
                m.RemplirGrid("Medicament", dgv_médicament);
            }
            else
            {
                MessageBox.Show("Ce Médicament n'existe pas !", "Message");
            }
        }

        private void bt_Modifier_Click(object sender, EventArgs e)
        {
            if (txt_id_médicament.Text == "" || txt_photo.Text == "" || txt_désignation.Text == "" || txt_prix_achat.Text == "" || txt_prix_vente.Text == "" || txt_quantité_min.Text == "" || txt_quantité_max.Text == "" || txt_utilisation.Text == "" || txt_contre_indication.Text == "" || txt_effet_sec.Text == "" || txt_taux_pc.Text == "" || txt_code_barre.Text == "" || dtp_date_expire.Text == "" || comb_stock.Text == "" || comb_vente_stock.Text == "" || comb_categorie.Text == "")
            {
                MessageBox.Show("vous devez remplir tous les champs !", "Message");
                return;
            }
            if (Modifier() == true)
            {
                MessageBox.Show("Opération Réussit ", "Message");
                m.RemplirGrid("Medicament", dgv_médicament);
                LoadImages();
            }
            else
            {
                MessageBox.Show("Ce Médicament existe Déja !", "Message");
            }
        }

        private void bt_Vider_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez vous vider les champs ? ", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                VIDER(this);
            pb_médicament.Image = Properties.Resources.icons8_medicament_64;
        }

        private void btn_parcourir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"; // Filtre pour les types de fichiers d'image

            openFileDialog.Multiselect = true; // Permettre la sélection de plusieurs fichiers

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in openFileDialog.FileNames)
                {
                    Image image = Image.FromFile(fileName);
                    AddImage(image);
                }
            }
            txt_photo.Text = openFileDialog.FileName;
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            //openFileDialog.Multiselect = true;

            //DialogResult result = openFileDialog.ShowDialog();

            //if (result == DialogResult.OK)
            //{
            //    MessageBox.Show("Fichier(s) sélectionné(s): " + string.Join(";", openFileDialog.FileNames));
            //}
            //else
            //{
            //    MessageBox.Show("Aucun fichier sélectionné.");
            //}
        }
        //-----------------------------------------------------------------------------------------------------------------------///
        // ********************************************* TABLE DE CATEGORIE*******************************************************
        //-------------------------------------------------------------------------------------------------------------------------//
        Catégories cat = new Catégories();
        private void btn_ajouter_cat_Click(object sender, EventArgs e)
        {


            cat.nombre("CategorieID_Categories", "Categories", tb_catégorie);
            if (tb_catégorie.Text == "" || tb_nom_cat.Text == "" || tb_description.Text == "")
            {
                MessageBox.Show("vous devez remplir tous les champs !", "Message");
                return;
            }
            if (cat.Ajouter(tb_catégorie, tb_nom_cat, tb_description) == true)
            {
                MessageBox.Show("Opération Réussit ", "Message");
                m.RemplirGrid("Categories", dgv_cat);
                m.RemplirComboBox(comb_stock, "MovementID_Mouvements_stock", "Mouvements_stock");
                m.RemplirComboBox(comb_vente_stock, "Num_Vente_Ventes", "Ventes_");
                m.RemplirComboBox(comb_categorie, "CategorieID_Categories", "Categories");
            }
            else
            {
                MessageBox.Show("Cette catégorie existe Déja !", "Message");
            }
        }

        private void btn_supprimer_cat_Click(object sender, EventArgs e)
        {

            if (tb_catégorie.Text == "")
            {
                MessageBox.Show("vous devez remplir  le champs de catégorie !", "Message");
                return;
            }
            if (cat.Supprimer("CategorieID_Categories", "Categories", tb_catégorie) == true)
            {
                MessageBox.Show("Opération Réussit ", "Message");
                m.RemplirGrid("Categories", dgv_cat);
                m.RemplirComboBox(comb_stock, "MovementID_Mouvements_stock", "Mouvements_stock");
                m.RemplirComboBox(comb_vente_stock, "Num_Vente_Ventes", "Ventes_");
                m.RemplirComboBox(comb_categorie, "CategorieID_Categories", "Categories");
            }
            else
            {
                MessageBox.Show("Cette catégorie existe pas !", "Message");
            }
        }

        private void btn_Modifier_cat_Click(object sender, EventArgs e)
        {
            if (tb_catégorie.Text == "" || tb_nom_cat.Text == "" || tb_description.Text == "")
            {
                MessageBox.Show("vous devez remplir tous les champs !", "Message");
                return;
            }
            if (cat.Modifier(tb_catégorie, tb_nom_cat, tb_description, "CategorieID_Categories", "Categories") == true)
            {
                MessageBox.Show("Opération Réussit ", "Message");
                m.RemplirGrid("Categories", dgv_cat);
                m.RemplirComboBox(comb_stock, "MovementID_Mouvements_stock", "Mouvements_stock");
                m.RemplirComboBox(comb_vente_stock, "Num_Vente_Ventes", "Ventes_");
                m.RemplirComboBox(comb_categorie, "CategorieID_Categories", "Categories");
            }
            else
            {
                MessageBox.Show("Cette catégorie existe Déja !", "Message");
            }
        }

        private void btn_Vider_cat_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("voulez vous vider les champs ? ", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                cat.VIDER(this);
            m.RemplirGrid("Categories", dgv_cat);
            m.RemplirComboBox(comb_stock, "MovementID_Mouvements_stock", "Mouvements_stock");
            m.RemplirComboBox(comb_vente_stock, "Num_Vente_Ventes", "Ventes_");
            m.RemplirComboBox(comb_categorie, "CategorieID_Categories", "Categories");
        }
        private void dgv_cat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_catégorie.Text = ToString();
            //byte[] imgData = (byte[])dgv_médicament.CurrentRow.Cells[1].Value;
            //MemoryStream ms = new MemoryStream(imgData);
            //pb_médicament.Image = Image.FromStream(ms);
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_cat.Rows[e.RowIndex];

                // Remplir les TextBox avec les valeurs de chaque colonne
                tb_catégorie.Text = row.Cells["CategorieID_Categories"].Value.ToString();
                tb_nom_cat.Text = row.Cells["Nom_Categorie_Categories"].Value.ToString();
                tb_description.Text = row.Cells["Description_Categories"].Value.ToString();

            }

        }
        //--------------------------------------------------------------------------------------------------------------------------
        private void bt_ordre_Click(object sender, EventArgs e)
        {
            List<TableLayoutPanel> panels = new List<TableLayoutPanel>();

            // Ajouter tous les TableLayoutPanel dans une liste
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is TableLayoutPanel)
                {
                    panels.Add((TableLayoutPanel)control);
                }
            }

            // Trier les TableLayoutPanel par le texte du label (nom du médicament)
            panels.Sort((panel1, panel2) =>
            {
                Label label1 = (Label)panel1.Controls[1]; // Le label est le deuxième contrôle dans le TableLayoutPanel
                Label label2 = (Label)panel2.Controls[1];

                return string.Compare(label1.Text, label2.Text);
            });

            // Effacer les contrôles dans le FlowLayoutPanel
            flowLayoutPanel1.Controls.Clear();

            // Ajouter les TableLayoutPanel triés au FlowLayoutPanel
            foreach (var panel in panels)
            {
                flowLayoutPanel1.Controls.Add(panel);
            }
        }

        private void bt_ordre_dec_Click(object sender, EventArgs e)
        {
            List<TableLayoutPanel> panels = new List<TableLayoutPanel>();

            // Ajouter tous les TableLayoutPanel dans une liste
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is TableLayoutPanel)
                {
                    panels.Add((TableLayoutPanel)control);
                }
            }

            // Trier les TableLayoutPanel par le texte du label (nom du médicament)
            panels.Sort((panel1, panel2) =>
            {
                Label label1 = (Label)panel1.Controls[1]; // Le label est le deuxième contrôle dans le TableLayoutPanel
                Label label2 = (Label)panel2.Controls[1];

                return string.Compare(label2.Text, label1.Text);
            });

            // Effacer les contrôles dans le FlowLayoutPanel
            flowLayoutPanel1.Controls.Clear();

            // Ajouter les TableLayoutPanel triés au FlowLayoutPanel
            foreach (var panel in panels)
            {
                flowLayoutPanel1.Controls.Add(panel);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {


            LoadImages();
        }
       
        public void bt_toexcel_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Le bouton a été cliqué !");
            //if (dgv_médicament.Rows.Count == 0)
            //{
            //    MessageBox.Show("Aucune donnée à exporter.");
            //    return;
            //}
            //SaveFileDialog saveFileDialog = new SaveFileDialog();
            //saveFileDialog.Filter = "Fichiers Excel (*.xlsx)|*.xlsx|Tous les fichiers (*.*)|*.*";
            //saveFileDialog.Title = "Enregistrer le fichier Excel";
            //saveFileDialog.FileName = "output.xlsx";

            //if (saveFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    m.ExportToExcel(dgv_médicament, saveFileDialog.FileName);
            //}
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Fichiers Excel (*.xlsx)|*.xlsx|Tous les fichiers (*.*)|*.*";
                saveFileDialog.Title = "Enregistrer le fichier Excel";
                saveFileDialog.FileName = "output.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    m.ExportToExcel(dgv_médicament, saveFileDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }

        }
        private void Print()
        {
            // Création d'une instance de PrintDocument
            var printDoc = new PrintDocument();

            // Gestion de l'événement PrintPage pour personnaliser le contenu de la page à imprimer
            printDoc.PrintPage += (s, ev) =>
            {
                // Définition de la police et de la couleur du texte
                var font = new System.Drawing.Font("Arial", 12);
                var brush = new SolidBrush(System.Drawing.Color.Black);

                //Récupération des données de la TextBox et du ComboBox
                d.connecter();

              
               
                //pb_médicament.Image = Image.FromStream(ms);
                var id = txt_id_médicament.Text;
                //var photoPath = txt_photo.Text;
                var categorie = comb_categorie.SelectedItem.ToString();
                var désignation = txt_désignation.Text;
                var achat = txt_prix_achat.Text;
                var vente = txt_prix_vente.Text;
                var quantite_min = txt_quantité_min.Text;
                var quantite_dispo = txt_quantité_max.Text;
                var util = txt_utilisation.Text;
                var contrindi = txt_contre_indication.Text;
                var effet = txt_effet_sec.Text;
                var pc = txt_taux_pc.Text;
                var code = txt_code_barre.Text;
                var date = dtp_date_expire.Text;
                var stckno = comb_stock.Text;
                var numvente = comb_vente_stock.Text;
                string espace = new string(' ', 60);


                // Chargement de l'image à partir du chemin spécifié
                Image photo = pb_médicament.Image;




                // Création de la chaîne à imprimer
                var text = $"{espace}Information de Médicament :\n\nID Médicament : {id}\n\n\nDésignation : {désignation}\n\n\n\nPrix d'Achat  : {achat}\n\n\nPrix de Vente : {vente}\n\n\nQuantite Minimale : {quantite_min}\n\n\nQuantite_Disponible : {quantite_dispo}\n\n\nUtilisation : {util}"+
                $"                                              \n\n\n\ncontre Indication  : {contrindi}\n\n\nLes effet Secondaires : {effet}\n\n\nTauc de Prise en Charge : {pc}\n\n\nCode barre : {code}\n\n\nDate d'éxpiration : {date}\n\n\nMouvement de stock : {stckno}\n\n\nnum_vente : {numvente}\n\n\ncatégorie : {categorie}";
               
                d.deconnecter();
                // Calcul de la position de départ pour l'impression
                var x = 100;
                var y = 50;

                // Dessin du texte sur la page
                ev.Graphics.DrawString(text, font, brush, x, y);
                // Dessin de l'image sur la page
                ev.Graphics.DrawImage(photo, new Rectangle(500, y + 100, 200, 200));
            };

            // Création de l'aperçu avant impression
            var printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDoc;

            // Affichage de l'aperçu avant impression
            printPreviewDialog.ShowDialog();
        }
    
        private void to_pdf_Click(object sender, EventArgs e)
        {
            if (txt_id_médicament.Text == "" || txt_photo.Text == "" || txt_désignation.Text == "" || txt_prix_achat.Text == "" || txt_prix_vente.Text == "" || txt_quantité_min.Text == "" || txt_quantité_max.Text == "" || txt_utilisation.Text == "" || txt_contre_indication.Text == "" || txt_effet_sec.Text == "" || txt_taux_pc.Text == "" || txt_code_barre.Text == "" || dtp_date_expire.Text == "" || comb_stock.Text == "" || comb_vente_stock.Text == "" || comb_categorie.Text == "")
            {
                MessageBox.Show("vous devez remplir tous les champs !", "Message",MessageBoxButtons.OK,MessageBoxIcon.Exclamation) ;
                return;
            }

            Print();
        }
    }
}
    
 
