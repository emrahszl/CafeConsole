using CafeConsole.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeConsole
{
    public partial class ProductsForm : Form
    {
        private readonly CafeData _cafeData;
        BindingList<Product> products;

        public ProductsForm(CafeData cafeData)
        {
            _cafeData = cafeData;
            products = new BindingList<Product>(cafeData.Products);
            InitializeComponent();
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.DataSource = products;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductName.Text) && nudUnitPrice.Value == 0)
            {
                MessageBox.Show("Ürün adı girilmedi!/Fiyat 0 olamaz!");
                return;
            }

            if (btnAdd.Text == "EKLE")
            {
                products.Add(new Product { ProductName = txtProductName.Text.Trim(), UnitPrice = nudUnitPrice.Value });
            }
            else if (editted != null)
            {
                editted.ProductName = txtProductName.Text;
                editted.UnitPrice = nudUnitPrice.Value;
                products.ResetBindings();
            }

            ResetForm();
        }

        Product? editted;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                var row = dgvProducts.SelectedRows[0];
                var product = (Product)row.DataBoundItem;
                editted = product;
                txtProductName.Text = product.ProductName;
                nudUnitPrice.Value = product.UnitPrice;
                btnAdd.Text = "KAYDET";
                dgvProducts.Enabled = false;
                btnCancel.Show();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            btnCancel.Hide();
            btnAdd.Text = "EKLE";
            txtProductName.Clear();
            nudUnitPrice.Value = 0;
            dgvProducts.Enabled = true;
            editted = null;
        }
    }
}
