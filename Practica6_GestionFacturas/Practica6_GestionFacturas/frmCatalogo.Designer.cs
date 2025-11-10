namespace Practica6_GestionFacturas
{
    partial class frmCatalogo
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvCatalogo = new System.Windows.Forms.DataGridView();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCatalogo
            // 
            this.dgvCatalogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCatalogo.ColumnHeadersHeight = 29;
            this.dgvCatalogo.Location = new System.Drawing.Point(23, 87);
            this.dgvCatalogo.Name = "dgvCatalogo";
            this.dgvCatalogo.RowHeadersWidth = 51;
            this.dgvCatalogo.Size = new System.Drawing.Size(771, 374);
            this.dgvCatalogo.TabIndex = 0;
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambios.Location = new System.Drawing.Point(301, 497);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(261, 46);
            this.btnGuardarCambios.TabIndex = 1;
            this.btnGuardarCambios.Text = "GUARDAR CAMBIOS";
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Realice las operaciones de inserción, actualización y eliminación";
            // 
            // frmCatalogo
            // 
            this.ClientSize = new System.Drawing.Size(979, 619);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCatalogo);
            this.Controls.Add(this.btnGuardarCambios);
            this.Name = "frmCatalogo";
            this.Text = "Catálogo";
            this.Load += new System.EventHandler(this.frmCatalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgvCatalogo;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Label label1;
    }
}
