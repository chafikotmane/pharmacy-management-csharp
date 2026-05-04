using proj_pharmacell.user_controles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj_pharmacell
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            
            UC_Médicament uc_médicament = new UC_Médicament();
            addUserControl(uc_médicament);
            bt_vente.Checked = false;
            btn_médicaments.Checked = true;
            btn_médicaments.CheckedState.CustomBorderColor.R.ToString();
               
        } 
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel_container.Controls.Clear();
            panel_container.Controls.Add(userControl);
            userControl.BringToFront();
        }
   

        private void Menu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void bt_pic_quitter_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

       
        
        private void bt_vente_Click(object sender, EventArgs e)
        {
            //UC_Vente uC_Vente = new UC_Vente();
            //addUserControl(uC_Vente);
            uc_vente uC_Vente = new uc_vente();
            addUserControl(uC_Vente);

        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            Utilisateurs uc_users = new Utilisateurs();
            addUserControl(uc_users);
        }

        private void btn_médicaments_Click(object sender, EventArgs e)
        {
            UC_Médicament uc_médicament = new UC_Médicament();
            addUserControl(uc_médicament);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            UC_Client uc_client = new UC_Client();
            addUserControl(uc_client);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            UC_Commande uc_commande = new UC_Commande();
            addUserControl(uc_commande);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            UC_Fournisseur uC_Fournisseur = new UC_Fournisseur();
            addUserControl (uC_Fournisseur);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            UC_Ordonnance uC_Ordonnance = new UC_Ordonnance();
            addUserControl((uC_Ordonnance));
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            UC_Stock uC_Stock = new UC_Stock();
            addUserControl((uC_Stock));
        }
    }
}
