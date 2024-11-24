using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MiniPlytix
{
    public partial class menuProducto : Form
    {
        private string newnombre = "";
        private int newSKU;
        private int newGTIN;

        public menuProducto()
        {
            InitializeComponent();
            this.Text = "Create Product";
        }

        public menuProducto(string name, int SKU, int GTIN)
        {
            InitializeComponent();
            this.Text = "Edit Product";

            NameTextBox.Text = name;
            newnombre = name;
            SKUTextBox.Text = SKU.ToString();
            newSKU = SKU;
            GTINTextBox.Text = GTIN.ToString();
            newGTIN = GTIN;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("The name can't be empty");
                return;
            }
            else if (SKUTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("SKU can't be empty");
                return;
            }
            else if (GTINTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("GTIN text can't be empty");
                return;
            }

            newnombre = NameTextBox.Text;
            newSKU = Convert.ToInt32(SKUTextBox.Text);
            newGTIN = Convert.ToInt32(GTINTextBox.Text);
            Close();
        }

        public String getName()
        {
            return newnombre;
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
