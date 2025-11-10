using System;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Practica6_GestionFacturas
{
    public partial class frmCambiarClave : Form
    {
        public frmCambiarClave()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string cadena = ConfigurationManager.ConnectionStrings["MySqlLogin"].ConnectionString;
            try
            {
                using (var con = new MySqlConnection(cadena))
                {
                    con.Open();
                    var cmd = new MySqlCommand("UPDATE tb_login SET clave=@n WHERE usuario=@u AND clave=@a", con);
                    cmd.Parameters.AddWithValue("@n", txtNueva.Text);
                    cmd.Parameters.AddWithValue("@u", txtUsuario.Text);
                    cmd.Parameters.AddWithValue("@a", txtActual.Text);
                    int r = cmd.ExecuteNonQuery();
                    if (r > 0) MessageBox.Show("Contraseña cambiada");
                    else MessageBox.Show("Usuario o contraseña actual incorrecta");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
