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
using System.Web.UI.WebControls;

namespace proj_pharmacell
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void utilisateurs_BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.utilisateurs_BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacellDataSet);



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'pharmacellDataSet.Utilisateurs_'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.utilisateurs_TableAdapter.Fill(this.pharmacellDataSet.Utilisateurs_);
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int radius = 15; // Adjust the value to change the roundness of the corners
                             // Create a rounded rectangle path using the form's size and radius
            path.AddArc(0, 0, radius, radius, 180, 90); // Top-left corner
            path.AddArc(this. Width -radius, 0, radius, radius, 270, 90); // Top-right corner
            path.AddArc(this.Width - radius, this .Height - radius, radius, radius, 0, 90); // Bottom-right corner
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90); // Bottom-left corner
                                                                          // Create a region with the rounded rectangle path and apply it to the form


            // intercepter la touche "Entrée" au clavier:
            this.AcceptButton = button2;
        }



        private void afficher_les_caractéres_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = afficher_les_caractéres.Checked ? '\0' : '*';
        }

       

        private void bt_Quitter_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" ||
        (rdAdministrateur.Checked == false && rdGestionnaire.Checked == false && rdVendeur.Checked == false))
            {
                MessageBox.Show("Vous devez remplir tous les champs et le role de l'utilisateur !", "Info");
            }
            else
            {
                try
                {
                    string role = "";
                    if (rdAdministrateur.Checked)
                        role = "Administrateur";
                    else if (rdGestionnaire.Checked)
                        role = "Gestionnaire";
                    else if (rdVendeur.Checked)
                        role = "Vendeur";

                    SqlConnection conn = new SqlConnection("Data Source=DESKTOP-S4U2S3D\\SQLEXPRESS;Initial Catalog=Pharmacell;Integrated Security=True;TrustServerCertificate=True");
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Utilisateurs_ WHERE Nom_utilisateur_Utilisateurs = @nom_utilisateur AND Mot_de_passe_Utilisateurs = @mot_de_passe_utilisateur AND Role_Utilisateurs = @role", conn);

                    cmd.Parameters.AddWithValue("@nom_utilisateur", textBox1.Text);
                    cmd.Parameters.AddWithValue("@mot_de_passe_utilisateur", textBox2.Text);
                    cmd.Parameters.AddWithValue("@role", role);

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Connexion réussie", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Menu m = new Menu();

                        if (rdVendeur.Checked)
                        {
                            m.btn_users.Enabled = false;
                            m.btn_médicaments.Enabled = false;
                            m.guna2Button4.Enabled = false;
                        }
                        else if (rdGestionnaire.Checked)
                        {
                            m.btn_users.Enabled = false;
                            m.guna2Button6.Enabled = false;
                            m.guna2Button3.Enabled = false;
                        }

                        m.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Nom d'utilisateur, mot de passe ou rôle incorrect", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }

        }   
            }
    }
}
