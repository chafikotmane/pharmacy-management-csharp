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
    public partial class UC_Client : UserControl
    {
        ADO d = new ADO();
        methodes m = new methodes();
        public UC_Client()
        {
            InitializeComponent();
            m.RemplirComboBox(combo_utilisateurid, "UtilisateurID_Utilisateurs", "Utilisateurs_");

        }

        private void UC_Client_Load(object sender, EventArgs e)
        {
            d.connecter();
            d.cmd.CommandText = "select * from Clients ";
            d.cmd.Connection = d.con;
            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            dgv_client.DataSource = d.dt;
            d.dr.Close();
            
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        //****************************************************Methodes d'implimentation*************************************************************************
        //-------------------------------------------------------------------------------------------------------------------------------------------------------
      
        
        
        public int nombre()
        {
            int cpt;
            d.cmd.CommandText = "select count (ClientID_Clients) from Clients where ClientID_Clients='" + txt_clientid.Text + "'";
            d.cmd.Connection = d.con;
            cpt = (int)d.cmd.ExecuteScalar();
            return cpt;
        }


        public bool Ajouter()
        {
            if (nombre() == 0)
            {
                // Activation de IDENTITY_INSERT pour la table Ventes_
                d.cmd.CommandText = "SET IDENTITY_INSERT Clients ON; " +
                                    "INSERT INTO Clients (ClientID_Clients, Nom_Clients, Prenom_Clients, Adresse_Clients, Numero_TEL_Clients, UtilisateurID_Utilisateurs) " +
                                    "VALUES (@ClientID, @nom, @prenom, @addresse, @tel, @UtilisateurID); " +
                                    "SET IDENTITY_INSERT Clients OFF;";

                d.cmd.Parameters.Clear();
                // Affectation des valeurs aux paramètres de la commande
                d.cmd.Parameters.AddWithValue("@ClientID", txt_clientid.Text);
                d.cmd.Parameters.AddWithValue("@nom", txt_nom.Text);
                d.cmd.Parameters.AddWithValue("@prenom", txt_prenom.Text);
                d.cmd.Parameters.AddWithValue("@addresse", txt_adrr.Text);
                d.cmd.Parameters.AddWithValue("@tel", txt_tel.Text);
                d.cmd.Parameters.AddWithValue("@UtilisateurID", combo_utilisateurid.Text);

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
                d.cmd.CommandText = "delete from Clients where ClientID_Clients='" + txt_clientid.Text + "' ";
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

                d.cmd.CommandText = "UPDATE Clients SET  Nom_Clients=@nom, Prenom_Clients=@prenom, Adresse_Clients=@addresse, Numero_TEL_Clients=@tel, UtilisateurID_Utilisateurs=@UtilisateurID WHERE ClientID_Clients=@clientID";

                // Clear existing parameters to avoid duplicates
                d.cmd.Parameters.Clear();

                // Add parameters
                
                d.cmd.Parameters.AddWithValue("@nom", txt_nom.Text);
                d.cmd.Parameters.AddWithValue("@prenom", txt_prenom.Text);
                d.cmd.Parameters.AddWithValue("@addresse", txt_adrr.Text);
                d.cmd.Parameters.AddWithValue("@tel", txt_tel.Text);
                d.cmd.Parameters.AddWithValue("@UtilisateurID", combo_utilisateurid.Text);
                d.cmd.Parameters.AddWithValue("@clientid", txt_clientid.Text);
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
            d.cmd.CommandText = "select * from Clients ";
            d.cmd.Connection = d.con;
            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            dgv_client.DataSource = d.dt;
            d.dr.Close();
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //****************************************************  boutons[Ajouter/Supprimer/Modifier/Vider]   *************************************************************************
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void btn_ajouter_client_Click(object sender, EventArgs e)
        {
            if (txt_clientid.Text == "" || txt_nom.Text == "" || txt_prenom.Text == "" || txt_adrr.Text == "" || txt_tel.Text == "" || combo_utilisateurid.Text == "" )
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
                MessageBox.Show("Ce client existe Déja !", "Message");
            }
        }

        private void btn_supprimer_client_Click(object sender, EventArgs e)
        {
            if (txt_clientid.Text == "")
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
                MessageBox.Show("Ce  client n'éxiste pas !", "Message");
            }
        }

        private void btn_Modifier_client_Click(object sender, EventArgs e)
        {
            if (txt_clientid.Text == "" || txt_nom.Text == "" || txt_prenom.Text == "" || txt_adrr.Text == "" || txt_tel.Text == "" || combo_utilisateurid.Text == "")
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
                MessageBox.Show("Ce client existe Déja !", "Message");
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
                DataGridViewRow row = dgv_client.Rows[e.RowIndex];

                // Remplir les TextBox avec les valeurs de chaque colonne
                txt_clientid.Text = row.Cells["ClientID_Clients"].Value.ToString();
                txt_nom.Text = row.Cells["Nom_Clients"].Value.ToString();
                txt_prenom.Text = row.Cells["Prenom_Clients"].Value.ToString();
                txt_adrr.Text = row.Cells["Adresse_Clients"].Value.ToString();
                txt_tel.Text = row.Cells["Numero_TEL_Clients"].Value.ToString();
                combo_utilisateurid.Text = row.Cells["UtilisateurID_Utilisateurs"].Value.ToString();

            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //****************************************************  creation d'une copie de dgv en excel   *************************************************************************
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void bt_toexcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Fichiers Excel (*.xlsx)|*.xlsx|Tous les fichiers (*.*)|*.*";
            saveFileDialog.Title = "Enregistrer le fichier Excel";
            saveFileDialog.FileName = "output.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                m.ExportToExcel(dgv_client, saveFileDialog.FileName);
            }
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


                var Clientid = txt_clientid.Text;
                var nom = txt_nom.Text;
                var prenom = txt_prenom.Text;
                var adress = txt_adrr.Text;
                var tel = txt_tel.Text;
                var utilisateurid = combo_utilisateurid.SelectedItem.ToString();

                string espace = new string(' ', 60);



                // Création de la chaîne à imprimer
                var text = $"{espace}Information de Vente :\n\nNuméro de Client : {Clientid}\n\n\nNom : {nom}\n\n\n\nPrénom : {prenom}\n\n\nAdresse : {adress}\n\n\nTéléphone : {tel}\n\n\n\nUtilisateur Id: {utilisateurid}";

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
            if (txt_clientid.Text == "" || txt_nom.Text == "" || txt_prenom.Text == "" || txt_adrr.Text == "" || txt_tel.Text == "" || combo_utilisateurid.Text == "")
            {
                MessageBox.Show("vous devez remplir tous les champs !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Print();
        }
    }
}
