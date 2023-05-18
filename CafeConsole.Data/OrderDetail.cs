using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeConsole.Data
{
    public class OrderDetail
    {
        public string ProductName { get; set; } = string.Empty;
        public decimal UnitPrice { get; set; }
        public int OrderQuantity { get; set; }
        public string AmountTL { get; } = string.Empty;

        public decimal Amount()
        {
            return Decimal.Parse(AmountTL);
        }
    }
}
