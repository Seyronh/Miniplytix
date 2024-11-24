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
    public partial class Productos : UserControl
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            String consulta = "SELECT idProducto, Name, SKU, GTIN FROM Producto";

            dataGridView1.Rows.Clear();

            List<object[]> listaConsulta = new Consulta().Select(consulta);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            for (int i = 0; i < listaConsulta.Count; i++)
            {
                dataGridView1.Rows.Add(listaConsulta[i]);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            if (e.ColumnIndex == 4)
            {
                int rowIndex = e.RowIndex;
                var idProducto = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[0].Value);

                detallesProducto detalles = new detallesProducto(idProducto);

                Panel parentPanel = this.Parent as Panel;
                if (parentPanel != null)
                {
                    parentPanel.Controls.Clear();
                    parentPanel.Controls.Add(detalles);
                    detalles.Dock = DockStyle.Fill;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menuCrearProducto crear = new menuCrearProducto();
            crear.ShowDialog();
            if (crear.getName().Length == 0 || crear.getSKU() == 0 || crear.getGTIN() == 0) return;
            String consulta = "INSERT INTO Producto (Name, GTIN, SKU) VALUES ('" + crear.getName() + "', " + crear.getGTIN() + "," + crear.getSKU() + " )";
            Consulta.conexion.Insert(consulta);
            
            consulta = "SELECT idProducto, Name, SKU, GTIN FROM Producto";

            dataGridView1.Rows.Clear();

            List<object[]> listaConsulta = new Consulta().Select(consulta);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            for (int i = 0; i < listaConsulta.Count; i++)
            {
                dataGridView1.Rows.Add(listaConsulta[i]);
            }
        }
    }
}
