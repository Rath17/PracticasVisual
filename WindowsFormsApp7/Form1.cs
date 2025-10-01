using MDIEstudiantes;
using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void AbrirFormulario<T>() where T : Form, new()
        {
            Form formulario = this.MdiChildren.FirstOrDefault(f => f is T);
            if (formulario == null)
            {
                formulario = new T();
                formulario.MdiParent = this;
                formulario.Show();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Form2>();
        }

        private void btnForm3_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Form3>();
        }

        private void btnForm4_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Form4>();
        }
    }
}
