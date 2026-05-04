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
    public partial class UC_Ordonnance : UserControl
    {
        ADO d = new ADO();
        methodes m = new methodes();
        public UC_Ordonnance()
        {
            InitializeComponent();
            m.RemplirComboBox(comboClientID, "ClientID_Clients", "Clients");
            m.RemplirComboBox(ComboMedicamentID, "MedicamentID_Medicament", "Medicament");
            m.RemplirComboBox(ComboUtilisateurID, "UtilisateurID_Utilisateurs", "Utilisateurs_");

        }

        private void UC_Ordonnance_Load(object sender, EventArgs e)
        {
            d.connecter();
            d.cmd.CommandText = "select * from Ordonnances_ ";
            d.cmd.Connection = d.con;
            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            dgv_orodonnance.DataSource = d.dt;
            d.dr.Close();
        }
        //declaration de la methode nombre
        public int nombre()
        {
            int cpt;
            d.connecter();
            d.cmd.CommandText = "select count (OrdenanceID_Ordonnances) from Ordonnances_ where OrdenanceID_Ordonnances='" + txtOrdonnanceID.Text + "'";
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
                d.cmd.CommandText = "SET IDENTITY_INSERT Ordonnances_ ON; " +
                                    "INSERT INTO Ordonnances_ (OrdenanceID_Ordonnances, Medecin_prescripteur_Ordonnances, Date_prescription_Ordonnances, Quantite_Ordonnances,Statut_Ordonnances,ClientID_Clients,MedicamentID_Medicament,UtilisateurID_Utilisateurs) " +
                                    "VALUES (@ordoID, @medcinPersp, @DatePersp, @quantite,@statueOrd,@clientID,@MedicamentID,@UtilisateurID); " +
                                    "SET IDENTITY_INSERT Ordonnances_ OFF;";
                d.cmd.Parameters.Clear();

                // Affectation des valeurs aux paramètres de la commande
                d.cmd.Parameters.AddWithValue("@ordoID", txtOrdonnanceID.Text);
                d.cmd.Parameters.AddWithValue("@medcinPersp", txtMedcinPers.Text);
                d.cmd.Parameters.AddWithValue("@DatePersp", DateTime.Parse(dtpDatePersp.Text));
                d.cmd.Parameters.AddWithValue("@quantite", txt_QuantiteOrd.Text);
                d.cmd.Parameters.AddWithValue("@statueOrd", txtStatueOrdo.Text);
                d.cmd.Parameters.AddWithValue("@clientID", comboClientID.Text);
                d.cmd.Parameters.AddWithValue("@MedicamentID", ComboMedicamentID.Text);
                d.cmd.Parameters.AddWithValue("@UtilisateurID", ComboUtilisateurID.Text);


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

                d.cmd.CommandText = "UPDATE Ordonnances_ SET Medecin_prescripteur_Ordonnances=@medcinPersp, Date_prescription_Ordonnances=@DatePersp, Quantite_Ordonnances=@quantite, Statut_Ordonnances=@statueOrd, ClientID_Clients=@clientID,MedicamentID_Medicament=@MedicamentID,UtilisateurID_Utilisateurs=@UtilisateurID WHERE OrdenanceID_Ordonnances=@ordoID";

                // Clear existing parameters to avoid duplicates
                d.cmd.Parameters.Clear();

                // Add parameters
                d.cmd.Parameters.AddWithValue("@ordoID", txtOrdonnanceID.Text);
                d.cmd.Parameters.AddWithValue("@medcinPersp", txtMedcinPers.Text);
                d.cmd.Parameters.AddWithValue("@DatePersp", DateTime.Parse(dtpDatePersp.Text));
                d.cmd.Parameters.AddWithValue("@quantite", txt_QuantiteOrd.Text);
                d.cmd.Parameters.AddWithValue("@statueOrd", txtStatueOrdo.Text);
                d.cmd.Parameters.AddWithValue("@clientID", comboClientID.Text);
                d.cmd.Parameters.AddWithValue("@MedicamentID", ComboMedicamentID.Text);
                d.cmd.Parameters.AddWithValue("@UtilisateurID", ComboUtilisateurID.Text);

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
                d.cmd.CommandText = "delete from Ordonnances_ where OrdenanceID_Ordonnances='" + txtOrdonnanceID.Text + "' ";
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

        private void dgv_orodonnance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_orodonnance.Rows[e.RowIndex];

                // Remplir les TextBox avec les valeurs de chaque colonne

                txtOrdonnanceID.Text = row.Cells["OrdenanceID_Ordonnances"].Value.ToString();
                txtMedcinPers.Text = row.Cells["Medecin_prescripteur_Ordonnances"].Value.ToString();
                dtpDatePersp.Text = row.Cells["Date_prescription_Ordonnances"].Value.ToString();
                txt_QuantiteOrd.Text = row.Cells["Quantite_Ordonnances"].Value.ToString();
                txtStatueOrdo.Text = row.Cells["Statut_Ordonnances"].Value.ToString();
                comboClientID.Text = row.Cells["ClientID_Clients"].Value.ToString();
                ComboMedicamentID.Text = row.Cells["MedicamentID_Medicament"].Value.ToString();
                ComboUtilisateurID.Text = row.Cells["UtilisateurID_Utilisateurs"].Value.ToString();


            }
        }

        private void btn_ajouter_ordo_Click(object sender, EventArgs e)
        {
            if (txtOrdonnanceID.Text == "" || txtMedcinPers.Text == "" || txt_QuantiteOrd.Text == "" ||
       txtStatueOrdo.Text == "" || comboClientID.Text == "" || ComboMedicamentID.Text == "" ||
       ComboUtilisateurID.Text == "")
            {
                MessageBox.Show("Vous devez remplir tous les champs !", "Message");
                return;
            }

            if (Ajouter() == true)
            {
                MessageBox.Show("Opération Réussie", "Message");
                m.RemplirGrid("Ordonnances_", dgv_orodonnance);
            }
            else
            {
                MessageBox.Show("Cette ordonnance existe déjà !", "Message");
            }
        }

        private void btn_supprimer_ordo_Click(object sender, EventArgs e)
        {
            if (txtOrdonnanceID.Text == "")
            {
                MessageBox.Show("Veuillez saisir l'ID de l'ordonnance à supprimer !", "Message");
                return;
            }

            if (Supprimer() == true)
            {
                MessageBox.Show("Opération Réussie", "Message");
                m.RemplirGrid("Ordonnances_", dgv_orodonnance);
            }
            else
            {
                MessageBox.Show("Cette ordonnance n'existe pas !", "Message");
            }
        }

        private void btn_Modifier_ordo_Click(object sender, EventArgs e)
        {
            if (txtOrdonnanceID.Text == "" || txtMedcinPers.Text == "" || txt_QuantiteOrd.Text == "" ||
       txtStatueOrdo.Text == "" || comboClientID.Text == "" || ComboMedicamentID.Text == "" ||
       ComboUtilisateurID.Text == "")
            {
                MessageBox.Show("Vous devez remplir tous les champs !", "Message");
                return;
            }

            if (Modifier() == true)
            {
                MessageBox.Show("Modification réussie", "Message");
                m.RemplirGrid("Ordonnances_", dgv_orodonnance);
            }
            else
            {
                MessageBox.Show("Erreur ou ordonnance existante !", "Message");
            }
        }

        private void btn_Vider_ordo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vider les champs ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                VIDER(this);
            }
        }

        private void bt_toexcel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Fichiers Excel (*.xlsx)|*.xlsx|Tous les fichiers (*.*)|*.*";
                saveFileDialog.Title = "Enregistrer le fichier Excel";
                saveFileDialog.FileName = "output.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    m.ExportToExcel(dgv_orodonnance, saveFileDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }
        private void Print()
        {
            var printDoc = new PrintDocument();

            printDoc.PrintPage += (s, ev) =>
            {
                var font = new System.Drawing.Font("Arial", 12);
                var brush = new SolidBrush(System.Drawing.Color.Black);

                d.connecter();

                // Récupération des données du formulaire Ordonnance
                var ordonnanceID = txtOrdonnanceID.Text;
                var medecinPrescripteur = txtMedcinPers.Text;
                var datePrescription = dtpDatePersp.Text;
                var quantite = txt_QuantiteOrd.Text;
                var statut = txtStatueOrdo.Text;
                var clientID = comboClientID.Text;
                var medicamentID = ComboMedicamentID.Text;
                var utilisateurID = ComboUtilisateurID.Text;

                string espace = new string(' ', 60);

                var text = $"{espace}Informations de l'ordonnance\n\n" +
                           $"Ordonnance ID : {ordonnanceID}\n" +
                           $"Médecin prescripteur : {medecinPrescripteur}\n" +
                           $"Date de prescription : {datePrescription}\n" +
                           $"Quantité : {quantite}\n" +
                           $"Statut : {statut}\n\n" +
                           $"Client ID : {clientID}\n" +
                           $"Médicament ID : {medicamentID}\n" +
                           $"Utilisateur ID : {utilisateurID}\n";

                d.deconnecter();

                ev.Graphics.DrawString(text, font, brush, 100, 50);
            };

            var printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDoc;
            printPreviewDialog.ShowDialog();
        }
        private void to_pdf_Click(object sender, EventArgs e)
        {
            if (txtOrdonnanceID.Text == "" || txtMedcinPers.Text == "" || txt_QuantiteOrd.Text == "" ||
                txtStatueOrdo.Text == "" || comboClientID.Text == "" || ComboMedicamentID.Text == "" || ComboUtilisateurID.Text == "")
            {
                MessageBox.Show("Vous devez remplir tous les champs !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Print(); // Appel de la méthode Print pour prévisualiser et imprimer
        }

        private void to_pdf_Click_1(object sender, EventArgs e)
        {
            if (txtOrdonnanceID.Text == "" || txtMedcinPers.Text == "" || dtpDatePersp.Text == "" ||
        txt_QuantiteOrd.Text == "" || txtStatueOrdo.Text == "" ||
        comboClientID.Text == "" || ComboMedicamentID.Text == "" || ComboUtilisateurID.Text == "")
            {
                MessageBox.Show("Vous devez remplir tous les champs !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Print(); 
        }
    }
}
