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

        }

        //Boton editar
        private void button2_Click(object sender, EventArgs e)
        {
            menuEditarProducto editarProducto = new menuEditarProducto(nombre, SKU, GTIN);
            editarProducto.ShowDialog();
        }
    }
}
