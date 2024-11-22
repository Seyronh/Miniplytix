namespace MiniPlytix
{
    partial class detallesProducto
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
            label2 = new Label();
            SKUlabel = new Label();
            GTINlabel = new Label();
            label5 = new Label();
            Namelabel = new Label();
            ButtonDelete = new Button();
            ButtonEdit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 196);
            label1.Name = "label1";
            label1.Size = new Size(41, 21);
            label1.TabIndex = 0;
            label1.Text = "SKU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 251);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // SKUlabel
            // 
            SKUlabel.AutoSize = true;
            SKUlabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SKUlabel.Location = new Point(87, 196);
            SKUlabel.Name = "SKUlabel";
            SKUlabel.Size = new Size(52, 21);
            SKUlabel.TabIndex = 2;
            SKUlabel.Text = "label3";
            // 
            // GTINlabel
            // 
            GTINlabel.AutoSize = true;
            GTINlabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GTINlabel.Location = new Point(87, 231);
            GTINlabel.Name = "GTINlabel";
            GTINlabel.Size = new Size(52, 21);
            GTINlabel.TabIndex = 3;
            GTINlabel.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(40, 231);
            label5.Name = "label5";
            label5.Size = new Size(48, 21);
            label5.TabIndex = 4;
            label5.Text = "GTIN";
            // 
            // Namelabel
            // 
            Namelabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Namelabel.Location = new Point(261, 41);
            Namelabel.Name = "Namelabel";
            Namelabel.Size = new Size(193, 36);
            Namelabel.TabIndex = 5;
            Namelabel.Text = "label6";
            // 
            // ButtonDelete
            // 
            ButtonDelete.Location = new Point(610, 46);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(121, 29);
            ButtonDelete.TabIndex = 6;
            ButtonDelete.Text = "Delete product";
            ButtonDelete.UseVisualStyleBackColor = true;
            ButtonDelete.Click += button1_Click;
            // 
            // ButtonEdit
            // 
            ButtonEdit.Location = new Point(610, 106);
            ButtonEdit.Name = "ButtonEdit";
            ButtonEdit.Size = new Size(121, 31);
            ButtonEdit.TabIndex = 7;
            ButtonEdit.Text = "Edit product";
            ButtonEdit.UseVisualStyleBackColor = true;
            ButtonEdit.Click += button2_Click;
            // 
            // detallesProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ButtonEdit);
            Controls.Add(ButtonDelete);
            Controls.Add(Namelabel);
            Controls.Add(label5);
            Controls.Add(GTINlabel);
            Controls.Add(SKUlabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "detallesProducto";
            Size = new Size(793, 409);
            Load += detallesProducto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label SKUlabel;
        private Label GTINlabel;
        private Label label5;
        private Label Namelabel;
        private Button ButtonDelete;
        private Button ButtonEdit;
    }
}
