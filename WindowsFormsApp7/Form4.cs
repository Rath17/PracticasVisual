using DevExpress.XtraEditors.TextEditController.Utils;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WindowsFormsApp7;

namespace MDIEstudiantes
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Limpiar el gráfico
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();

            // Crear área del gráfico
            ChartArea area = new ChartArea("Area1");
            chart1.ChartAreas.Add(area);

            // Configurar ejes
            chart1.ChartAreas[0].AxisX.Title = "Estudiantes";
            chart1.ChartAreas[0].AxisY.Title = "Promedio";

            // Crear serie de columnas
            Series serie = new Series("Promedios")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true
            };

            // Llenar con datos
            foreach (var est in DatosCompartidos.ListaEstudiantes)
            {
                if (est.Asignaturas.Count > 0)
                {
                    double promedio = est.Asignaturas.Average(a => a.Nota);
                    serie.Points.AddXY(est.Nombre, promedio);
                }
            }

            chart1.Series.Add(serie);

            // Mensaje si no hay datos
            if (serie.Points.Count == 0)
            {
                MessageBox.Show("No hay estudiantes con notas para mostrar en el gráfico.");
            }
        }
    }
}

