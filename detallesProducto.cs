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
        private DateTime FechaCreacion;

        public detallesProducto(int idProducto)
        {
            InitializeComponent();
            this.productoId = idProducto;
        }

        private void detallesProducto_Load(object sender, EventArgs e)
        {
            loadProductDetails();
        }

        private void loadProductDetails()
        {
            String consulta = "SELECT Name, SKU, GTIN, FechaCreacion, FechaModificacion FROM Producto WHERE idProducto = " + productoId;

            List<object[]> listaConsulta = new Consulta().Select(consulta);

            nombre = listaConsulta[0][0].ToString();
            SKU = Convert.ToInt32(listaConsulta[0][1]);
            GTIN = Convert.ToInt32(listaConsulta[0][2]);
            FechaCreacion = (DateTime)listaConsulta[0][3];

            Namelabel.Text = listaConsulta[0][0].ToString();
            SKUlabel.Text = listaConsulta[0][1].ToString();
            GTINlabel.Text = listaConsulta[0][2].ToString();
            FechaCreacionlabel.Text = listaConsulta[0][3].ToString();
            FechaModificacionLabel.Text = listaConsulta[0][4].ToString();

            String consulta2 = "SELECT Atributo.Name, ValorAtributo.valor FROM Atributo JOIN ValorAtributo ON Atributo.idAtributo = ValorAtributo.idAtributo WHERE ValorAtributo.idProducto = " + productoId;
            List<object[]> listaConsulta2 = new Consulta().Select(consulta2);

            for (int i = 0; i < listaConsulta2.Count; i++)
            {
                var attributeLabel = this.Controls.Find("userAttribute" + (i + 1), true).FirstOrDefault() as Label;
                var valueLabel = this.Controls.Find("value" + (i + 1), true).FirstOrDefault() as Label;

                if (attributeLabel != null && valueLabel != null)
                {
                    attributeLabel.Text = listaConsulta2[i][0].ToString() + ":";
                    valueLabel.Text = listaConsulta2[i][1].ToString();
                }
            }


            string query = $"SELECT imagen FROM Producto WHERE idProducto = {productoId}";
            List<object[]> listaConsulta3 = new Consulta().Select(query);
            if (listaConsulta3[0][0] == DBNull.Value)
            {
                return;
            }
            else
            {
                byte[] img = (byte[])listaConsulta3[0][0];
                pictureBox1.Image = Image.FromStream(new System.IO.MemoryStream(img));
            }
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
            menuProducto editarProducto = new menuProducto(productoId, nombre, SKU, GTIN);
            editarProducto.ShowDialog();

            DateTime fechaModificacion = DateTime.Now;
            Consulta.conexion.Update("UPDATE Producto SET Name= '" + editarProducto.getName() + "', SKU= " + editarProducto.getSKU() + ", GTIN= " + editarProducto.getGTIN() + ", FechaModificacion='" + fechaModificacion.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE idProducto=" + productoId);
            
            loadProductDetails();
        }
    }
}
