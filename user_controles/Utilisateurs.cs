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

namespace proj_pharmacell.user_controles
{
    public partial class Utilisateurs : UserControl
    {
        public Utilisateurs()
        {
            InitializeComponent();
        }
        ADO d = new ADO();
        //declaration de la methode nombre 
        public int nombre()
        {
            int cpt;
            d.cmd.CommandText = "select count (UtilisateurID_Utilisateurs) from Utilisateurs_ where UtilisateurID_Utilisateurs='" +txt_utilisateur.Text + "'";
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
                d.cmd.CommandText = "SET IDENTITY_INSERT Utilisateurs_ ON; " +
                                    "INSERT INTO Utilisateurs_ (UtilisateurID_Utilisateurs, Nom_utilisateur_Utilisateurs, Mot_de_passe_Utilisateurs, Role_Utilisateurs) " +
                                    "VALUES (@UtilisateurID, @Nom_utilisateur, @Mot_de_passe_Utilisateurs, @Role_Utilisateurs); " +
                                    "SET IDENTITY_INSERT Utilisateurs_ OFF;";
                d.cmd.Parameters.Clear();

                // Affectation des valeurs aux paramètres de la commande
                d.cmd.Parameters.AddWithValue("@UtilisateurID", txt_utilisateur.Text);
                d.cmd.Parameters.AddWithValue("@Nom_utilisateur", txt_nom.Text);
                d.cmd.Parameters.AddWithValue("@Mot_de_passe_Utilisateurs", txt_mot_passe.Text);
                d.cmd.Parameters.AddWithValue("@Role_Utilisateurs", comb_role.Text);

                d.cmd.Connection = d.con;
                d.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }

        // declration de la methode Supprimer

        //public bool Supprimer()
        // {
        //     if (nombre() != 0)
        //     {
        //         d.cmd.CommandText = "delete from Utilisateurs_ where UtilisateurID_Utilisateurs='"+txt_utilisateur.Text+ "'";
        //         d.cmd.Connection = d.con;
        //         d.cmd.ExecuteNonQuery();
        //         return true;
        //     }
        //     return false;
        // }
        public bool Supprimer()
        {
            // Commencer une transaction
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-S4U2S3D\\SQLEXPRESS;Initial Catalog=Pharmacell;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Vérifier s'il y a des enregistrements dans la table Ventes_ pour cet utilisateur
                    SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM Ventes_ WHERE UtilisateurID_Utilisateurs = @UtilisateurID", connection, transaction);
                    checkCommand.Parameters.AddWithValue("@UtilisateurID", txt_utilisateur.Text);
                    int venteCount = (int)checkCommand.ExecuteScalar();

                    if (venteCount > 0)
                    {
                        // Si des enregistrements existent, vous devez décider de la meilleure façon de les gérer
                        // Soit les supprimer, soit mettre à jour les valeurs de leurs clés étrangères
                        // Dans cet exemple, nous allons les supprimer

                        SqlCommand deleteCommand = new SqlCommand("DELETE FROM Ventes_ WHERE UtilisateurID_Utilisateurs = @UtilisateurID", connection, transaction);
                        deleteCommand.Parameters.AddWithValue("@UtilisateurID", txt_utilisateur.Text);
                        deleteCommand.ExecuteNonQuery();
                    }

                    // Supprimer l'utilisateur
                    SqlCommand deleteUtilisateurCommand = new SqlCommand("DELETE FROM Utilisateurs_ WHERE UtilisateurID_Utilisateurs = @UtilisateurID", connection, transaction);
                    deleteUtilisateurCommand.Parameters.AddWithValue("@UtilisateurID", txt_utilisateur.Text);
                    deleteUtilisateurCommand.ExecuteNonQuery();

                    // Valider la transaction
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    // En cas d'erreur, annuler la transaction
                    transaction.Rollback();
                    Console.WriteLine("Une erreur s'est produite : " + ex.Message);
                    return false;
                }
            }
        }

        //declaration de la methode Modifier

        public bool Modifier()
        {
            if (nombre() != 0)
            {
                d.cmd.CommandText = "Update Utilisateurs_ set Nom_utilisateur_Utilisateurs='" + txt_nom.Text + "',Mot_de_passe_Utilisateurs='" + txt_mot_passe.Text + "',Role_Utilisateurs='" + comb_role.Text + "' where UtilisateurID_Utilisateurs='"+txt_utilisateur.Text+"'";
                d.cmd.Connection = d.con;
                d.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }

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
        private void Utilisateurs_Load(object sender, EventArgs e)
        {
            d.connecter();
            d.cmd.CommandText = "select * from Utilisateurs_ ";
            d.cmd.Connection = d.con;
            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            dgv_user.DataSource = d.dt;
            d.dr.Close();
        }

        //methode de remplisssage
        public void RemplirGrid()
        {
            if (d.dt.Rows != null)
            {
                d.dt.Clear();
            }
            
            d.cmd.CommandText = "select * from Utilisateurs_ ";
            d.cmd.Connection = d.con;
            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            dgv_user.DataSource = d.dt;
            d.dr.Close();
        }



        private void dgv_user_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_utilisateur.Text = ToString();
           

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_user.Rows[e.RowIndex];

                // Remplir les TextBox avec les valeurs de chaque colonne
                txt_utilisateur.Text = row.Cells["UtilisateurID_Utilisateurs"].Value.ToString();
                txt_nom.Text = row.Cells["Nom_utilisateur_Utilisateurs"].Value.ToString();
                txt_mot_passe.Text = row.Cells["Mot_de_passe_Utilisateurs"].Value.ToString();
                comb_role.Text = row.Cells["Role_Utilisateurs"].Value.ToString();

            }
        }

        private void bt_Ajouter_Click(object sender, EventArgs e)
        {
            if (txt_utilisateur.Text == "" || txt_nom.Text == "" || txt_mot_passe.Text == "" || comb_role.Text == "")
            {
                MessageBox.Show("vous devez remplir tous les champs !", "Message");
                return;
            }
            if (Ajouter() == true)
            {
                MessageBox.Show("Opération Réussit ", "Message");
                RemplirGrid();
            }
            else
            {
                MessageBox.Show("ce utilisateur  existe Déja !", "Message");
            }
        }

        private void bt_Supprimer_Click(object sender, EventArgs e)
        {
            if (txt_utilisateur.Text == "")
            {
                MessageBox.Show("vous devez remplir le champ de l'utilisateur ID !", "Message");
                return;
            }
            if (Supprimer() == true)
            {
                MessageBox.Show("Opération Réussit ", "Message");
                RemplirGrid();

            }
            else
            {
                MessageBox.Show("ce utilisateur  n'existe pas !", "Message");
            }
        }

        

        private void bt_Vider_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez vous vider les champs ? ", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                VIDER(this);
        }

        private void bt_Modifier_Click(object sender, EventArgs e)
        {
            if (txt_utilisateur.Text == "" || txt_nom.Text == "" || txt_mot_passe.Text == "" || comb_role.Text == "")
            {
                MessageBox.Show("vous devez remplir tous les champs !", "Message");
                return;
            }
            if (Modifier() == true)
            {
                MessageBox.Show("Opération Réussit ", "Message");
                RemplirGrid();
            }
            else
            {
                MessageBox.Show("ce utilisateur  n'existe pas !", "Message");
            }
        }
    }
       
}
