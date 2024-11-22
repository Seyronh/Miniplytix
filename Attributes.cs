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
    public partial class Attributes : UserControl
    {
        private int MAXATRIBUTOS = 5;
        private int ContadorAtributos = 0;
        public Attributes()
        {
            InitializeComponent();
        }

        private void Attributes_Load(object sender, EventArgs e)
        {
            String consulta = "SELECT TipoAtributo.nombre, Name  FROM Atributo JOIN TipoAtributo ON Atributo.idTipoAtributo = TipoAtributo.idTipoAtributo";

            dataGridView1.Rows.Clear();

            List<object[]> listaConsulta = Consulta.conexion.Select(consulta);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            for (int i = 0; i < listaConsulta.Count; i++)
            {
                dataGridView1.Rows.Add(listaConsulta[i]);
                ContadorAtributos++;
            }
            actualizarDisponibles();
        }
        private void actualizarDisponibles()
        {
            label2.Text = "Atributos disponibles: " + (MAXATRIBUTOS - ContadorAtributos);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MAXATRIBUTOS == ContadorAtributos)
            {
                MessageBox.Show("You reached the maximum attributes quantity");
                return;
            }
            menuAtributo menu = new menuAtributo();
            menu.ShowDialog();
            int NuevoTipo = menu.getTipo();
            string NuevoNombre = menu.getNombre();
            if (NuevoNombre.Length == 0 || NuevoTipo == 0) return;
            Consulta.conexion.Insert("INSERT INTO Atributo (Name,idTipoAtributo) VALUE ('" + NuevoNombre + "',"+NuevoTipo+")");
            List<object[]> listaConsulta = Consulta.conexion.Select("SELECT nombre FROM TipoAtributo WHERE idTipoAtributo=" + NuevoTipo);
            dataGridView1.Rows.Add([listaConsulta[0][0],NuevoNombre]);
            ContadorAtributos++;
            actualizarDisponibles();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == -1) return; //Evitar pulsar titulos
            if (e.ColumnIndex == 2) //BORRAR
            {
                int rowIndex = e.RowIndex;
                string nombreAtributo = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
                List<object[]> listaConsulta = Consulta.conexion.Select("SELECT idAtributo FROM Atributo WHERE Name='" + nombreAtributo + "'");
                int ID = Convert.ToInt32(listaConsulta[0][0]);
                Consulta.conexion.Delete("DELETE FROM ValorAtributo WHERE idAtributo=" + ID);
                Consulta.conexion.Delete("DELETE FROM Atributo WHERE Name='" + nombreAtributo + "'");
                dataGridView1.Rows.RemoveAt(rowIndex);
                ContadorAtributos--;
                actualizarDisponibles();
            }
            if (e.ColumnIndex == 3) //EDITAR
            {
                int rowIndex = e.RowIndex;
                string nombreAtributo = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
                List<object[]> listaConsulta = Consulta.conexion.Select("SELECT idTipoAtributo FROM Atributo WHERE Name='" + nombreAtributo + "'");
                int ID = Convert.ToInt32(listaConsulta[0][0]);
                menuAtributo menu = new menuAtributo(nombreAtributo,ID);
                menu.ShowDialog();
                int NuevoTipo = menu.getTipo();
                string NuevoNombre = menu.getNombre();
                if (NuevoNombre.Length == 0 || NuevoTipo == 0) return;
                Consulta.conexion.Update("UPDATE Atributo SET Name='" + NuevoNombre + "', idTipoAtributo=" + NuevoTipo+" WHERE Name='"+nombreAtributo+"'");
                listaConsulta = Consulta.conexion.Select("SELECT nombre FROM TipoAtributo WHERE idTipoAtributo=" + NuevoTipo);
                dataGridView1.Rows[rowIndex].Cells[0].Value = listaConsulta[0][0];
                dataGridView1.Rows[rowIndex].Cells[1].Value = NuevoNombre;
            }
        }
    }
}
