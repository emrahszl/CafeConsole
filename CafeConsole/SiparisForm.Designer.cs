namespace CafeConsole
{
    partial class SiparisForm
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            comboBox2 = new ComboBox();
            button2 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(45, 21);
            label1.TabIndex = 0;
            label1.Text = "Ürün";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(368, 46);
            button1.Name = "button1";
            button1.Size = new Size(140, 29);
            button1.TabIndex = 1;
            button1.Text = "EKLE";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(496, 345);
            dataGridView1.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(257, 46);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(105, 29);
            numericUpDown1.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 46);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(239, 29);
            comboBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(257, 9);
            label2.Name = "label2";
            label2.Size = new Size(42, 21);
            label2.TabIndex = 0;
            label2.Text = "Adet";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(532, 9);
            label3.Name = "label3";
            label3.Size = new Size(75, 21);
            label3.TabIndex = 0;
            label3.Text = "Masa No:";
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(532, 46);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 29);
            comboBox2.TabIndex = 4;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(670, 46);
            button2.Name = "button2";
            button2.Size = new Size(103, 30);
            button2.TabIndex = 1;
            button2.Text = "TAŞI";
            button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.BackColor = Color.Tomato;
            label4.Font = new Font("Arial Black", 72F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(532, 93);
            label4.Name = "label4";
            label4.Size = new Size(241, 197);
            label4.TabIndex = 0;
            label4.Text = "00";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(537, 306);
            label5.Name = "label5";
            label5.Size = new Size(125, 21);
            label5.TabIndex = 0;
            label5.Text = "Ödeme Tutarı : ";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(676, 306);
            label6.Name = "label6";
            label6.Size = new Size(97, 21);
            label6.TabIndex = 0;
            label6.Text = "0.00₺";
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.BackColor = Color.Firebrick;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(532, 339);
            button3.Name = "button3";
            button3.Size = new Size(121, 53);
            button3.TabIndex = 1;
            button3.Text = "SİPARİŞ İPTAL";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button4.BackColor = Color.ForestGreen;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(659, 339);
            button4.Name = "button4";
            button4.Size = new Size(114, 53);
            button4.TabIndex = 1;
            button4.Text = "ÖDEME AL";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button5.BackColor = Color.Gold;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.SaddleBrown;
            button5.Location = new Point(532, 398);
            button5.Name = "button5";
            button5.Size = new Size(241, 40);
            button5.TabIndex = 1;
            button5.Text = "ANASAYFAYA DÖN";
            button5.UseVisualStyleBackColor = false;
            // 
            // SiparisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            MinimumSize = new Size(816, 489);
            Name = "SiparisForm";
            Text = "Masa 0";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private DataGridView dataGridView1;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox2;
        private Button button2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}