using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace proj_pharmacell
{
    internal class ADO
    {
        // déclaration des objects sql
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader dr;
        public DataTable dt = new DataTable();
        // déclaration de la methode connecter
        public void connecter()
        {
            if (con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)
            {
                con.ConnectionString = "Data Source=DESKTOP-S4U2S3D\\SQLEXPRESS;Initial Catalog=Pharmacell;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                con.Open();

            }
        }

        // déclaration de la methode deconnecter

        public void deconnecter()
        {
            if (con.State == ConnectionState.Open )
            {
                con.Close();

            }
        }



    }
}
