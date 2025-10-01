namespace WindowsFormsApp7
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnForm2;
        private System.Windows.Forms.ToolStripButton btnForm3;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnForm2 = new System.Windows.Forms.ToolStripButton();
            this.btnForm3 = new System.Windows.Forms.ToolStripButton();
            this.btnForm4 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnForm2,
            this.btnForm3,
            this.btnForm4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(801, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnForm2
            // 
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(139, 24);
            this.btnForm2.Text = "Ingresar Estudiante";
            this.btnForm2.Click += new System.EventHandler(this.btnForm2_Click);
            // 
            // btnForm3
            // 
            this.btnForm3.Name = "btnForm3";
            this.btnForm3.Size = new System.Drawing.Size(113, 24);
            this.btnForm3.Text = "Ver Estudiantes";
            this.btnForm3.Click += new System.EventHandler(this.btnForm3_Click);
            // 
            // btnForm4
            // 
            this.btnForm4.Name = "btnForm4";
            this.btnForm4.Size = new System.Drawing.Size(86, 24);
            this.btnForm4.Text = "Ver Grafico";
            this.btnForm4.Click += new System.EventHandler(this.btnForm4_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(801, 424);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Gestión de Estudiantes - MDI";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ToolStripButton btnForm4;
    }
}
