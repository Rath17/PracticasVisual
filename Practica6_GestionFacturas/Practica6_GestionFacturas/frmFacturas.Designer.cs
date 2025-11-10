namespace Practica6_GestionFacturas
{
    partial class frmFacturas
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabVisualizar = new System.Windows.Forms.TabPage();
            this.cmbFacturas = new System.Windows.Forms.ComboBox();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tabNueva = new System.Windows.Forms.TabPage();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dgvNueva = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabVisualizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.tabNueva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNueva)).BeginInit();
            this.SuspendLayout();
            //
            // tabControl1
            //
            this.tabControl1.Controls.Add(this.tabVisualizar);
            this.tabControl1.Controls.Add(this.tabNueva);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            //
            // tabVisualizar
            //
            this.tabVisualizar.Controls.Add(this.cmbFacturas);
            this.tabVisualizar.Controls.Add(this.dgvDetalle);
            this.tabVisualizar.Controls.Add(this.lblTotal);
            this.tabVisualizar.Text = "Visualizar";
            //
            // cmbFacturas
            //
            this.cmbFacturas.Location = new System.Drawing.Point(16, 16);
            this.cmbFacturas.Name = "cmbFacturas";
            this.cmbFacturas.SelectedIndexChanged += new System.EventHandler(this.cmbFacturas_SelectedIndexChanged);
            //
            // dgvDetalle
            //
            this.dgvDetalle.Location = new System.Drawing.Point(16, 56);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.Size = new System.Drawing.Size(740, 300);
            //
            // lblTotal
            //
            this.lblTotal.Location = new System.Drawing.Point(16, 370);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Text = "Total: 0.00";
            //
            // tabNueva
            //
            this.tabNueva.Controls.Add(this.txtCodigo);
            this.tabNueva.Controls.Add(this.txtCliente);
            this.tabNueva.Controls.Add(this.dtpFecha);
            this.tabNueva.Controls.Add(this.dgvNueva);
            this.tabNueva.Controls.Add(this.btnGuardar);
            this.tabNueva.Text = "Nueva";
            //
            // txtCodigo
            //
            this.txtCodigo.Location = new System.Drawing.Point(16, 16);
            this.txtCodigo.Name = "txtCodigo";
            //
            // txtCliente
            //
            this.txtCliente.Location = new System.Drawing.Point(160, 16);
            this.txtCliente.Name = "txtCliente";
            //
            // dtpFecha
            //
            this.dtpFecha.Location = new System.Drawing.Point(360, 16);
            this.dtpFecha.Name = "dtpFecha";
            //
            // dgvNueva
            //
            this.dgvNueva.Location = new System.Drawing.Point(16, 56);
            this.dgvNueva.Name = "dgvNueva";
            this.dgvNueva.Size = new System.Drawing.Size(740, 300);
            //
            // btnGuardar
            //
            this.btnGuardar.Location = new System.Drawing.Point(16, 370);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            //
            // frmFacturas
            //
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmFacturas";
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.frmFacturas_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabVisualizar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.tabNueva.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNueva)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabVisualizar;
        private System.Windows.Forms.TabPage tabNueva;
        private System.Windows.Forms.ComboBox cmbFacturas;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DataGridView dgvNueva;
        private System.Windows.Forms.Button btnGuardar;
    }
}
