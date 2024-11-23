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
    public partial class detallesProducto : UserControl
    {
        private int productoId;
        private string nombre;
        private int SKU;
        private int GTIN;

        public detallesProducto(int idProducto)
        {
            InitializeComponent();
            this.productoId = idProducto;
        }

        private void detallesProducto_Load(object sender, EventArgs e)
        {
            String consulta = "SELECT Name, SKU, GTIN FROM Producto WHERE idProducto = " + productoId;

            List<object[]> listaConsulta = new Consulta().Select(consulta);

            nombre = listaConsulta[0][0].ToString();
            SKU = Convert.ToInt32(listaConsulta[0][1]);
            GTIN = Convert.ToInt32(listaConsulta[0][2]);

            Namelabel.Text = listaConsulta[0][0].ToString();
            SKUlabel.Text = listaConsulta[0][1].ToString();
            GTINlabel.Text = listaConsulta[0][2].ToString();
        }


        //Boton eliminar
        private void button1_Click(object sender, EventArgs e)
        {
            Consulta.conexion.Delete("DELETE  FROM Producto_Categoria WHERE Producto_idProducto = " + productoId);
            Consulta.conexion.Delete("DELETE FROM ValorAtributo WHERE idProducto=" + productoId);
            Consulta.conexion.Delete("DELETE FROM Producto WHERE idProducto=" + productoId);
            
            Productos p = new Productos();

            Panel parentPanel = this.Parent as Panel;
            if (parentPanel != null)
            {
                parentPanel.Controls.Clear();
                parentPanel.Controls.Add(p);
                p.Dock = DockStyle.Fill;
            }
        }

        //Boton editar
        private void button2_Click(object sender, EventArgs e)
        {
            menuEditarProducto editarProducto = new menuEditarProducto(nombre, SKU, GTIN);
            editarProducto.ShowDialog();
            Consulta.conexion.Update("UPDATE Producto SET Name= '" + editarProducto.getName() + "', SKU= " + editarProducto.getSKU() + ", GTIN= " + editarProducto.getGTIN() + " WHERE idProducto=" + productoId);

            Namelabel.Text = editarProducto.getName();
            SKUlabel.Text = editarProducto.getSKU().ToString();
            GTINlabel.Text = editarProducto.getGTIN().ToString();


        }
    }
}
