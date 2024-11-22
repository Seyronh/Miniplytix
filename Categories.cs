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

            dataGridView1.Rows.Clear();

            List<object[]> listaConsulta = new Consulta().Select(consulta);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            for (int i = 0; i < listaConsulta.Count; i++)
            {
                dataGridView1.Rows.Add(listaConsulta[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menuCrearCategoria crear = new menuCrearCategoria();
            crear.ShowDialog();
            if (crear.getNuevo().Length == 0) return;
            new Consulta().Insert("INSERT INTO Categoria (Name) VALUE ('" + crear.getNuevo() + "')");
            dataGridView1.Rows.Add([crear.getNuevo(),0]);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == -1) return; //Evitar pulsar titulos
            if(e.ColumnIndex == 2) //BORRAR
            {
                int rowIndex = e.RowIndex;
                string nombreCategoria = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
                List<object[]> listaConsulta = new Consulta().Select("SELECT idCategoria FROM Categoria WHERE Name='"+nombreCategoria+"'");
                int ID = Convert.ToInt32(listaConsulta[0][0]);
                new Consulta().Delete("DELETE FROM Producto_Categoria WHERE Categoria_idCategoria =" + ID);
                new Consulta().Delete("DELETE FROM Categoria WHERE Name='" + nombreCategoria+"'");
                dataGridView1.Rows.RemoveAt(rowIndex);
            }
            if (e.ColumnIndex == 3) //EDITAR
            {
                int rowIndex = e.RowIndex;
                string nombreCategoria = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
                menuEditarCategoria cambiarnombre = new menuEditarCategoria(nombreCategoria);
                cambiarnombre.ShowDialog();
                new Consulta().Update("UPDATE Categoria SET Name='" + cambiarnombre.getNuevo() + "' WHERE Name='" + nombreCategoria + "'");
                dataGridView1.Rows[rowIndex].Cells[0].Value = cambiarnombre.getNuevo();
            }
        }
    }
}
