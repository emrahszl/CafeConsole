﻿namespace CafeConsole
{
    partial class UrunlerForm
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
            textBox1 = new TextBox();
            label1 = new Label();
            btnEkle = new Button();
            dataGridView1 = new DataGridView();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(25, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 29);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 25);
            label1.Name = "label1";
            label1.Size = new Size(72, 21);
            label1.TabIndex = 1;
            label1.Text = "Ürün Adı";
            // 
            // btnEkle
            // 
            btnEkle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEkle.Location = new Point(399, 61);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 29);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(609, 330);
            dataGridView1.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(217, 61);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(176, 29);
            numericUpDown1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(217, 25);
            label2.Name = "label2";
            label2.Size = new Size(111, 21);
            label2.TabIndex = 1;
            label2.Text = "Birim Fiyatı (₺)";
            // 
            // UrunlerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 447);
            Controls.Add(numericUpDown1);
            Controls.Add(dataGridView1);
            Controls.Add(btnEkle);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "UrunlerForm";
            Text = "UrunlerForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button btnEkle;
        private DataGridView dataGridView1;
        private NumericUpDown numericUpDown1;
        private Label label2;
    }
}