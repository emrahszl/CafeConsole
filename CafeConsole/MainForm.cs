using CafeConsole.Data;
using CafeConsole.Data.Concretes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
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
            LoadData();
            LoadTables();
        }

        private void LoadData()
        {
            try
            {
                string json = File.ReadAllText("veri.json");
                dataBase = JsonSerializer.Deserialize<CafeData>(json)!;
            }
            catch (Exception)
            {
                LoadProducts();
            }
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
                lvi.ImageKey = dataBase.ActiveOrders.Any(x => x.TableNumber == i) ? "dolu" : "bos"; //Aktif siparişler içerisinde TableNumber propertysi oluşan bir sipariş varsa (yani sipariş nesnesi varsa) o masayı açık gösteriyoruz.
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
            formOrder.TableChanged += FormOrder_TableChanged;
            formOrder.ShowDialog();

            if (order.Status != OrderStatus.Active)
                lviClicked.ImageKey = "bos";
        }

        private void FormOrder_TableChanged(object? sender, TableChangedEventArgs e)
        {
            foreach (ListViewItem item in lvTables.Items)
            {
                int tableNo = (int)item.Tag;

                if (tableNo == e.CurrentTable)
                {
                    item.ImageKey = "bos";
                    item.Selected = false;
                }
                if (tableNo == e.TargetTable)
                {
                    item.ImageKey = "dolu";
                    item.Selected = true;
                }
            }
        }

        private void lastOrderTsmi_Click(object sender, EventArgs e)
        {
            new LastOrdersForm(dataBase).ShowDialog();
        }

        private void productsTsmi_Click(object sender, EventArgs e)
        {
            new ProductsForm(dataBase).ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveAllData();
        }

        private void SaveAllData()
        {
            string json = JsonSerializer.Serialize(dataBase);
            File.WriteAllText("veri.json", json);
        }
    }
}
