using System;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Practica6_GestionFacturas
{
    public class BD_SetGet
    {
        public static DataTable EjecutarOrdenSelect(string sql)
        {
            string cs = ConfigurationManager.ConnectionStrings["MySqlLogin"].ConnectionString;
            var dt = new DataTable();
            using (var con = new MySqlConnection(cs))
            {
                var da = new MySqlDataAdapter(sql, con);
                da.Fill(dt);
            }
            return dt;
        }

        public static int EjecutarOrden(string sql)
        {
            string cs = ConfigurationManager.ConnectionStrings["MySqlLogin"].ConnectionString;
            using (var con = new MySqlConnection(cs))
            {
                con.Open();
                var cmd = new MySqlCommand(sql, con);
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
