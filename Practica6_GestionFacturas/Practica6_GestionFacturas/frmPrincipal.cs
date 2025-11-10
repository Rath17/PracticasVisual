using System;
using System.Windows.Forms;

namespace Practica6_GestionFacturas
{
    public partial class frmPrincipal : Form
    {
        frmCatalogo formCatalogo;
        frmFacturas formFacturas;
        frmCambiarClave formClave;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            using (var login = new frmLogin())
            {
                var res = login.ShowDialog();
                if (res != DialogResult.OK) this.Close();
            }
        }

        private void catalogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formCatalogo == null || formCatalogo.IsDisposed)
            {
                formCatalogo = new frmCatalogo();
                formCatalogo.MdiParent = this;
                formCatalogo.Show();
            }
            else formCatalogo.BringToFront();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formFacturas == null || formFacturas.IsDisposed)
            {
                formFacturas = new frmFacturas();
                formFacturas.MdiParent = this;
                formFacturas.Show();
            }
            else formFacturas.BringToFront();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formClave == null || formClave.IsDisposed)
            {
                formClave = new frmCambiarClave();
                formClave.MdiParent = this;
                formClave.Show();
            }
            else formClave.BringToFront();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void mosaicoHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mosaicoVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var f = new frmAcercaDe()) f.ShowDialog();
        }
    }
}
