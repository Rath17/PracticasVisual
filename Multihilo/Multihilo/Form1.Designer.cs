namespace Multihilo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.progressBurbuja = new System.Windows.Forms.ProgressBar();
            this.lblBurbuja = new System.Windows.Forms.Label();
            this.progressQuickSort = new System.Windows.Forms.ProgressBar();
            this.lblQuickSort = new System.Windows.Forms.Label();
            this.backgroundWorkerQuickSort = new System.ComponentModel.BackgroundWorker();
            this.nudTamanoLista = new System.Windows.Forms.NumericUpDown();
            this.lblTamano = new System.Windows.Forms.Label();
            this.lblMergeSort = new System.Windows.Forms.Label();
            this.lblSelectionSort = new System.Windows.Forms.Label();
            this.progressMergeSort = new System.Windows.Forms.ProgressBar();
            this.progressSelectionSort = new System.Windows.Forms.ProgressBar();
            this.btnSuspender = new System.Windows.Forms.Button();
            this.btnReanudar = new System.Windows.Forms.Button();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.chartTiempos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backgroundWorkerMergeSort = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.nudTamanoLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTiempos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(365, 31);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(133, 61);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "GENERAR";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(552, 31);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(145, 57);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "ORDENAR";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // progressBurbuja
            // 
            this.progressBurbuja.Location = new System.Drawing.Point(102, 375);
            this.progressBurbuja.Name = "progressBurbuja";
            this.progressBurbuja.Size = new System.Drawing.Size(348, 10);
            this.progressBurbuja.TabIndex = 2;
            // 
            // lblBurbuja
            // 
            this.lblBurbuja.AutoSize = true;
            this.lblBurbuja.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBurbuja.Location = new System.Drawing.Point(9, 369);
            this.lblBurbuja.Name = "lblBurbuja";
            this.lblBurbuja.Size = new System.Drawing.Size(78, 16);
            this.lblBurbuja.TabIndex = 3;
            this.lblBurbuja.Text = "Burbuja: 0%";
            // 
            // progressQuickSort
            // 
            this.progressQuickSort.Location = new System.Drawing.Point(103, 397);
            this.progressQuickSort.Name = "progressQuickSort";
            this.progressQuickSort.Size = new System.Drawing.Size(342, 10);
            this.progressQuickSort.TabIndex = 4;
            // 
            // lblQuickSort
            // 
            this.lblQuickSort.AutoSize = true;
            this.lblQuickSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuickSort.Location = new System.Drawing.Point(6, 391);
            this.lblQuickSort.Name = "lblQuickSort";
            this.lblQuickSort.Size = new System.Drawing.Size(88, 16);
            this.lblQuickSort.TabIndex = 5;
            this.lblQuickSort.Text = "Quicksort: 0%";
            // 
            // nudTamanoLista
            // 
            this.nudTamanoLista.Location = new System.Drawing.Point(118, 158);
            this.nudTamanoLista.Name = "nudTamanoLista";
            this.nudTamanoLista.Size = new System.Drawing.Size(155, 22);
            this.nudTamanoLista.TabIndex = 6;
            // 
            // lblTamano
            // 
            this.lblTamano.AutoSize = true;
            this.lblTamano.Location = new System.Drawing.Point(1, 160);
            this.lblTamano.Name = "lblTamano";
            this.lblTamano.Size = new System.Drawing.Size(111, 16);
            this.lblTamano.TabIndex = 7;
            this.lblTamano.Text = "Tamaño de Lista:";
            // 
            // lblMergeSort
            // 
            this.lblMergeSort.AutoSize = true;
            this.lblMergeSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMergeSort.Location = new System.Drawing.Point(9, 413);
            this.lblMergeSort.Name = "lblMergeSort";
            this.lblMergeSort.Size = new System.Drawing.Size(90, 16);
            this.lblMergeSort.TabIndex = 8;
            this.lblMergeSort.Text = "Mergesort 0%";
            // 
            // lblSelectionSort
            // 
            this.lblSelectionSort.AutoSize = true;
            this.lblSelectionSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectionSort.Location = new System.Drawing.Point(-8, 435);
            this.lblSelectionSort.Name = "lblSelectionSort";
            this.lblSelectionSort.Size = new System.Drawing.Size(107, 16);
            this.lblSelectionSort.TabIndex = 9;
            this.lblSelectionSort.Text = "Selectionsort 0%";
            // 
            // progressMergeSort
            // 
            this.progressMergeSort.Location = new System.Drawing.Point(103, 419);
            this.progressMergeSort.Name = "progressMergeSort";
            this.progressMergeSort.Size = new System.Drawing.Size(343, 10);
            this.progressMergeSort.TabIndex = 10;
            // 
            // progressSelectionSort
            // 
            this.progressSelectionSort.Location = new System.Drawing.Point(103, 441);
            this.progressSelectionSort.Name = "progressSelectionSort";
            this.progressSelectionSort.Size = new System.Drawing.Size(347, 10);
            this.progressSelectionSort.TabIndex = 11;
            // 
            // btnSuspender
            // 
            this.btnSuspender.Location = new System.Drawing.Point(39, 226);
            this.btnSuspender.Name = "btnSuspender";
            this.btnSuspender.Size = new System.Drawing.Size(89, 39);
            this.btnSuspender.TabIndex = 12;
            this.btnSuspender.Text = "Suspender";
            this.btnSuspender.UseVisualStyleBackColor = true;
            this.btnSuspender.Click += new System.EventHandler(this.btnSuspender_Click);
            // 
            // btnReanudar
            // 
            this.btnReanudar.Location = new System.Drawing.Point(175, 226);
            this.btnReanudar.Name = "btnReanudar";
            this.btnReanudar.Size = new System.Drawing.Size(89, 50);
            this.btnReanudar.TabIndex = 13;
            this.btnReanudar.Text = "Reanudar";
            this.btnReanudar.UseVisualStyleBackColor = true;
            this.btnReanudar.Click += new System.EventHandler(this.btnReanudar_Click);
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporte.Location = new System.Drawing.Point(51, 528);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(254, 53);
            this.btnGenerarReporte.TabIndex = 14;
            this.btnGenerarReporte.Text = "GENERAR REPORTE";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // chartTiempos
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTiempos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTiempos.Legends.Add(legend1);
            this.chartTiempos.Location = new System.Drawing.Point(619, 438);
            this.chartTiempos.Name = "chartTiempos";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartTiempos.Series.Add(series1);
            this.chartTiempos.Size = new System.Drawing.Size(934, 200);
            this.chartTiempos.TabIndex = 15;
            this.chartTiempos.Text = "chart";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 763);
            this.Controls.Add(this.chartTiempos);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.btnReanudar);
            this.Controls.Add(this.btnSuspender);
            this.Controls.Add(this.progressSelectionSort);
            this.Controls.Add(this.progressMergeSort);
            this.Controls.Add(this.lblSelectionSort);
            this.Controls.Add(this.lblMergeSort);
            this.Controls.Add(this.lblTamano);
            this.Controls.Add(this.nudTamanoLista);
            this.Controls.Add(this.lblQuickSort);
            this.Controls.Add(this.progressQuickSort);
            this.Controls.Add(this.lblBurbuja);
            this.Controls.Add(this.progressBurbuja);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnGenerar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudTamanoLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTiempos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.ProgressBar progressBurbuja;
        private System.Windows.Forms.Label lblBurbuja;
        private System.Windows.Forms.ProgressBar progressQuickSort;
        private System.Windows.Forms.Label lblQuickSort;
        private System.ComponentModel.BackgroundWorker backgroundWorkerQuickSort;
        private System.Windows.Forms.NumericUpDown nudTamanoLista;
        private System.Windows.Forms.Label lblTamano;
        private System.Windows.Forms.Label lblMergeSort;
        private System.Windows.Forms.Label lblSelectionSort;
        private System.Windows.Forms.ProgressBar progressMergeSort;
        private System.Windows.Forms.ProgressBar progressSelectionSort;
        private System.Windows.Forms.Button btnSuspender;
        private System.Windows.Forms.Button btnReanudar;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTiempos;
        private System.ComponentModel.BackgroundWorker backgroundWorkerMergeSort;
    }
}

