
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj_pharmacell.user_controles
{
    public partial class UC_Commande : UserControl
    {
        ADO d = new ADO();
        methodes m = new methodes();
        public UC_Commande()
        {
            InitializeComponent();
            m.RemplirComboBox(combo_fourniseeur, "FournisseurID_Fournisseurs", "Fournisseurs");
            m.RemplirComboBox(combo_utilisateurid, "UtilisateurID_Utilisateurs", "Utilisateurs_");
            ChargerMedicaments();

        }
        //------------------------------------------------------------
    

        private void ChargerMedicaments()
        {
            try
            {
                d.connecter(); // Ouvre la connexion

                d.cmd = new SqlCommand("SELECT MedicamentID_Medicament,Designation_Medicament FROM Medicament", d.con);
                SqlDataAdapter da = new SqlDataAdapter(d.cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                combo_medicament.DataSource = dt;
                combo_medicament.DisplayMember = "Designation_Medicament"; // Ce que voit l'utilisateur
                combo_medicament.ValueMember = "MedicamentID_Medicament"; // Ce qu'on utilise dans les requêtes
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des médicaments : " + ex.Message);
            }
            finally
            {
                d.deconnecter(); // Ferme la connexion
            }
        }


        //------------------------------------------------------------
        private void UC_Commande_Load(object sender, EventArgs e)
        {
            d.connecter();
            d.cmd.CommandText = "select * from Commandes_d_approvisionnement ";
            d.cmd.Connection = d.con;
            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            dgv_commande.DataSource = d.dt;
            d.dr.Close();
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        //****************************************************Methodes d'implimentation*************************************************************************
        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        public int nombre()
        {
            int cpt;
            d.cmd.CommandText = "select count (Numero_Cmd_Commandes_approvisionnement) from Commandes_d_approvisionnement where Numero_Cmd_Commandes_approvisionnement='" + txt_num.Text + "'";
            d.cmd.Connection = d.con;
            cpt = (int)d.cmd.ExecuteScalar();
            return cpt;
        }


        public bool Ajouter()
        {
            if (nombre() == 0)
            {
                // Activation de IDENTITY_INSERT pour la table Ventes_
                d.cmd.CommandText = "SET IDENTITY_INSERT Commandes_d_approvisionnement ON; " +
                                    "INSERT INTO Commandes_d_approvisionnement (Numero_Cmd_Commandes_approvisionnement, Date_Commande_Commandes_approvisionnement, Quantite_Commandes_approvisionnement, Cout_total_Commandes_approvisionnement, Statut_Commandes_approvisionnement, FournisseurID_Fournisseurs,UtilisateurID_Utilisateurs,MedicamentID_Medicament) " +
                                    "VALUES (@numcmnd, @date, @quantite, @Cout, @Statue, @FournisseurID,@UtilisateurID,@MedicamentID); " +
                                    "SET IDENTITY_INSERT Commandes_d_approvisionnement OFF;";

                d.cmd.Parameters.Clear();
                // Affectation des valeurs aux paramètres de la commande
                d.cmd.Parameters.AddWithValue("@numcmnd", txt_num.Text);
                d.cmd.Parameters.AddWithValue("@date", dtp_DAte.Value);
                d.cmd.Parameters.AddWithValue("@quantite", txt_quantite.Text);
                d.cmd.Parameters.AddWithValue("@cout", txt_cout.Text);
                d.cmd.Parameters.AddWithValue("@statue", txt_statue.Text);
                d.cmd.Parameters.AddWithValue("@FournisseurID", combo_fourniseeur.Text);
                d.cmd.Parameters.AddWithValue("@UtilisateurID", combo_utilisateurid.Text);
                d.cmd.Parameters.AddWithValue("@MedicamentID", combo_medicament.SelectedValue);
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
                d.cmd.CommandText = "delete from Commandes_d_approvisionnement where Numero_Cmd_Commandes_approvisionnement='" + txt_num.Text + "' ";
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
                //(Numero_Cmd_Commandes_approvisionnement, Date_Commande_Commandes_approvisionnement, Quantite_Commandes_approvisionnement, Cout_total_Commandes_approvisionnement, Statut_Commandes_approvisionnement, FournisseurID_Fournisseurs,UtilisateurID_Utilisateurs,MedicamentID_Medicament)
                //@numcmnd, @date, @quantite, @Cout, @Statue, @FournisseurID,@UtilisateurID,@MedicamentID)
                d.cmd.CommandText = "UPDATE Commandes_d_approvisionnement SET  Date_Commande_Commandes_approvisionnement=@date, Quantite_Commandes_approvisionnement=@quantite, Cout_total_Commandes_approvisionnement=@Cout, Statut_Commandes_approvisionnement=@Statue,FournisseurID_Fournisseurs=@FournisseurID, UtilisateurID_Utilisateurs=@UtilisateurID,MedicamentID_Medicament=@MedicamentID WHERE Numero_Cmd_Commandes_approvisionnement=@numcmnd";

                // Clear existing parameters to avoid duplicates
                d.cmd.Parameters.Clear();

                // Add parameters

                d.cmd.Parameters.AddWithValue("@numcmnd", txt_num.Text);
                d.cmd.Parameters.AddWithValue("@date", DateTime.Parse(dtp_DAte.Text));
                d.cmd.Parameters.AddWithValue("@quantite", txt_quantite.Text);
                d.cmd.Parameters.AddWithValue("@cout", txt_cout.Text);
                d.cmd.Parameters.AddWithValue("@statue", txt_statue.Text);
                d.cmd.Parameters.AddWithValue("@FournisseurID", combo_fourniseeur.Text);
                d.cmd.Parameters.AddWithValue("@UtilisateurID", combo_utilisateurid.Text);
                d.cmd.Parameters.AddWithValue("@MedicamentID", combo_medicament.Text);
                d.cmd.Connection = d.con;
                d.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }
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
        //methode de remplisssage
        public void RemplirGrid()
        {
            if (d.dt.Rows != null)
            {
                d.dt.Clear();
            }
            d.cmd.CommandText = "select * from Commandes_d_approvisionnement ";
            d.cmd.Connection = d.con;
            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            dgv_commande.DataSource = d.dt;
            d.dr.Close();
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //****************************************************  boutons[Ajouter/Supprimer/Modifier/Vider]   *************************************************************************
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void btn_ajouter_client_Click(object sender, EventArgs e)
        {
            if (txt_num.Text == "" || txt_quantite.Text == "" || txt_cout.Text == "" || txt_statue.Text == "" || combo_fourniseeur.Text == "" || combo_utilisateurid.Text == "" || combo_medicament.Text == "")
            {
                MessageBox.Show("vous devez remplir tous les champs !", "Message");
                return;
            }
            if (Ajouter() == true)
            {
                MessageBox.Show("Opération Réussit ", "Message");
                RemplirGrid();
                VIDER(this);

            }
            else
            {
                MessageBox.Show("Cette commande existe Déja !", "Message");
            }
        }

        private void btn_supprimer_client_Click(object sender, EventArgs e)
        {
            if (txt_num.Text == "")
            {
                MessageBox.Show("vous devez remplir tous les champs !", "Message");
                return;
            }
            if (Supprimer() == true)
            {
                MessageBox.Show("Opération Réussit ", "Message");
                RemplirGrid();
                VIDER(this);
            }
            else
            {
                MessageBox.Show("Cette commande n'existe pas !", "Message");
            }
        }

        private void btn_Modifier_client_Click(object sender, EventArgs e)
        {
            if (txt_num.Text == "" || txt_quantite.Text == "" || txt_cout.Text == "" || txt_statue.Text == "" || combo_fourniseeur.Text == "" || combo_utilisateurid.Text == "" || combo_medicament.Text == "")
            {
                MessageBox.Show("vous devez remplir tous les champs !", "Message");
                return;
            }
            if (Modifier() == true)
            {
                MessageBox.Show("Opération Réussit ", "Message");
                RemplirGrid();
                VIDER(this);
            }
            else
            {
                MessageBox.Show("Cette commande existe Déja !", "Message");
            }
        }

        private void btn_Vider_client_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez vous vider les champs ? ", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                VIDER(this);
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //****************************************************  remplissage des donne en cliquant sur dgv  *************************************************************************
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void dgv_client_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_commande.Rows[e.RowIndex];

                // Remplir les TextBox avec les valeurs de chaque colonne
                txt_num.Text = row.Cells["Numero_Cmd_Commandes_approvisionnement"].Value.ToString();
                dtp_DAte.Text = row.Cells["Date_Commande_Commandes_approvisionnement"].Value.ToString();
                txt_quantite.Text = row.Cells["Quantite_Commandes_approvisionnement"].Value.ToString();
                txt_cout.Text = row.Cells["Cout_total_Commandes_approvisionnement"].Value.ToString();
                txt_statue.Text = row.Cells["Statut_Commandes_approvisionnement"].Value.ToString();
                combo_fourniseeur.Text = row.Cells["FournisseurID_Fournisseurs"].Value.ToString();
                combo_utilisateurid.Text = row.Cells["UtilisateurID_Utilisateurs"].Value.ToString();
                combo_medicament.Text = row.Cells["MedicamentID_Medicament"].Value.ToString();



            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //****************************************************  creation d'une copie de dgv en excel   *************************************************************************
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void bt_toexcel_Click(object sender, EventArgs e)
        {
           
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //**************************************************** Aprçu avant l'impression   *************************************************************************
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------

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


                var num = txt_num.Text;
                var date = dtp_DAte.Text;
                var quantite = txt_quantite.Text;
                var cout = txt_cout.Text;
                var statue = txt_statue.Text;
                var fournisseur = combo_fourniseeur.SelectedItem.ToString();
                var utilisateurid = combo_utilisateurid.SelectedItem.ToString();
                var medicamentid = combo_medicament.SelectedItem.ToString();

                string espace = new string(' ', 60);



                // Création de la chaîne à imprimer
                var text = $"{espace}Information de Commande :\n\nNuméro de commande : {num}\n\n\ndate : {date}\n\n\nQuantite : {quantite}\n\n\nCoût total : {cout}\n\n\nStatut de Commandes : {statue}\n\n\n\nFournisseur ID: {fournisseur}\n\n\n\nUtilisateur ID: {fournisseur}\n\n\nMédicament ID: {medicamentid}";

                d.deconnecter();
                // Calcul de la position de départ pour l'impression
                var x = 100;
                var y = 50;
                // Dessin du texte sur la page
                ev.Graphics.DrawString(text, font, brush, x, y);
            };

            // Création de l'aperçu avant impression
            var printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDoc;


            // Affichage de l'aperçu avant impression
            printPreviewDialog.ShowDialog();
        }
        private void to_pdf_Click(object sender, EventArgs e)
        {
            if (txt_num.Text == "" || txt_quantite.Text == "" || txt_cout.Text == "" || txt_statue.Text == "" || combo_fourniseeur.Text == "" || combo_utilisateurid.Text == "" || combo_medicament.Text == "")
            {
                MessageBox.Show("vous devez remplir tous les champs !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Print();
        }

        private void to_pdf_Click_1(object sender, EventArgs e)
        {
            if (txt_num.Text == "" || dtp_DAte.Text == "" || txt_quantite.Text == "" || txt_cout.Text == "" || txt_statue.Text == "" || combo_fourniseeur.Text == "" || combo_medicament.Text == "" || combo_utilisateurid.Text == "" )
            {
                MessageBox.Show("vous devez remplir tous les champs !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Print();
        }

        private void bt_toexcel_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Fichiers Excel (*.xlsx)|*.xlsx|Tous les fichiers (*.*)|*.*";
            saveFileDialog.Title = "Enregistrer le fichier Excel";
            saveFileDialog.FileName = "output.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                m.ExportToExcel(dgv_commande, saveFileDialog.FileName);
            }
        }
    }
}
