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
    public partial class MainForm : Form
    {
        CafeData dataBase = new CafeData();
        public MainForm()
        {
            InitializeComponent();
            LoadProducts();
            LoadTables();
        }

        private void LoadProducts()
        {
            dataBase.Products.Clear();
            dataBase.Products.Add(new Product { ProductName = "Kola", UnitPrice = 15m });
            dataBase.Products.Add(new Product { ProductName = "Ayran", UnitPrice = 18m });
        }

        private void LoadTables()
        {
            lvTables.Items.Clear();

            for (int i = 1; i <= dataBase.NumberOfTable; i++)
            {
                var lvi = new ListViewItem($"Masa {i}");
                lvi.Tag = i;
                lvi.ImageKey = "bos";
                lvTables.Items.Add(lvi);
            }
        }

        private void lvTables_DoubleClick(object sender, EventArgs e)
        {
            var lviClicked = lvTables.SelectedItems[0];
            int tableNo = (int)lviClicked.Tag;
            var order = dataBase.ActiveOrders.FirstOrDefault(x => x.TableNumber == tableNo);

            if (order == null)
            {
                lviClicked.ImageKey = "dolu";
                order = new Order() { TableNumber = tableNo };
                dataBase.ActiveOrders.Add(order);
            }

            var formOrder = new OrderForm(dataBase, order);
            formOrder.ShowDialog();

            if (order.Status != OrderStatus.Active)
                lviClicked.ImageKey = "bos";
        }
    }
}
