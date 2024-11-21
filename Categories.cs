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
    public partial class Categories : UserControl
    {
        public Categories()
        {
            InitializeComponent();
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            String consulta = "SELECT c.Name, COUNT(pc.Producto_idProducto) FROM Categoria c LEFT JOIN Producto_Categoria pc ON c.idCategoria = pc.Categoria_idCategoria GROUP BY c.Name";

            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            List<object[]> listaConsulta = new Consulta().Select(consulta);

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Name" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "# Product" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Action" });

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            for (int i = 0; i < listaConsulta.Count; i++)
            {
                dataGridView1.Rows.Add(listaConsulta[i]);
            }
        }
    }
}
