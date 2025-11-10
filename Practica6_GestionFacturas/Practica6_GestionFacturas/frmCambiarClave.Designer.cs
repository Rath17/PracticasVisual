namespace Practica6_GestionFacturas
{
    partial class frmCambiarClave
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtActual = new System.Windows.Forms.TextBox();
            this.txtNueva = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // txtUsuario
            //
            this.txtUsuario.Location = new System.Drawing.Point(16, 16);
            this.txtUsuario.Name = "txtUsuario";
            //
            // txtActual
            //
            this.txtActual.Location = new System.Drawing.Point(16, 56);
            this.txtActual.Name = "txtActual";
            this.txtActual.PasswordChar = '*';
            //
            // txtNueva
            //
            this.txtNueva.Location = new System.Drawing.Point(16, 96);
            this.txtNueva.Name = "txtNueva";
            this.txtNueva.PasswordChar = '*';
            //
            // btnGuardar
            //
            this.btnGuardar.Location = new System.Drawing.Point(16, 136);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            //
            // frmCambiarClave
            //
            this.ClientSize = new System.Drawing.Size(360, 200);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtActual);
            this.Controls.Add(this.txtNueva);
            this.Controls.Add(this.btnGuardar);
            this.Name = "frmCambiarClave";
            this.Text = "Cambiar Contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtActual;
        private System.Windows.Forms.TextBox txtNueva;
        private System.Windows.Forms.Button btnGuardar;
    }
}
