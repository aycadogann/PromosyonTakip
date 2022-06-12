using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromosyonTakip.Core.Database
{
    public class PromosyonSepeti
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;

        int returnInt;
        object retutnObj;

        public PromosyonSepeti()
        {
            con = new SqlConnection(connectionStringOlustur());
        }

        string connectionStringOlustur()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "LAPTOP-I94IGVVP\\SQLEXPRESS";
            builder.InitialCatalog = "PromosyonSepeti";
            builder.IntegratedSecurity = true;
            return builder.ConnectionString;
        }
        public void BaglantiDurumuAyarla()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            else
                con.Close();
        }
        public int EkleDuzenleSil(SqlCommand cmd)
        {
            cmd.Connection = con;
            BaglantiDurumuAyarla();
            returnInt = cmd.ExecuteNonQuery();
            BaglantiDurumuAyarla();
            return returnInt;
        }
        public SqlDataReader Liste(SqlCommand cmd)
        {
            cmd.Connection = con;
            BaglantiDurumuAyarla();
            return cmd.ExecuteReader();

        }
        public object KolonGetir(SqlCommand cmd)
        {
            cmd.Connection = con;
            BaglantiDurumuAyarla();
            retutnObj = cmd.ExecuteScalar();
            BaglantiDurumuAyarla();
            return retutnObj;
        }

    }
}
