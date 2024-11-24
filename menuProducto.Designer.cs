namespace MiniPlytix
{
    partial class menuProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            NameTextBox = new TextBox();
            label2 = new Label();
            SKUTextBox = new TextBox();
            label3 = new Label();
            GTINTextBox = new TextBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            idAtributo = new DataGridViewTextBoxColumn();
            NameColumn = new DataGridViewTextBoxColumn();
            TypeColumn = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(103, 304);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 69);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(36, 87);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(212, 23);
            NameTextBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 151);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 4;
            label2.Text = "SKU";
            // 
            // SKUTextBox
            // 
            SKUTextBox.Location = new Point(36, 169);
            SKUTextBox.Name = "SKUTextBox";
            SKUTextBox.Size = new Size(212, 23);
            SKUTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 229);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 4;
            label3.Text = "GTIN";
            // 
            // GTINTextBox
            // 
            GTINTextBox.Location = new Point(36, 247);
            GTINTextBox.Name = "GTINTextBox";
            GTINTextBox.Size = new Size(212, 23);
            GTINTextBox.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(329, 247);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(164, 23);
            comboBox1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(329, 51);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 7;
            label4.Text = "User attributes";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idAtributo, NameColumn, TypeColumn, Delete });
            dataGridView1.Location = new Point(329, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(253, 146);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button2
            // 
            button2.Location = new Point(507, 246);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // idAtributo
            // 
            idAtributo.HeaderText = "idAtributo";
            idAtributo.Name = "idAtributo";
            // 
            // NameColumn
            // 
            NameColumn.HeaderText = "Name";
            NameColumn.Name = "NameColumn";
            // 
            // TypeColumn
            // 
            TypeColumn.HeaderText = "Type";
            TypeColumn.Name = "TypeColumn";
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.Name = "Delete";
            // 
            // menuProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 393);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(GTINTextBox);
            Controls.Add(label3);
            Controls.Add(SKUTextBox);
            Controls.Add(label2);
            Controls.Add(NameTextBox);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "menuProducto";
            Text = "menuCrearProducto";
            Load += menuProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox NameTextBox;
        private Label label2;
        private TextBox SKUTextBox;
        private Label label3;
        private TextBox GTINTextBox;
        private ComboBox comboBox1;
        private Label label4;
        private DataGridView dataGridView1;
        private Button button2;
        private DataGridViewTextBoxColumn idAtributo;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn TypeColumn;
        private DataGridViewButtonColumn Delete;
    }

}