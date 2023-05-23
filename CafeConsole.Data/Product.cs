using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeConsole.Data
{
    public class Product
    {
        public string ProductName { get; set; } = string.Empty;
        public decimal UnitPrice { get; set; }

        public override string? ToString()
        {
            return $"{ProductName} ({UnitPrice:c2})";
        }
    }
}
