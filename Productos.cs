﻿using System;
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
            String consulta = "SELECT Name, SKU, GTIN FROM Producto";

            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            List<object[]> listaConsulta = new Consulta().Select(consulta);

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Name" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "SKU" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "GTIN" });

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            for (int i = 0; i < listaConsulta.Count; i++)
            {
                dataGridView1.Rows.Add(listaConsulta[i]);
            }
        }
    }
}