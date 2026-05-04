using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj_pharmacell.user_controles
{
    public partial class UC_Fournisseur : UserControl
    {
        ADO d = new ADO();
        methodes m = new methodes();
        public UC_Fournisseur()
        {
            InitializeComponent();
            m.RemplirComboBox(combo_fourniseeur, "UtilisateurID_Utilisateurs", "Utilisateurs_");
        }
        private void UC_Fournisseur_Load(object sender, EventArgs e)
        {
            d.connecter();
            d.cmd.CommandText = "select * from Fournisseurs ";
            d.cmd.Connection = d.con;
            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            dgv_Fournisseur.DataSource = d.dt;
            d.dr.Close();
        }
        //declaration de la methode nombre
        public int nombre()
        {
            int cpt;
            d.connecter();
            d.cmd.CommandText = "select count (FournisseurID_Fournisseurs) from Fournisseurs where FournisseurID_Fournisseurs='" + txt_fournisseurId.Text + "'";
            d.cmd.Connection = d.con;
            cpt = (int)d.cmd.ExecuteScalar();
            return cpt;
        }
        // declration de la methode Ajouter
        public bool Ajouter()
        {
            if (nombre() == 0)
            {

                // Activation de IDENTITY_INSERT pour la table Ventes_
                d.cmd.CommandText = "SET IDENTITY_INSERT Fournisseurs ON; " +
                                    "INSERT INTO Fournisseurs (FournisseurID_Fournisseurs, Nom_Fournisseurs, Prenom_Fournisseurs, Adresse_Fournisseurs,Numero_TEL_Fournisseurs,UtilisateurID_Utilisateurs) " +
                                    "VALUES (@FournisseurId, @Nom_fourni, @Prenom_Fourni, @adr,@Tel,@Utiliateur_Id); " +
                                    "SET IDENTITY_INSERT Fournisseurs OFF;";
                d.cmd.Parameters.Clear();

                // Affectation des valeurs aux paramètres de la commande
                d.cmd.Parameters.AddWithValue("@FournisseurId", txt_fournisseurId.Text);
                d.cmd.Parameters.AddWithValue("@Nom_fourni", txt_nomf.Text) ;
                d.cmd.Parameters.AddWithValue("@Prenom_Fourni", txt_prenomf.Text);
                d.cmd.Parameters.AddWithValue("@adr", txt_addressef.Text);
                d.cmd.Parameters.AddWithValue("@Tel", txt_Telf.Text);
                d.cmd.Parameters.AddWithValue("@Utiliateur_Id", combo_fourniseeur.Text);


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

                d.cmd.CommandText = "UPDATE Fournisseurs SET Nom_Fournisseurs=@Nom_fourni, Prenom_Fournisseurs=@Prenom_Fourni, Adresse_Fournisseurs=@adr, Numero_TEL_Fournisseurs=@Tel, UtilisateurID_Utilisateurs=@Utiliateur_Id WHERE FournisseurID_Fournisseurs=@FournisseurId";

                // Clear existing parameters to avoid duplicates
                d.cmd.Parameters.Clear();

                // Add parameters
                d.cmd.Parameters.AddWithValue("@FournisseurId", txt_fournisseurId.Text);
                d.cmd.Parameters.AddWithValue("@Nom_fourni", txt_nomf.Text) ;
                d.cmd.Parameters.AddWithValue("@Prenom_Fourni", txt_prenomf.Text);
                d.cmd.Parameters.AddWithValue("@adr", txt_addressef.Text);
                d.cmd.Parameters.AddWithValue("@Tel", txt_Telf.Text);
                d.cmd.Parameters.AddWithValue("@Utiliateur_Id", combo_fourniseeur.Text);

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
                d.cmd.CommandText = "delete from Fournisseurs where FournisseurID_Fournisseurs='" + txt_fournisseurId.Text + "' ";
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

        private void dgv_Fournisseur_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Fournisseur.Rows[e.RowIndex];

                // Remplir les TextBox avec les valeurs de chaque colonne

                txt_fournisseurId.Text = row.Cells["FournisseurID_Fournisseurs"].Value.ToString();
                txt_nomf.Text = row.Cells["Nom_Fournisseurs"].Value.ToString();
                txt_prenomf.Text = row.Cells["Prenom_Fournisseurs"].Value.ToString();
                txt_addressef.Text = row.Cells["Adresse_Fournisseurs"].Value.ToString();
                txt_Telf.Text = row.Cells["Numero_TEL_Fournisseurs"].Value.ToString();
                combo_fourniseeur.Text = row.Cells["UtilisateurID_Utilisateurs"].Value.ToString();


            }
        }

        private void btn_ajouter_cmnd_Click(object sender, EventArgs e)
        {
            if (txt_fournisseurId.Text == "" || txt_nomf.Text == "" || txt_prenomf.Text == "" || txt_addressef.Text == "" || txt_Telf.Text == "" || combo_fourniseeur.Text == "")
            {
                MessageBox.Show("vous devez remplir tous les champs !", "Message");
                return;
            }
            if (Ajouter() == true)
            {
                MessageBox.Show("Opération Réussit ", "Message");
                m.RemplirGrid("Fournisseurs", dgv_Fournisseur);
                
            }
            else
            {
                MessageBox.Show("CE Fournisseur existe Déja !", "Message");
            }
        }

        private void btn_supprimer_cmnd_Click(object sender, EventArgs e)
        {
            if (txt_fournisseurId.Text == "")
            {
                MessageBox.Show("vous devez remplir tous les champs !", "Message");
                return;
            }
            if (Supprimer() == true)
            {
                MessageBox.Show("Opération Réussit ", "Message");
                m.RemplirGrid("Fournisseurs", dgv_Fournisseur);
            }
            else
            {
                MessageBox.Show("Ce Fournisseur n'existe pas !", "Message");
            }
        }

        private void btn_Modifier_cmnd_Click(object sender, EventArgs e)
        {
            if (txt_fournisseurId.Text == "" || txt_nomf.Text == "" || txt_prenomf.Text == "" || txt_addressef.Text == "" || txt_Telf.Text == "" || combo_fourniseeur.Text == "")
            {
                MessageBox.Show("vous devez remplir tous les champs !", "Message");
                return;
            }
            if (Modifier() == true)
            {
                MessageBox.Show("Opération Réussit ", "Message");
                m.RemplirGrid("Fournisseurs", dgv_Fournisseur);
            }
            else
            {
                MessageBox.Show("Ce Fournisseurs existe Déja !", "Message");
            }
        }

        private void btn_Vider_cmnd_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("voulez vous vider les champs ? ", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                VIDER(this);
            
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
                    m.ExportToExcel(dgv_Fournisseur, saveFileDialog.FileName);
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


                var fournisseurID = txt_fournisseurId.Text;
                var nomFournisseur = txt_nomf.Text;
                var prenomFournisseur = txt_prenomf.Text;
                var adresseFournisseur = txt_addressef.Text;
                var telFournisseur = txt_Telf.Text;
                var fournisseur = combo_fourniseeur.SelectedItem.ToString();
                var utilisateurID = combo_fourniseeur.SelectedItem.ToString();
                

                string espace = new string(' ', 60);



                // Création de la chaîne à imprimer
                var text = $"{espace}Informations sur le fournisseur et l'utilisateur :\n\n" +
                           $"Fournisseur ID : {fournisseurID}\n" +
                           $"Nom Fournisseur : {nomFournisseur}\n" +
                           $"Prénom Fournisseur : {prenomFournisseur}\n" +
                           $"Adresse Fournisseur : {adresseFournisseur}\n" +
                           $"Téléphone Fournisseur : {telFournisseur}\n\n" +
                           $"Utilisateur ID : {utilisateurID}\n";
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
            if (txt_fournisseurId.Text == "" || txt_nomf.Text == "" || txt_prenomf.Text == "" || txt_addressef.Text == "" || txt_Telf.Text == "" || combo_fourniseeur.Text == "")
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
                m.ExportToExcel(dgv_Fournisseur, saveFileDialog.FileName);
            }
        }



    }
}