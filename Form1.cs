using MySql.Data.MySqlClient;

namespace MiniPlytix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            List<object[]> listaConsulta = new Consulta().Select(textBox1.Text);

            for (int i = 0; i < listaConsulta[0].Length; i++)
            {
                DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                dataGridView1.Columns.Add(col);
            }

            for (int i = 0; i < listaConsulta.Count; i++)
            {
                    dataGridView1.Rows.Add(listaConsulta[i]);
            }

            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            new Consulta().Insert(textBox1.Text);
        }
    }
}
