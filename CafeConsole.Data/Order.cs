using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeConsole.Data
{
    public class Order
    {
        public int TableNumber { get; set; }
        public OrderStatus Status { get; set; }
        public decimal PaidAmount { get; set; }
        public DateTime OpeningTime { get; set; } = DateTime.Now;
        public DateTime? ClosingTime { get; set; }
        public List<OrderDetail> OrderDetails { get; set; } = new(); //new List<OrderDetail>(); aynı şeyi ifade eder.
        public string TotalAmountTL => TotalAmount().ToString("c2"); //property

        public decimal TotalAmount() => OrderDetails.Sum(x => x.Amount()); //method
    }
}
