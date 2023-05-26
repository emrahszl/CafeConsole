using CafeConsole.Data;
using CafeConsole.Data.Concretes;
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
    public partial class LastOrdersForm : Form
    {
        private readonly CafeData _cafeData;

        public LastOrdersForm(CafeData cafeData)
        {
            _cafeData = cafeData;
            InitializeComponent();
            dgvOrders.AutoGenerateColumns = false;
            dgvOrderDetail.AutoGenerateColumns = false;
            dgvOrders.DataSource = _cafeData.CompletedOrders;
        }

        private void dgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count == 0)
            {
                dgvOrderDetail.DataSource = null;
            }
            else
            {
                var selectedRow = dgvOrders.SelectedRows[0];
                var selectedOrder = (Order)selectedRow.DataBoundItem;
                dgvOrderDetail.DataSource = selectedOrder.OrderDetails;
            }
        }
    }
}
