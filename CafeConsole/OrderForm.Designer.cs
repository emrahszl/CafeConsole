namespace CafeConsole
{
    partial class OrderForm
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
            btnAdd = new Button();
            dgvOrderDetails = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            nudCount = new NumericUpDown();
            cboxProduct = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            cboxTableNo = new ComboBox();
            btnReplaceTable = new Button();
            lblTableNo = new Label();
            label5 = new Label();
            lblTotalAmount = new Label();
            btnCancelOrder = new Button();
            btnTakePayment = new Button();
            btnReturnMain = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCount).BeginInit();
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
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(368, 46);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(140, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "EKLE";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvOrderDetails
            // 
            dgvOrderDetails.AllowUserToAddRows = false;
            dgvOrderDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvOrderDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderDetails.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetails.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvOrderDetails.Location = new Point(12, 93);
            dgvOrderDetails.MultiSelect = false;
            dgvOrderDetails.Name = "dgvOrderDetails";
            dgvOrderDetails.ReadOnly = true;
            dgvOrderDetails.RowHeadersVisible = false;
            dgvOrderDetails.RowTemplate.Height = 25;
            dgvOrderDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderDetails.Size = new Size(496, 345);
            dgvOrderDetails.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "ProductName";
            Column1.HeaderText = "Ürün Adı";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "UnitPrice";
            Column2.HeaderText = "Fiyat";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "OrderQuantity";
            Column3.HeaderText = "Adet";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "AmountTL";
            Column4.HeaderText = "Tutar";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // nudCount
            // 
            nudCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nudCount.Location = new Point(257, 46);
            nudCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCount.Name = "nudCount";
            nudCount.Size = new Size(105, 29);
            nudCount.TabIndex = 3;
            nudCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cboxProduct
            // 
            cboxProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxProduct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboxProduct.FormattingEnabled = true;
            cboxProduct.Location = new Point(12, 46);
            cboxProduct.Name = "cboxProduct";
            cboxProduct.Size = new Size(239, 29);
            cboxProduct.TabIndex = 4;
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
            // cboxTableNo
            // 
            cboxTableNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cboxTableNo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxTableNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboxTableNo.FormattingEnabled = true;
            cboxTableNo.Location = new Point(532, 46);
            cboxTableNo.Name = "cboxTableNo";
            cboxTableNo.Size = new Size(121, 29);
            cboxTableNo.TabIndex = 4;
            // 
            // btnReplaceTable
            // 
            btnReplaceTable.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReplaceTable.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnReplaceTable.Location = new Point(670, 46);
            btnReplaceTable.Name = "btnReplaceTable";
            btnReplaceTable.Size = new Size(103, 30);
            btnReplaceTable.TabIndex = 1;
            btnReplaceTable.Text = "TAŞI";
            btnReplaceTable.UseVisualStyleBackColor = true;
            btnReplaceTable.Click += btnReplaceTable_Click;
            // 
            // lblTableNo
            // 
            lblTableNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTableNo.BackColor = Color.Tomato;
            lblTableNo.Font = new Font("Arial Black", 72F, FontStyle.Regular, GraphicsUnit.Point);
            lblTableNo.ForeColor = Color.White;
            lblTableNo.Location = new Point(532, 93);
            lblTableNo.Name = "lblTableNo";
            lblTableNo.Size = new Size(241, 197);
            lblTableNo.TabIndex = 0;
            lblTableNo.Text = "00";
            lblTableNo.TextAlign = ContentAlignment.MiddleCenter;
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
            // lblTotalAmount
            // 
            lblTotalAmount.Anchor = AnchorStyles.Right;
            lblTotalAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalAmount.Location = new Point(676, 306);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(97, 21);
            lblTotalAmount.TabIndex = 0;
            lblTotalAmount.Text = "0.00₺";
            // 
            // btnCancelOrder
            // 
            btnCancelOrder.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelOrder.BackColor = Color.Firebrick;
            btnCancelOrder.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelOrder.ForeColor = Color.White;
            btnCancelOrder.Location = new Point(532, 339);
            btnCancelOrder.Name = "btnCancelOrder";
            btnCancelOrder.Size = new Size(121, 53);
            btnCancelOrder.TabIndex = 1;
            btnCancelOrder.Text = "SİPARİŞ İPTAL";
            btnCancelOrder.UseVisualStyleBackColor = false;
            btnCancelOrder.Click += btnCancelOrder_Click;
            // 
            // btnTakePayment
            // 
            btnTakePayment.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnTakePayment.BackColor = Color.ForestGreen;
            btnTakePayment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTakePayment.ForeColor = Color.White;
            btnTakePayment.Location = new Point(659, 339);
            btnTakePayment.Name = "btnTakePayment";
            btnTakePayment.Size = new Size(114, 53);
            btnTakePayment.TabIndex = 1;
            btnTakePayment.Text = "ÖDEME AL";
            btnTakePayment.UseVisualStyleBackColor = false;
            btnTakePayment.Click += btnTakePayment_Click;
            // 
            // btnReturnMain
            // 
            btnReturnMain.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnReturnMain.BackColor = Color.Gold;
            btnReturnMain.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReturnMain.ForeColor = Color.SaddleBrown;
            btnReturnMain.Location = new Point(532, 398);
            btnReturnMain.Name = "btnReturnMain";
            btnReturnMain.Size = new Size(241, 40);
            btnReturnMain.TabIndex = 1;
            btnReturnMain.Text = "ANASAYFAYA DÖN";
            btnReturnMain.UseVisualStyleBackColor = false;
            btnReturnMain.Click += btnReturnMain_Click;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cboxTableNo);
            Controls.Add(cboxProduct);
            Controls.Add(nudCount);
            Controls.Add(dgvOrderDetails);
            Controls.Add(btnReplaceTable);
            Controls.Add(btnReturnMain);
            Controls.Add(btnTakePayment);
            Controls.Add(btnCancelOrder);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(lblTableNo);
            Controls.Add(lblTotalAmount);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            MinimumSize = new Size(816, 489);
            Name = "OrderForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Masa 0";
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAdd;
        private DataGridView dgvOrderDetails;
        private NumericUpDown nudCount;
        private ComboBox cboxProduct;
        private Label label2;
        private Label label3;
        private ComboBox cboxTableNo;
        private Button btnReplaceTable;
        private Label lblTableNo;
        private Label label5;
        private Label lblTotalAmount;
        private Button btnCancelOrder;
        private Button btnTakePayment;
        private Button btnReturnMain;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}