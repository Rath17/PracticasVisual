using System;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = new Estudiante
            {
                Carnet = txtCarnet.Text,
                Nombre = txtNombre.Text
            };

            foreach (DataGridViewRow fila in dgvAsignaturas.Rows)
            {
                if (fila.Cells[0].Value != null && fila.Cells[1].Value != null)
                {
                    estudiante.Asignaturas.Add(new Asignatura
                    {
                        Nombre = fila.Cells[0].Value.ToString(),
                        Nota = Convert.ToDouble(fila.Cells[1].Value)
                    });
                }
            }

            DatosCompartidos.ListaEstudiantes.Add(estudiante);
            MessageBox.Show("Estudiante agregado correctamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
