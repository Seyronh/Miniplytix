namespace MiniPlytix
{
    partial class menuCrearProducto
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            NameTextBox = new TextBox();
            SKUTextBox = new TextBox();
            GTINTextBox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 31);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 88);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 1;
            label2.Text = "SKU";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 145);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "GTIN";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(72, 49);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(157, 23);
            NameTextBox.TabIndex = 3;
            // 
            // SKUTextBox
            // 
            SKUTextBox.Location = new Point(72, 106);
            SKUTextBox.Name = "SKUTextBox";
            SKUTextBox.Size = new Size(157, 23);
            SKUTextBox.TabIndex = 4;
            // 
            // GTINTextBox
            // 
            GTINTextBox.Location = new Point(72, 163);
            GTINTextBox.Name = "GTINTextBox";
            GTINTextBox.Size = new Size(157, 23);
            GTINTextBox.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(112, 227);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // menuCrearProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 288);
            Controls.Add(button1);
            Controls.Add(GTINTextBox);
            Controls.Add(SKUTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "menuCrearProducto";
            Text = "menuCrearProducto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox NameTextBox;
        private TextBox SKUTextBox;
        private TextBox GTINTextBox;
        private Button button1;
    }
}