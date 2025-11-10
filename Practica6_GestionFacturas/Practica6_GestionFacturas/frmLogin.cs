using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Practica6_GestionFacturas
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string cadena = ConfigurationManager.ConnectionStrings["MySqlLogin"].ConnectionString;
            DataSet ds = new DataSet();
            try
            {
                using (MySqlConnection con = new MySqlConnection(cadena))
                {
                    string sql = "SELECT usuario, clave FROM tb_login";
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                    da.Fill(ds, "tb_login");
                }

                var consulta = from DataRow fila in ds.Tables["tb_login"].Rows
                               where fila["usuario"].ToString() == txtUsuario.Text
                               && fila["clave"].ToString() == txtClave.Text
                               select fila;

                if (consulta.Any())
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClave.Clear();
                    txtUsuario.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
