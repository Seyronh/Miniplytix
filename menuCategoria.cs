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
    public partial class menuCategoria : Form
    {
        private string nuevonombre = "";
        public menuCategoria()
        {
            InitializeComponent();
            this.Text = "Create Category";
        }
        public menuCategoria(string nombre)
        {
            InitializeComponent();
            this.Text = "Edit Category";

            textBox1.Text = nombre;
            nuevonombre = nombre;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("The text cant be empty");
                return;
            }
            nuevonombre = textBox1.Text;
            Close();
        }
        public string getNuevo()
        {
            return nuevonombre;
        }
    }
}
