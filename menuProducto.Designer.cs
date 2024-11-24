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
            idAtributo = new DataGridViewTextBoxColumn();
            NameColumn = new DataGridViewTextBoxColumn();
            TypeColumn = new DataGridViewTextBoxColumn();
            Value = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewButtonColumn();
            button2 = new Button();
            textBox1 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            dataGridView2 = new DataGridView();
            NameColumnCategorie = new DataGridViewTextBoxColumn();
            label7 = new Label();
            comboBox2 = new ComboBox();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(103, 396);
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
            label1.Location = new Point(36, 198);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(36, 216);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(230, 23);
            NameTextBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 260);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 4;
            label2.Text = "SKU";
            // 
            // SKUTextBox
            // 
            SKUTextBox.Location = new Point(36, 278);
            SKUTextBox.Name = "SKUTextBox";
            SKUTextBox.Size = new Size(230, 23);
            SKUTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 327);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 4;
            label3.Text = "GTIN";
            // 
            // GTINTextBox
            // 
            GTINTextBox.Location = new Point(36, 345);
            GTINTextBox.Name = "GTINTextBox";
            GTINTextBox.Size = new Size(230, 23);
            GTINTextBox.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(329, 257);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(127, 23);
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
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idAtributo, NameColumn, TypeColumn, Value, Delete });
            dataGridView1.Location = new Point(329, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(253, 146);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // Value
            // 
            Value.HeaderText = "Value";
            Value.Name = "Value";
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.Name = "Delete";
            // 
            // button2
            // 
            button2.Location = new Point(489, 313);
            button2.Name = "button2";
            button2.Size = new Size(93, 23);
            button2.TabIndex = 9;
            button2.Text = "Add attribute";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(329, 314);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(127, 23);
            textBox1.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(329, 239);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 11;
            label5.Text = "New user attribute";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(329, 296);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 12;
            label6.Text = "Value";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { NameColumnCategorie });
            dataGridView2.Location = new Point(685, 69);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(176, 150);
            dataGridView2.TabIndex = 13;
            // 
            // NameColumnCategorie
            // 
            NameColumnCategorie.HeaderText = "Name";
            NameColumnCategorie.Name = "NameColumnCategorie";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(685, 51);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 14;
            label7.Text = "Categories";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(685, 257);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(176, 23);
            comboBox2.TabIndex = 15;
            // 
            // button3
            // 
            button3.Location = new Point(731, 313);
            button3.Name = "button3";
            button3.Size = new Size(92, 23);
            button3.TabIndex = 16;
            button3.Text = "Add categorie";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(36, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 140);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button4
            // 
            button4.Location = new Point(182, 148);
            button4.Name = "button4";
            button4.Size = new Size(84, 23);
            button4.TabIndex = 18;
            button4.Text = "Select image";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // menuProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 452);
            Controls.Add(button4);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(comboBox2);
            Controls.Add(label7);
            Controls.Add(dataGridView2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox1);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private TextBox textBox1;
        private Label label5;
        private Label label6;
        private DataGridView dataGridView2;
        private Label label7;
        private ComboBox comboBox2;
        private Button button3;
        private DataGridViewTextBoxColumn NameColumnCategorie;
        private DataGridViewTextBoxColumn idAtributo;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn TypeColumn;
        private DataGridViewTextBoxColumn Value;
        private DataGridViewButtonColumn Delete;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private Button button4;
    }

}