using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VladCurskiy.Tools
{
    internal class TableAttribute : Attribute
    {
        public string Table { get; }
        public TableAttribute(string table)
        {
            Table = table;
        }
    }
}
