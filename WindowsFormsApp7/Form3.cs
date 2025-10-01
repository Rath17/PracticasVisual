using System;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dgvEstudiantes.Rows.Clear();

            foreach (var est in DatosCompartidos.ListaEstudiantes)
            {
                dgvEstudiantes.Rows.Add(est.Carnet, est.Nombre, est.Promedio);
            }
        }

        private void dgvEstudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < DatosCompartidos.ListaEstudiantes.Count)
            {
                var estudiante = DatosCompartidos.ListaEstudiantes[e.RowIndex];
                dgvAsignaturas.Rows.Clear();

                foreach (var asig in estudiante.Asignaturas)
                {
                    dgvAsignaturas.Rows.Add(asig.Nombre, asig.Nota);
                }
            }
        }
    }
}
