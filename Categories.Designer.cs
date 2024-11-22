namespace MiniPlytix
{
    partial class Categories
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
            name = new DataGridViewTextBoxColumn();
            NProducts = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewButtonColumn();
            Edit = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(80, 25);
            label1.Name = "label1";
            label1.Size = new Size(135, 32);
            label1.TabIndex = 0;
            label1.Text = "Categories";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { name, NProducts, Delete, Edit });
            dataGridView1.Location = new Point(80, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(624, 247);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button1
            // 
            button1.Location = new Point(629, 333);
            button1.Name = "button1";
            button1.Size = new Size(75, 36);
            button1.TabIndex = 2;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            name.HeaderText = "Name";
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // NProducts
            // 
            NProducts.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NProducts.HeaderText = "# Products";
            NProducts.Name = "NProducts";
            NProducts.ReadOnly = true;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Edit.HeaderText = "";
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Text = "✏️";
            Edit.ToolTipText = "✏️";
            Edit.UseColumnTextForButtonValue = true;
            // 
            // Categories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Categories";
            Size = new Size(793, 409);
            Load += Categories_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button button1;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn NProducts;
        private DataGridViewButtonColumn Delete;
        private DataGridViewButtonColumn Edit;
    }
}
