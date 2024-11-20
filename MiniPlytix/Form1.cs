using MySql.Data.MySqlClient;

namespace MiniPlytix
{
    public partial class Form1 : Form
    {

        private string cadenaConexion = "server=database-minipim.cdwgeayaeh1v.eu-central-1.rds.amazonaws.com; port=3306; user id=grupo04; database=grupo04DB;" +
            "password=45DG7pKxGyvmsxd5;";
        private MySqlConnection connection;

        public Form1()
        {
            InitializeComponent();
            connection = new MySqlConnection(cadenaConexion);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string comando = textBox1.Text;
            textBox1.Text = "";

            try
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();

                connection.Open();
                MySqlDataReader lector = null;
                MySqlCommand cmd = new MySqlCommand(comando, connection);

                lector = cmd.ExecuteReader();

                if(lector.FieldCount != 0)
                {
                    for(int i = 0; i < lector.FieldCount; i++)
                    {
                        DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                        col.HeaderText = lector.GetName(i);
                        dataGridView1.Columns.Add(col);
                    }

                    while (lector.Read())
                    {
                        Object[] array = new object[lector.FieldCount];
                        for(int i = 0; i < array.Length; i++)
                        {
                            array[i] = lector.GetValue(i);
                        }
                        dataGridView1.Rows.Add(array);
                    }
                }
                else
                {
                    MessageBox.Show("Ha sido actualizado/agregado/eliminado");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();

        }
    }
}
