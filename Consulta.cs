using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

namespace MiniPlytix
{
    internal class Consulta
    {
        private ConexionMySQL conexionMySQL;



        public Consulta()
        {
            conexionMySQL = new ConexionMySQL();
        }



        public List<object[]> Select(string consulta)
        {
            List<object[]> result = new();

            //Establece una conexión
            MySqlConnection connection = conexionMySQL.GetConnection();
            MySqlCommand cmd = new MySqlCommand(consulta, connection);

            //Lector de datos SQL
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Object[] array = new object[reader.FieldCount];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = reader.GetValue(i);
                }
                result.Add(array);
            }

            connection.Close();
            return result;
        }



        public void Update(string consulta)
        {
            //Establece una conexión
            MySqlConnection connection = conexionMySQL.GetConnection();
            MySqlCommand cmd = new MySqlCommand(consulta, connection);

            //Ejecuta el comando
            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public void Delete(string consulta)
        {

            //Establece una conexión
            MySqlConnection connection = conexionMySQL.GetConnection();
            MySqlCommand cmd = new MySqlCommand(consulta, connection);

            //Ejecuta el comando
            cmd.ExecuteNonQuery();

            connection.Close();

        }

        public void Insert(string consulta)
        {

            //Establece una conexión
            MySqlConnection connection = conexionMySQL.GetConnection();
            MySqlCommand cmd = new MySqlCommand(consulta, connection);

            //Ejecuta el comando
            cmd.ExecuteNonQuery();

            connection.Close();

        }
    }
}
