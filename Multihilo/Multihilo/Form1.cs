using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;
using System.Linq;
using System.IO;

// NOTA: Se ha eliminado el 'using Word = Microsoft.Office.Interop.Word;'
// ya que no se necesita para guardar un PNG.

namespace Multihilo
{
    public partial class Form1 : Form
    {
        // ------------------ Datos y Tiempos ------------------
        private List<int> listaOriginal;
        private List<int> listaBurbuja;
        private List<int> listaQuick;
        private List<int> listaMerge;
        private List<int> listaSelection;

        private Dictionary<string, long> tiemposEjecucion = new Dictionary<string, long>();

        private Stopwatch relojBurbuja = new Stopwatch();
        private Stopwatch relojQuick = new Stopwatch();
        private Stopwatch relojMerge = new Stopwatch();
        private Stopwatch relojSelection = new Stopwatch();

        // ------------------ Hilos y Control ------------------
        private Thread hiloBurbuja;
        private Thread hiloSelection;

        // Bandera maestra de suspensión para todos los hilos (Threads y BGWs)
        private volatile bool isSuspended = false;

        public Form1()
        {
            InitializeComponent();

            backgroundWorkerQuickSort.WorkerReportsProgress = true;
            backgroundWorkerMergeSort.WorkerReportsProgress = true;

            this.backgroundWorkerQuickSort.DoWork += backgroundWorkerQuickSort_DoWork;
            this.backgroundWorkerQuickSort.ProgressChanged += backgroundWorker_ProgressChanged;
            this.backgroundWorkerQuickSort.RunWorkerCompleted += backgroundWorker_RunWorkerCompleted;

            this.backgroundWorkerMergeSort.DoWork += backgroundWorkerMergeSort_DoWork;
            this.backgroundWorkerMergeSort.ProgressChanged += backgroundWorker_ProgressChanged;
            this.backgroundWorkerMergeSort.RunWorkerCompleted += backgroundWorker_RunWorkerCompleted;

            ConfigurarChart();

            // Asignar el limite de numeros en la lista
            this.nudTamanoLista.Maximum = new decimal(new int[] {
                1000,
                0,
                0,
                0 });
            this.nudTamanoLista.Name = "nudTamanoLista";

        }
        private void ConfigurarChart()
        {
            chartTiempos.Series.Clear();
            var serie = new Series("Tiempos (ms)")
            {
                IsValueShownAsLabel = true,
                ChartType = SeriesChartType.Column
            };
            chartTiempos.Series.Add(serie);
            chartTiempos.Titles.Clear();
            chartTiempos.Titles.Add("Tiempos de Ejecución de Algoritmos");
        }

        // ----------------------------------------------------------------------
        // Generar Datos y Configuración de Tamaño
        // ----------------------------------------------------------------------
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int tamano = (int)nudTamanoLista.Value;
            if (tamano <= 0)
            {
                MessageBox.Show("El tamaño de la lista debe ser mayor a 0.");
                return;
            }

            Random rnd = new Random();
            listaOriginal = new List<int>();
            for (int i = 0; i < tamano; i++)
                listaOriginal.Add(rnd.Next(0, 1000000));

            progressBurbuja.Value = 0;
            progressQuickSort.Value = 0;
            progressMergeSort.Value = 0;
            progressSelectionSort.Value = 0;
            lblBurbuja.Text = "Burbuja: 0%";
            lblQuickSort.Text = "QuickSort: 0%";
            lblMergeSort.Text = "MergeSort: 0%";
            lblSelectionSort.Text = "SelectionSort: 0%";
            tiemposEjecucion.Clear();
            ConfigurarChart();

            MessageBox.Show($"Lista generada con {tamano:N0} números.");
        }

        // ----------------------------------------------------------------------
        // Iniciar los Hilos (4 Algoritmos)
        // ----------------------------------------------------------------------
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (listaOriginal == null || listaOriginal.Count == 0)
            {
                MessageBox.Show("Primero genera los datos.");
                return;
            }

            if (hiloBurbuja != null && hiloBurbuja.IsAlive || hiloSelection != null && hiloSelection.IsAlive ||
                backgroundWorkerQuickSort.IsBusy || backgroundWorkerMergeSort.IsBusy)
            {
                MessageBox.Show("Un proceso ya está activo. Por favor, espera a que terminen.");
                return;
            }

            listaBurbuja = new List<int>(listaOriginal);
            listaQuick = new List<int>(listaOriginal);
            listaMerge = new List<int>(listaOriginal);
            listaSelection = new List<int>(listaOriginal);

            isSuspended = false; 
            btnSuspender.Enabled = true; 
            btnReanudar.Enabled = false;

            hiloBurbuja = new Thread(OrdenarBurbuja);
            hiloBurbuja.Start();

            backgroundWorkerQuickSort.RunWorkerAsync(new object[] { listaQuick, "QuickSort" });

            backgroundWorkerMergeSort.RunWorkerAsync(new object[] { listaMerge, "MergeSort" });

            hiloSelection = new Thread(OrdenarSelection);
            hiloSelection.Start();
        }

        // ----------------------------------------------------------------------
        // Control de Hilos (Suspensión / Reanudación)
        // ----------------------------------------------------------------------
        private void btnSuspender_Click(object sender, EventArgs e)
        {
            isSuspended = true;
            btnSuspender.Enabled = false;
            btnReanudar.Enabled = true;
            MessageBox.Show("Hilos de ordenamiento en pausa. Presiona Reanudar para continuar.");
        }
        private void btnReanudar_Click(object sender, EventArgs e)
        {
            isSuspended = false;
            btnSuspender.Enabled = true;
            btnReanudar.Enabled = false;
        }

        // ----------------------------------------------------------------------
        // Algoritmos (Threads Clásicos: Burbuja y SelectionSort)
        // ----------------------------------------------------------------------
        private void OrdenarBurbuja()
        {
            relojBurbuja.Restart();
            int n = listaBurbuja.Count;
            for (int i = 0; i < n - 1; i++)
            {
                while (isSuspended) { Thread.Sleep(100); }

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (listaBurbuja[j] > listaBurbuja[j + 1])
                    {
                        int temp = listaBurbuja[j];
                        listaBurbuja[j] = listaBurbuja[j + 1];
                        listaBurbuja[j + 1] = temp;
                    }
                }

                int progreso = (int)(((float)i / n) * 100);
                this.Invoke(new Action(() =>
                {
                    progressBurbuja.Value = Math.Min(progreso, 100);
                    lblBurbuja.Text = $"Burbuja: {progreso}%";
                }));
            }

            relojBurbuja.Stop();
            ReportarFinThread(relojBurbuja, "BubbleSort", progressBurbuja, lblBurbuja);
        }

        private void OrdenarSelection()
        {
            relojSelection.Restart();
            int n = listaSelection.Count;
            for (int i = 0; i < n - 1; i++)
            {
                while (isSuspended) { Thread.Sleep(100); }

                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (listaSelection[j] < listaSelection[min_idx])
                    {
                        min_idx = j;
                    }
                }

                int temp = listaSelection[min_idx];
                listaSelection[min_idx] = listaSelection[i];
                listaSelection[i] = temp;

                int progreso = (int)(((float)i / n) * 100);
                this.Invoke(new Action(() =>
                {
                    progressSelectionSort.Value = Math.Min(progreso, 100);
                    lblSelectionSort.Text = $"SelectionSort: {progreso}%";
                }));
            }

            relojSelection.Stop();
            ReportarFinThread(relojSelection, "SelectionSort", progressSelectionSort, lblSelectionSort);
        }

        private void ReportarFinThread(Stopwatch reloj, string nombre, ProgressBar progress, Label label)
        {
            this.Invoke(new Action(() =>
            {
                progress.Value = 100;
                long tiempo = reloj.ElapsedMilliseconds;
                tiemposEjecucion[nombre] = tiempo;
                label.Text = $"{nombre}: Completado en {tiempo:N0} ms";
                ActualizarChart();
            }));
        }

        // ----------------------------------------------------------------------
        // Algoritmos (BackgroundWorkers: QuickSort y MergeSort)
        // ----------------------------------------------------------------------

        #region QuickSort BGW
        private void backgroundWorkerQuickSort_DoWork(object sender, DoWorkEventArgs e)
        {
            relojQuick.Restart();
            object[] args = (object[])e.Argument;
            List<int> lista = (List<int>)args[0];
            string nombre = (string)args[1];

            backgroundWorkerQuickSort.ReportProgress(0, nombre);
            QuickSort(lista, 0, lista.Count - 1);
        }

        private void QuickSort(List<int> lista, int izquierda, int derecha)
        {
            while (isSuspended) { Thread.Sleep(100); }

            if (izquierda < derecha)
            {
                int pivot = Particionar(lista, izquierda, derecha);
                QuickSort(lista, izquierda, pivot - 1);
                QuickSort(lista, pivot + 1, derecha);
            }
        }
        private int Particionar(List<int> lista, int izquierda, int derecha)
        {
            int pivote = lista[derecha];
            int i = izquierda - 1;
            for (int j = izquierda; j < derecha; j++)
            {
                if (lista[j] <= pivote)
                {
                    i++;
                    int temp = lista[i];
                    lista[i] = lista[j];
                    lista[j] = temp;
                }
            }
            int temp2 = lista[i + 1];
            lista[i + 1] = lista[derecha];
            lista[derecha] = temp2;
            return i + 1;
        }
        #endregion

        #region MergeSort BGW
        private void backgroundWorkerMergeSort_DoWork(object sender, DoWorkEventArgs e)
        {
            relojMerge.Restart();
            object[] args = (object[])e.Argument;
            List<int> lista = (List<int>)args[0];
            string nombre = (string)args[1];

            backgroundWorkerMergeSort.ReportProgress(0, nombre);
            List<int> resultado = MergeSort(lista);
            e.Result = resultado;
        }

        private List<int> MergeSort(List<int> lista)
        {
            if (lista.Count <= 1) return lista;

            while (isSuspended) { Thread.Sleep(100); }

            int mid = lista.Count / 2;
            List<int> left = lista.GetRange(0, mid);
            List<int> right = lista.GetRange(mid, lista.Count - mid);

            left = MergeSort(left);
            right = MergeSort(right);

            return Merge(left, right);
        }

        private List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();
            int i = 0, j = 0;

            while (isSuspended) { Thread.Sleep(100); }

            while (i < left.Count && j < right.Count)
            {
                if (left[i] < right[j])
                {
                    result.Add(left[i]);
                    i++;
                }
                else
                {
                    result.Add(right[j]);
                    j++;
                }
            }

            result.AddRange(left.GetRange(i, left.Count - i));
            result.AddRange(right.GetRange(j, right.Count - j));

            return result;
        }
        #endregion

        // -------------------- Manejo de Eventos BGW Genérico --------------------

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            string nombre = (string)e.UserState;

            if (nombre == "QuickSort")
            {
                progressQuickSort.Value = e.ProgressPercentage;
                lblQuickSort.Text = $"QuickSort: {e.ProgressPercentage}%";
            }
            else if (nombre == "MergeSort")
            {
                progressMergeSort.Value = e.ProgressPercentage;
                lblMergeSort.Text = $"MergeSort: {e.ProgressPercentage}%";
            }
        }
        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BackgroundWorker worker = (BackgroundWorker)sender;

            string nombre = (worker == backgroundWorkerQuickSort) ? "QuickSort" : "MergeSort";

            Stopwatch reloj = (nombre == "QuickSort") ? relojQuick : relojMerge;
            ProgressBar progress = (nombre == "QuickSort") ? progressQuickSort : progressMergeSort;
            Label label = (nombre == "QuickSort") ? lblQuickSort : lblMergeSort;

            reloj.Stop();
            progress.Value = 100;
            long tiempo = reloj.ElapsedMilliseconds;
            tiemposEjecucion[nombre] = tiempo;
            label.Text = $"{nombre}: Completado en {tiempo:N0} ms";

            ActualizarChart();
        }

        // ----------------------------------------------------------------------
        // Gráfico (Chart)
        // ----------------------------------------------------------------------
        private void ActualizarChart()
        {
            if (chartTiempos.Series.Count == 0) return;

            Series serie = chartTiempos.Series[0];
            serie.Points.Clear();

            foreach (var kvp in tiemposEjecucion.OrderBy(x => x.Value))
            {
                serie.Points.AddXY(kvp.Key, kvp.Value);
            }
        }

        // ----------------------------------------------------------------------
        // Generación de Reporte PNG (Ruta fija y lógica real)
        // ----------------------------------------------------------------------
        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            if (tiemposEjecucion.Count != 4)
            {
                MessageBox.Show("Por favor, ejecuta los 4 algoritmos antes de generar el reporte.");
                return;
            }

            string rutaBase = @"C:\Users\ALEx\Desktop";
            string nombreArchivoPNG = $"Reporte_Ordenamiento_{DateTime.Now:yyyyMMdd_HHmmss}.png";
            string rutaCompletaPNG = Path.Combine(rutaBase, nombreArchivoPNG);

            try
            {
                if (!Directory.Exists(rutaBase))
                {
                    Directory.CreateDirectory(rutaBase);
                }

                chartTiempos.SaveImage(rutaCompletaPNG, ChartImageFormat.Png);

                MessageBox.Show($"Gráfico del reporte generado con éxito y guardado en:\n{rutaCompletaPNG}",
                                "Reporte Generado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el archivo PNG: {ex.Message}\nAsegúrate de que la ruta '{rutaBase}' exista y que tengas permisos de escritura.",
                                "Error de Guardado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}