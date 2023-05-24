using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeConsole.Data.Concretes;

namespace CafeConsole.Data
{
    public class CafeData
    {
        public int NumberOfTable { get; set; } = 20;
        public List<Product> Products { get; set; } = new();
        public List<Order> ActiveOrders { get; set; } = new();
        public List<Order> CompletedOrders { get; set; } = new();
    }
}
