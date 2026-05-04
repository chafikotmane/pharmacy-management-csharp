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
using System.Data;
using System.Drawing.Printing;
using DocumentFormat.OpenXml.InkML;

namespace proj_pharmacell.user_controles
{
    public partial class uc_vente : UserControl
    {
        methodes m = new methodes();
        public uc_vente()
        {
            InitializeComponent();
            methodes m = new methodes();
            m.RemplirComboBox(combo_id_client, "ClientID_Clients", "Clients");
            m.RemplirComboBox(combo_id_utilisateur, "UtilisateurID_Utilisateurs", "Utilisateurs_");

        }
        ADO d = new ADO();
        //declaration de la methode nombre 

        private void uc_vente_Load(object sender, EventArgs e)
        {
            d.connecter();
            d.cmd.CommandText = "select * from Ventes_ ";
            d.cmd.Connection = d.con;
            d.dr=d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            dgv_vente.DataSource = d.dt;
            d.dr.Close();
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        //****************************************************Methodes d'implimentation*************************************************************************
        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        public int nombre()
        {
            int cpt;
            d.cmd.CommandText = "select count (Num_Vente_Ventes) from Ventes_ where Num_Vente_Ventes='" + txt_num_vente.Text + "'";
            d.cmd.Connection = d.con;
            cpt = (int)d.cmd.ExecuteScalar();
            return cpt;
        }


        public bool Ajouter()
        {
            if (nombre() == 0)
            {
                // Activation de IDENTITY_INSERT pour la table Ventes_
                d.cmd.CommandText = "SET IDENTITY_INSERT Ventes_ ON; " +
                                    "INSERT INTO Ventes_ (Num_Vente_Ventes, Date_Vente_Ventes, Quantite_Vendue_Ventes, Prix_Total_Ventes, Mode_Paiement_Ventes, ClientID_Clients, UtilisateurID_Utilisateurs) " +
                                    "VALUES (@Num_Vente, @Date_Vente, @Quantite_Vendue, @Prix_Total, @Mode_Paiement, @Clientid, @UtilisateurID); " +
                                    "SET IDENTITY_INSERT Ventes_ OFF;";

                d.cmd.Parameters.Clear();
                // Affectation des valeurs aux paramètres de la commande
                d.cmd.Parameters.AddWithValue("@Num_Vente", txt_num_vente.Text);
                d.cmd.Parameters.AddWithValue("@Date_Vente", DateTime.Parse(txt_date.Text));
                d.cmd.Parameters.AddWithValue("@Quantite_Vendue", txt_quantite.Text);
                d.cmd.Parameters.AddWithValue("@Prix_Total", txt_prix_total.Text);
                d.cmd.Parameters.AddWithValue("@Mode_Paiement", combo_paiment.Text);
                d.cmd.Parameters.AddWithValue("@Clientid", combo_id_client.Text);
                d.cmd.Parameters.AddWithValue("@UtilisateurID", combo_id_utilisateur.Text);

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
                d.cmd.CommandText = "delete from Ventes_ where Num_Vente_Ventes='" + txt_num_vente.Text + "' ";
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

                d.cmd.CommandText = "UPDATE Ventes_ SET Date_Vente_Ventes=@date, Quantite_Vendue_Ventes=@quantite, Prix_Total_Ventes=@prix, Mode_Paiement_Ventes=@paiment, ClientID_Clients=@clientid, UtilisateurID_Utilisateurs=@utilisateurid WHERE Num_Vente_Ventes=@numvente";

                // Clear existing parameters to avoid duplicates
                d.cmd.Parameters.Clear();

                // Add parameters
                d.cmd.Parameters.AddWithValue("@numvente", txt_num_vente.Text);
                d.cmd.Parameters.AddWithValue("@date", DateTime.Parse(txt_date.Text));
                d.cmd.Parameters.AddWithValue("@quantite", txt_quantite.Text);
                d.cmd.Parameters.AddWithValue("@prix", txt_prix_total.Text);
                d.cmd.Parameters.AddWithValue("@paiment", combo_paiment.Text);
                d.cmd.Parameters.AddWithValue("@clientid", combo_id_client.Text);
                d.cmd.Parameters.AddWithValue("@utilisateurid", combo_id_utilisateur.Text);

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
            d.cmd.CommandText = "select * from Ventes_ ";
            d.cmd.Connection = d.con;
            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            dgv_vente.DataSource = d.dt;
            d.dr.Close();
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //****************************************************  boutons[Ajouter/Supprimer/Modifier/Vider]   *************************************************************************
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void btn_ajouter_vente_Click(object sender, EventArgs e)
        {
            if (txt_num_vente.Text == "" || txt_date.Text == "" || txt_quantite.Text == "" || txt_prix_total.Text == "" || combo_paiment.Text == ""||combo_id_client.Text == "" || combo_id_utilisateur.Text == "")
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
                MessageBox.Show("Cette Vente existe Déja !", "Message");
            }
        }

        private void btn_supprimer_vente_Click(object sender, EventArgs e)
        {
            if (txt_num_vente.Text == "")
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
                MessageBox.Show("Cette Vente n'éxiste pas !", "Message");
            }
        }

        private void btn_Modifier_vente_Click(object sender, EventArgs e)
        {
            if (txt_num_vente.Text == "" || txt_date.Text == "" || txt_quantite.Text == "" || txt_prix_total.Text == "" || combo_paiment.Text == "" || combo_id_client.Text == "" || combo_id_utilisateur.Text == "")
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
                MessageBox.Show("Cette Vente existe Déja !", "Message");
            }
        }

        private void btn_Vider_vente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez vous vider les champs ? ", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                VIDER(this);
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //****************************************************  texbox date    *************************************************************************
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void dt_date_ValueChanged(object sender, EventArgs e)
        {
            txt_date.Text = dt_date.Value.ToString();
        }

        private void dgv_vente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_vente.Rows[e.RowIndex];

                // Remplir les TextBox avec les valeurs de chaque colonne
                txt_num_vente.Text = row.Cells["Num_Vente_Ventes"].Value.ToString();
                txt_date.Text = row.Cells["Date_Vente_Ventes"].Value.ToString();
                txt_quantite.Text = row.Cells["Quantite_vendue_Ventes"].Value.ToString();
                txt_prix_total.Text = row.Cells["Prix_total_Ventes"].Value.ToString();
                combo_paiment.Text = row.Cells["Mode_paiement_Ventes"].Value.ToString();
                combo_id_client.Text = row.Cells["ClientID_Clients"].Value.ToString();
                combo_id_utilisateur.Text = row.Cells["UtilisateurID_Utilisateurs"].Value.ToString();

            }
        }

        private void bt_toexcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Fichiers Excel (*.xlsx)|*.xlsx|Tous les fichiers (*.*)|*.*";
            saveFileDialog.Title = "Enregistrer le fichier Excel";
            saveFileDialog.FileName = "output.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                m.ExportToExcel(dgv_vente, saveFileDialog.FileName);
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


                var vente = txt_num_vente.Text;
                var date = txt_date.Text;
                var quantite = txt_quantite.Text;
                var prix = txt_prix_total.Text;
                var paiment = combo_paiment.SelectedItem.ToString();
                var clientid = combo_id_client.SelectedItem.ToString();
                var utilisateurid =combo_id_utilisateur.SelectedItem.ToString();
              
                string espace = new string(' ', 60);


                
                // Création de la chaîne à imprimer
                var text = $"{espace}Information de Vente :\n\nNuméro de Vente : {vente}\n\n\nDate : {date}\n\n\n\nQuantité vendue : {quantite}\n\n\nPrix Total : {prix}\n\n\nMode de paiment : {paiment}\n\n\nClien Id : {clientid}\n\n\nUtilisateur Id: {utilisateurid}" ;

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
            if(txt_num_vente.Text == "" || txt_date.Text == "" || txt_quantite.Text == "" || txt_prix_total.Text == "" || combo_paiment.Text == "" || combo_id_client.Text == "" || combo_id_utilisateur.Text == "")
            {
                MessageBox.Show("vous devez remplir tous les champs !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Print();
        }


    }

}
