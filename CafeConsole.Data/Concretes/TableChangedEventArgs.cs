using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeConsole.Data.Concretes
{
    public class TableChangedEventArgs : EventArgs
    {
        public TableChangedEventArgs(int currentTable, int targetTable)
        {
            CurrentTable = currentTable;
            TargetTable = targetTable;
        }

        public int CurrentTable { get; set; }
        public int TargetTable { get; set; }
    }
}
