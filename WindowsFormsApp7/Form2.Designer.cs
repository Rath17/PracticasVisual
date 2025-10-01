namespace WindowsFormsApp7
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblCarnet;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView dgvAsignaturas;
        private System.Windows.Forms.Button btnGuardar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblCarnet = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dgvAsignaturas = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignaturas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCarnet
            // 
            this.lblCarnet.AutoSize = true;
            this.lblCarnet.Location = new System.Drawing.Point(20, 20);
            this.lblCarnet.Text = "Carnet:";
            // 
            // txtCarnet
            // 
            this.txtCarnet.Location = new System.Drawing.Point(80, 17);
            this.txtCarnet.Size = new System.Drawing.Size(200, 20);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 50);
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(80, 47);
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            // 
            // dgvAsignaturas
            // 
            this.dgvAsignaturas.AllowUserToAddRows = true;
            this.dgvAsignaturas.AllowUserToDeleteRows = true;
            this.dgvAsignaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsignaturas.Location = new System.Drawing.Point(20, 80);
            this.dgvAsignaturas.Size = new System.Drawing.Size(400, 200);
            this.dgvAsignaturas.Columns.Add("Asignatura", "Asignatura");
            this.dgvAsignaturas.Columns.Add("Nota", "Nota Final");
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(20, 300);
            this.btnGuardar.Size = new System.Drawing.Size(100, 30);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.lblCarnet);
            this.Controls.Add(this.txtCarnet);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dgvAsignaturas);
            this.Controls.Add(this.btnGuardar);
            this.Text = "Ingresar Estudiante";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignaturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
