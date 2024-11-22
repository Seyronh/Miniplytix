namespace MiniPlytix
{
    partial class Attributes
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label2 = new Label();
            Tipo = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewButtonColumn();
            Edit = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(80, 61);
            label1.Name = "label1";
            label1.Size = new Size(129, 32);
            label1.TabIndex = 0;
            label1.Text = "Attributes";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Tipo, name, Delete, Edit });
            dataGridView1.Location = new Point(80, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(608, 200);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button1
            // 
            button1.Location = new Point(613, 339);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 339);
            label2.Name = "label2";
            label2.Size = new Size(131, 15);
            label2.TabIndex = 3;
            label2.Text = "Atributos disponibles: 5";
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Type";
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            // 
            // name
            // 
            name.HeaderText = "Name";
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // Delete
            // 
            Delete.HeaderText = "";
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Resizable = DataGridViewTriState.True;
            Delete.SortMode = DataGridViewColumnSortMode.Automatic;
            Delete.Text = "🗑️";
            Delete.ToolTipText = "🗑️";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // Edit
            // 
            Edit.HeaderText = "";
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Resizable = DataGridViewTriState.True;
            Edit.SortMode = DataGridViewColumnSortMode.Automatic;
            Edit.Text = "✏️";
            Edit.ToolTipText = "✏️";
            Edit.UseColumnTextForButtonValue = true;
            // 
            // Attributes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Attributes";
            Size = new Size(793, 409);
            Load += Attributes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button button1;
        private Label label2;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn name;
        private DataGridViewButtonColumn Delete;
        private DataGridViewButtonColumn Edit;
    }
}
