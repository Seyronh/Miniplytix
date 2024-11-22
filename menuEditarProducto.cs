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
    public partial class menuEditarProducto : Form
    {
        private string nuevonombre = "";
        private int newSKU;
        private int newGTIN;

        public menuEditarProducto(string name, int SKU, int GTIN)
        {
            InitializeComponent();
            NameTextBox.Text = name;
            SKUTextBox.Text = SKU.ToString();
            GTINTextBox.Text = GTIN.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nuevonombre = NameTextBox.Text;
            newSKU = Convert.ToInt32(SKUTextBox.Text);
            newGTIN = Convert.ToInt32(GTINTextBox.Text);
            Close();
        }

        public String getName()
        {
            return nuevonombre;
        }

        public int getSKU()
        {
            return newSKU;
        }

        public int getGTIN()
        {
            return newGTIN;
        }
    }
}