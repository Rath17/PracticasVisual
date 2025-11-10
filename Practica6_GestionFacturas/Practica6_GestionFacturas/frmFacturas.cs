using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace Practica6_GestionFacturas
{
    public partial class frmFacturas : Form
    {
        SqlConnection con;
        public frmFacturas()
        {
            InitializeComponent();
        }

        private void frmFacturas_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlVentas"].ConnectionString);
                var dt = new DataTable();
                using (var da = new SqlDataAdapter("SELECT Codigo FROM Factura", con))
                {
                    da.Fill(dt);
                }
                cmbFacturas.DisplayMember = "Codigo";
                cmbFacturas.ValueMember = "Codigo";
                cmbFacturas.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar facturas: " + ex.Message);
            }
        }

        private void cmbFacturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFacturas.SelectedValue == null) return;
            int codigo = Convert.ToInt32(cmbFacturas.SelectedValue);
            var dt = new DataTable();
            using (var da = new SqlDataAdapter($"SELECT Nombre, Precio, Cantidad FROM Producto WHERE Fk_Codigo = {codigo}", con))
            {
                da.Fill(dt);
            }
            dgvDetalle.DataSource = dt;
            decimal total = 0;
            foreach (DataRow r in dt.Rows) total += Convert.ToDecimal(r[1]) * Convert.ToDecimal(r[2]);
            lblTotal.Text = "Total: " + total.ToString("0.00");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var cmdInsFact = new SqlCommand("INSERT INTO Factura (Codigo, Cliente, Fecha) VALUES (@c, @cl, @f)", con);
                cmdInsFact.Parameters.AddWithValue("@c", int.Parse(txtCodigo.Text));
                cmdInsFact.Parameters.AddWithValue("@cl", txtCliente.Text);
                cmdInsFact.Parameters.AddWithValue("@f", dtpFecha.Value);
                con.Open();
                cmdInsFact.ExecuteNonQuery();

                foreach (DataGridViewRow row in dgvNueva.Rows)
                {
                    if (row.IsNewRow) continue;
                    var cmdInsProd = new SqlCommand("INSERT INTO Producto (Nombre, Precio, Cantidad, Fk_Codigo) VALUES (@n,@p,@q,@fk)", con);
                    cmdInsProd.Parameters.AddWithValue("@n", row.Cells["Nombre"].Value);
                    cmdInsProd.Parameters.AddWithValue("@p", row.Cells["Precio"].Value);
                    cmdInsProd.Parameters.AddWithValue("@q", row.Cells["Cantidad"].Value);
                    cmdInsProd.Parameters.AddWithValue("@fk", int.Parse(txtCodigo.Text));
                    cmdInsProd.ExecuteNonQuery();
                }
                MessageBox.Show("Factura registrada");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar factura: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
        }
    }
}
