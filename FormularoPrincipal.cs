using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPlytix
{
    public partial class FormularoPrincipal : Form
    {
        public FormularoPrincipal()
        {
            InitializeComponent();
            this.Text = "MiniPlytix";
        }

        private void MostrarControlDeUsuario(UserControl control)
        {
            // Limpia el panel
            panelContenedor.Controls.Clear();

            // Configura el nuevo control
            control.Dock = DockStyle.Fill;

            // Agrega el control al panel
            panelContenedor.Controls.Add(control);
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarControlDeUsuario(new Productos());
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarControlDeUsuario(new Categories());
        }

        private void attributesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarControlDeUsuario(new Attributes());
        }
    }
}
