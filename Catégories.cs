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

namespace proj_pharmacell
{
    internal class Catégories
    {
        ADO d = new ADO();

        //declaration de la methode nombre
        string colonne;
        string table;
        TextBox tb;
        public int nombre(String colonne, String table, TextBox tb)
        {
            int cpt;
            d.connecter();
            d.cmd.CommandText = $"select count({colonne}) from {table} where {colonne}='" + tb.Text + "'";
            d.cmd.Connection = d.con;
            cpt = (int)d.cmd.ExecuteScalar();
            return cpt;
        }
        // declration de la methode Ajouter
        public bool Ajouter(TextBox tb, TextBox tb2, TextBox tb3)
        {
            if (nombre("CategorieID_Categories", "Categories", tb) == 0)
            {
              

                // Activation de IDENTITY_INSERT pour la table Ventes_
                d.cmd.CommandText = "SET IDENTITY_INSERT Categories ON; " +
                                    "INSERT INTO Categories (CategorieID_Categories, Nom_Categorie_Categories, Description_Categories ) " +
                                    "VALUES (@CategorieID, @Nom, @Description); " +
                                    "SET IDENTITY_INSERT Categories OFF;";
                d.cmd.Parameters.Clear();


                // Affectation des valeurs aux paramètres de la commande
                d.cmd.Parameters.AddWithValue("@CategorieID", tb.Text);
                d.cmd.Parameters.AddWithValue("@Nom", tb2.Text);
                d.cmd.Parameters.AddWithValue("@Description", tb3.Text);


                d.cmd.Connection = d.con;
                d.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }
        //declaration de la methode Modifier
        
        public bool Modifier(TextBox tb1,TextBox tb2,TextBox tb3,string colonne,string table  )
        {
            

            if (nombre( colonne,  table,  tb1) != 0)
            {
                //byte[] imageBytes = File.ReadAllBytes(Photo.Text);
                d.cmd.CommandText = "UPDATE Categories SET Nom_Categorie_Categories=@nom,Description_Categories=@description where CategorieID_Categories = @ID";

                // Clear existing parameters to avoid duplicates
                d.cmd.Parameters.Clear();

                // Add parameters
                d.cmd.Parameters.AddWithValue("@nom", tb2.Text);
                d.cmd.Parameters.AddWithValue("@description", tb3.Text);
                d.cmd.Parameters.AddWithValue("@ID", tb1.Text);
                

                d.cmd.Connection = d.con;
                d.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }


        //declration de la methode Supprimer
        public bool Supprimer(string colonne , string table ,TextBox tb)
        {
            if (nombre(colonne,table,tb) != 0)
            {
                d.cmd.CommandText = "delete from Categories where CategorieID_Categories='" + tb.Text + "' ";
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
    
}
}
