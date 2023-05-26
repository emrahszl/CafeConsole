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
    public partial class OrderForm : Form
    {
        private readonly CafeData _cafeData;
        private readonly Order _order;
        private readonly BindingList<OrderDetail> _orderDetails;

        public OrderForm(CafeData cafeData, Order order)
        {
            _cafeData = cafeData;
            _order = order;
            _orderDetails = new BindingList<OrderDetail>(_order.OrderDetails);
            _orderDetails.ListChanged += _orderDetails_ListChanged;
            InitializeComponent();
            dgvOrderDetails.AutoGenerateColumns = false;
            dgvOrderDetails.DataSource = _orderDetails;
            UpdateFormOrder();

        }

        private void _orderDetails_ListChanged(object? sender, ListChangedEventArgs e)
        {
            UpdateFormOrder();
        }

        private void UpdateFormOrder()
        {
            Text = $"Masa {_order.TableNumber} - Açılış Saati : ({_order.OpeningTime.ToString("f")})";
            lblTableNo.Text = _order.TableNumber.ToString("00");
            lblTotalAmount.Text = _order.TotalAmountTL;
            cboxProduct.DataSource = _cafeData.Products;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = (Product)cboxProduct.SelectedItem;

            if (product == null) return;

            var orderDetail = _orderDetails.FirstOrDefault(x => x.ProductName == product.ProductName);

            if (orderDetail == null)
            {
                orderDetail = new OrderDetail() { ProductName = product.ProductName, UnitPrice = product.UnitPrice, OrderQuantity = (int)nudCount.Value };

                _orderDetails.Add(orderDetail);
            }
            else
            {
                orderDetail.OrderQuantity += (int)nudCount.Value;
                _orderDetails.ResetBindings(); //Bağları tekrar kur (böylelikle değişiklik olduğu haberi iletilecek, ListChanged eventi de tetiklenecek)
            }

        }

        private void btnReturnMain_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTakePayment_Click(object sender, EventArgs e)
        {
            CloseTable(OrderStatus.Paid, _order.TotalAmount());
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            CloseTable(OrderStatus.Cancelled, 0);
        }

        private void CloseTable(OrderStatus newStatus, decimal paidAmount)
        {
            _order.Status = newStatus;
            _order.PaidAmount = paidAmount;
            _order.ClosingTime = DateTime.Now;
            _cafeData.ActiveOrders.Remove(_order);
            _cafeData.CompletedOrders.Add(_order);
            Close();
        }
    }
}
