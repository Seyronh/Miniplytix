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
    public partial class menuCrearCategoria : Form
    {
        private string nuevonombre = "";
        public menuCrearCategoria()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length == 0) return;
            nuevonombre = textBox1.Text;
            Close();
        }
        public string getNuevo()
        {
            return nuevonombre;
        }
    }
}
