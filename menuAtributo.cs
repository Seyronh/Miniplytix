using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPlytix
{
    public partial class menuAtributo : Form
    {
        private string Nombreactual = "";
        private int selected = -1;
        public menuAtributo()
        {
            InitializeComponent();
            this.Text = "Create Attribute";
        }
        public menuAtributo(string nombre, int idTipo)
        {
            InitializeComponent();
            this.Text = "Edit Attribute";

            Nombreactual = nombre;
            selected = idTipo-1;
        }

        private void menuAtributo_Load(object sender, EventArgs e)
        {

            List<object[]> datos = Consulta.conexion.Select("SELECT nombre FROM TipoAtributo");
            for (int i = 0; i < datos.Count; i++)
            {
                comboBox1.Items.Add(datos[i][0]);
            }
            if (selected > -1)
            {
                comboBox1.SelectedIndex = selected;
            }
            textBox1.Text = Nombreactual;
        }
        public int getTipo()
        {
            return selected + 1;
        }
        public string getNombre()
        {
            return Nombreactual;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length == 0){
                MessageBox.Show("The Name cant be empty");
                return;
            }
            if (selected == -1){
                MessageBox.Show("The type is not selected");
                return;
            }
            Nombreactual = textBox1.Text;
            selected = comboBox1.SelectedIndex;
            Close();
        }
    }
}
