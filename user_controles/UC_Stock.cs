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
    public partial class UC_Stock : UserControl
    {
        ADO d = new ADO();
        methodes m = new methodes();
        public UC_Stock()
        {
            InitializeComponent();
            m.RemplirComboBox(comboUtilisateurID, "UtilisateurID_Utilisateurs", "Utilisateurs_");

        }

        private void UC_Stock_Load(object sender, EventArgs e)
        {
            d.connecter();
            d.cmd.CommandText = "select * from Mouvements_stock ";
            d.cmd.Connection = d.con;
            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            dgvStock.DataSource = d.dt;
            d.dr.Close();
        }
        public int nombre()
        {
            int cpt;
            d.connecter();
            d.cmd.CommandText = "select count (MovementID_Mouvements_stock) from Mouvements_stock where MovementID_Mouvements_stock='" + txtStockID.Text + "'";
            d.cmd.Connection = d.con;
            cpt = (int)d.cmd.ExecuteScalar();
            return cpt;
        }
        public bool AjouterStock()
        {
            if (nombre() == 0)
            {
                d.cmd.CommandText = "SET IDENTITY_INSERT Mouvements_stock ON; " +
                                    "INSERT INTO Mouvements_stock (MovementID_Mouvements_stock, Quantite_deplacee_Mouvements_stock, Type_mouvement_Mouvements_stock, Date_Mouvements_stock, Notes_Mouvements_stock, UtilisateurID_Utilisateurs) " +
                                    "VALUES (@id, @quantite, @type, @date, @note, @utilisateur); " +
                                    "SET IDENTITY_INSERT Mouvements_stock OFF;";
                d.cmd.Parameters.Clear();
                d.cmd.Parameters.AddWithValue("@id", txtStockID.Text);
                d.cmd.Parameters.AddWithValue("@quantite", txtQunatiteStock.Text);
                d.cmd.Parameters.AddWithValue("@type", txtTypeStock.Text);
                d.cmd.Parameters.AddWithValue("@date", dtpDateStock.Value);
                d.cmd.Parameters.AddWithValue("@note", txtNote.Text);
                d.cmd.Parameters.AddWithValue("@utilisateur", comboUtilisateurID.Text);

                d.cmd.Connection = d.con;
                d.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }
        public bool ModifierStock()
        {
            d.connecter();
            if (nombre() != 0)
            {
                d.cmd.CommandText = "UPDATE Mouvements_stock SET Quantite_deplacee_Mouvements_stock=@quantite, " +
                                    "Type_mouvement_Mouvements_stock=@type, Date_Mouvements_stock=@date, " +
                                    "Notes_Mouvements_stock=@note, UtilisateurID_Utilisateurs=@utilisateur " +
                                    "WHERE MovementID_Mouvements_stock=@id";

                d.cmd.Parameters.Clear();
                d.cmd.Parameters.AddWithValue("@id", txtStockID.Text);
                d.cmd.Parameters.AddWithValue("@quantite", txtQunatiteStock.Text);
                d.cmd.Parameters.AddWithValue("@type", txtTypeStock.Text);
                d.cmd.Parameters.AddWithValue("@date", dtpDateStock.Value);
                d.cmd.Parameters.AddWithValue("@note", txtNote.Text);
                d.cmd.Parameters.AddWithValue("@utilisateur", comboUtilisateurID.Text);

                d.cmd.Connection = d.con;
                d.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }
        public bool SupprimerStock()
        {
            if (nombre() != 0)
            {
                d.cmd.CommandText = "DELETE FROM Mouvements_stock WHERE MovementID_Mouvements_stock = @id";
                d.cmd.Parameters.Clear();
                d.cmd.Parameters.AddWithValue("@id", txtStockID.Text);
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

        private void dgvStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStock.Rows[e.RowIndex];

                txtStockID.Text = row.Cells["MovementID_Mouvements_stock"].Value.ToString();
                txtQunatiteStock.Text = row.Cells["Quantite_deplacee_Mouvements_stock"].Value.ToString();
                txtTypeStock.Text = row.Cells["Type_mouvement_Mouvements_stock"].Value.ToString();
                dtpDateStock.Text = row.Cells["Date_Mouvements_stock"].Value.ToString();
                txtNote.Text = row.Cells["Notes_Mouvements_stock"].Value.ToString();
                comboUtilisateurID.Text = row.Cells["UtilisateurID_Utilisateurs"].Value.ToString();
            }
        }
        private void btn_ajouterStock_Click(object sender, EventArgs e)
        {

            if (txtStockID.Text == "" || txtQunatiteStock.Text == "" || txtTypeStock.Text == "" || dtpDateStock.Text == "" || txtNote.Text == "" || comboUtilisateurID.Text == "")
            {
                MessageBox.Show("Vous devez remplir tous les champs !", "Message");
                return;
            }

            if (AjouterStock())
            {
                MessageBox.Show("Opération Réussie", "Message");
                m.RemplirGrid("Mouvements_stock", dgvStock);
            }
            else
            {
                MessageBox.Show("Ce mouvement de stock existe déjà !", "Message");
            }
        }

        private void btn_supprimerStock_Click(object sender, EventArgs e)
        {

            if (txtStockID.Text == "")
            {
                MessageBox.Show("Veuillez saisir l'ID du mouvement à supprimer !", "Message");
                return;
            }

            if (SupprimerStock())
            {
                MessageBox.Show("Suppression réussie", "Message");
                m.RemplirGrid("Mouvements_stock", dgvStock);
            }
            else
            {
                MessageBox.Show("Ce mouvement de stock n'existe pas !", "Message");
            }
        }

        private void btn_ModifierStock_Click(object sender, EventArgs e)
        {

            if (txtStockID.Text == "" || txtQunatiteStock.Text == "" || txtTypeStock.Text == "" || dtpDateStock.Text == "" || txtNote.Text == "" || comboUtilisateurID.Text == "")
            {
                MessageBox.Show("Vous devez remplir tous les champs !", "Message");
                return;
            }

            if (ModifierStock())
            {
                MessageBox.Show("Modification réussie", "Message");
                m.RemplirGrid("Mouvements_stock", dgvStock);
            }
            else
            {
                MessageBox.Show("Erreur : ce mouvement n'existe pas ou doublon !", "Message");
            }


        }

        private void btn_ViderStock_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("voulez vous vider les champs ? ", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                VIDER(this);
        }
        private void Print()
        {
            var printDoc = new PrintDocument();

            printDoc.PrintPage += (s, ev) =>
            {
                var font = new System.Drawing.Font("Arial", 12);
                var brush = new SolidBrush(System.Drawing.Color.Black);

                d.connecter();

                string stockID = txtStockID.Text;
                string quantite = txtQunatiteStock.Text;
                string type = txtTypeStock.Text;
                string date = dtpDateStock.Text;
                string note = txtNote.Text;
                string utilisateur = comboUtilisateurID.Text;

                string espace = new string(' ', 60);

                var text = $"{espace}Informations sur le mouvement de stock :\n\n" +
                           $"ID Mouvement : {stockID}\n" +
                           $"Quantité déplacée : {quantite}\n" +
                           $"Type de mouvement : {type}\n" +
                           $"Date : {date}\n" +
                           $"Notes : {note}\n\n" +
                           $"Utilisateur ID : {utilisateur}\n";

                d.deconnecter();

                ev.Graphics.DrawString(text, font, brush, 100, 50);
            };

            var printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDoc;
            printPreviewDialog.ShowDialog();
        }

        private void to_pdf_Click(object sender, EventArgs e)
        {
            if (txtStockID.Text == "" || txtQunatiteStock.Text == "" || txtTypeStock.Text == "" || dtpDateStock.Text == "" || txtNote.Text == "" || comboUtilisateurID.Text == "")
            {
                MessageBox.Show("Vous devez remplir tous les champs !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Print();
        }

        private void bt_toexcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Fichiers Excel (*.xlsx)|*.xlsx|Tous les fichiers (*.*)|*.*";
            saveFileDialog.Title = "Enregistrer le fichier Excel";
            saveFileDialog.FileName = "stock_output.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                m.ExportToExcel(dgvStock, saveFileDialog.FileName);
            }
        }
    }

}
