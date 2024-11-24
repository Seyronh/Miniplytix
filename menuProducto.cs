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
        private int idProducto = -1;
        private string newnombre = "";
        private int newSKU;
        private int newGTIN;

        public menuProducto()
        {
            InitializeComponent();
            this.Text = "Create Product";
        }

        public menuProducto(int idProducto, string name, int SKU, int GTIN)
        {
            InitializeComponent();
            this.Text = "Edit Product";

            this.idProducto = idProducto;

            NameTextBox.Text = name;
            newnombre = name;
            SKUTextBox.Text = SKU.ToString();
            newSKU = SKU;
            GTINTextBox.Text = GTIN.ToString();
            newGTIN = GTIN;
        }

        private void menuProducto_Load(object sender, EventArgs e)
        {
            LoadDataGridViewAttributes();
            LoadComboBoxAttributes();
        }

        private void LoadComboBoxAttributes()
        {
            comboBox1.ResetText();
            comboBox1.Items.Clear();

            List<object[]> datos = Consulta.conexion.Select($"SELECT Name FROM Atributo WHERE idAtributo NOT IN (SELECT idAtributo FROM ValorAtributo WHERE idProducto = {idProducto})");
            for (int i = 0; i < datos.Count; i++)
            {
                comboBox1.Items.Add(datos[i][0]);
            }
        }

        private void LoadDataGridViewAttributes()
        {
            String consulta = $"SELECT Atributo.idAtributo, Atributo.Name, TipoAtributo.nombre FROM Atributo JOIN TipoAtributo ON Atributo.idTipoAtributo = TipoAtributo.idTipoAtributo JOIN ValorAtributo ON Atributo.idAtributo = ValorAtributo.idAtributo WHERE ValorAtributo.idProducto = {idProducto}";
            dataGridView1.Rows.Clear();
            List<object[]> listaConsulta = new Consulta().Select(consulta);

            for (int i = 0; i < listaConsulta.Count; i++)
            {
                dataGridView1.Rows.Add(listaConsulta[i]);
            }
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

        //Guardar atributo
        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Select an attribute");
                return;
            }
            String atributo = comboBox1.SelectedItem.ToString();
            String consulta = $"SELECT idAtributo FROM Atributo WHERE Name = '{atributo}'";
            List<object[]> listaConsulta = new Consulta().Select(consulta);
            int idAtributo = Convert.ToInt32(listaConsulta[0][0]);

            Consulta.conexion.Insert($"INSERT INTO ValorAtributo (idProducto, idAtributo) VALUES ({idProducto}, {idAtributo})");

            LoadDataGridViewAttributes();
            LoadComboBoxAttributes();
        }

        //Borrar atributo
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Da error al borrar atributo
            /*
            if (e.ColumnIndex == 3)
            {
                int rowIndex = e.RowIndex;
                int idAtributo = int.Parse(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());
                Consulta.conexion.Delete($"DELETE FROM ValorAtributo WHERE idProducto = {idProducto} AND idAtributo = {idAtributo}");
                LoadDataGridViewAttributes();
                LoadComboBoxAttributes();
            }
            */
        }
    }
}
