using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Practica6_GestionFacturas
{
    public partial class frmCatalogo : Form
    {
        SqlDataAdapter da;
        DataSet ds;
        SqlConnection con;

        public frmCatalogo()
        {
            InitializeComponent();
        }

        private void frmCatalogo_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlVentas"].ConnectionString);
                da = new SqlDataAdapter("SELECT * FROM Catalogo", con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds, "Catalogo");
                dgvCatalogo.DataSource = ds.Tables["Catalogo"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar catálogo: " + ex.Message);
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                da.Update(ds, "Catalogo");
                MessageBox.Show("Cambios guardados con éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }
    }
}
