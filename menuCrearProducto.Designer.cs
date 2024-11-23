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
            button1 = new Button();
            label1 = new Label();
            NameTextBox = new TextBox();
            label2 = new Label();
            SKUTextBox = new TextBox();
            label3 = new Label();
            GTINTextBox = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(98, 200);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 19);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(36, 37);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(212, 23);
            NameTextBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 71);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 4;
            label2.Text = "SKU";
            // 
            // SKUTextBox
            // 
            SKUTextBox.Location = new Point(36, 89);
            SKUTextBox.Name = "SKUTextBox";
            SKUTextBox.Size = new Size(212, 23);
            SKUTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 124);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 4;
            label3.Text = "GTIN";
            // 
            // GTINTextBox
            // 
            GTINTextBox.Location = new Point(36, 142);
            GTINTextBox.Name = "GTINTextBox";
            GTINTextBox.Size = new Size(212, 23);
            GTINTextBox.TabIndex = 5;
            // 
            // menuCrearProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(287, 251);
            Controls.Add(GTINTextBox);
            Controls.Add(label3);
            Controls.Add(SKUTextBox);
            Controls.Add(label2);
            Controls.Add(NameTextBox);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "menuCrearProducto";
            Text = "menuCrearProducto";
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
    }

}