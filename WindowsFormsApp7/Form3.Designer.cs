namespace WindowsFormsApp7
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvEstudiantes;
        private System.Windows.Forms.DataGridView dgvAsignaturas;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvEstudiantes = new System.Windows.Forms.DataGridView();
            this.dgvAsignaturas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignaturas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEstudiantes
            // 
            this.dgvEstudiantes.Location = new System.Drawing.Point(20, 20);
            this.dgvEstudiantes.Size = new System.Drawing.Size(500, 200);
            this.dgvEstudiantes.ReadOnly = true;
            this.dgvEstudiantes.AllowUserToAddRows = false;
            this.dgvEstudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstudiantes.Columns.Add("Carnet", "Carnet");
            this.dgvEstudiantes.Columns.Add("Nombre", "Nombre");
            this.dgvEstudiantes.Columns.Add("Promedio", "Promedio");
            this.dgvEstudiantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstudiantes_CellClick);
            // 
            // dgvAsignaturas
            // 
            this.dgvAsignaturas.Location = new System.Drawing.Point(20, 240);
            this.dgvAsignaturas.Size = new System.Drawing.Size(500, 200);
            this.dgvAsignaturas.ReadOnly = true;
            this.dgvAsignaturas.AllowUserToAddRows = false;
            this.dgvAsignaturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAsignaturas.Columns.Add("Asignatura", "Asignatura");
            this.dgvAsignaturas.Columns.Add("Nota", "Nota Final");
            // 
            // Form3
            // 
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.dgvEstudiantes);
            this.Controls.Add(this.dgvAsignaturas);
            this.Text = "Ver Estudiantes";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignaturas)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
