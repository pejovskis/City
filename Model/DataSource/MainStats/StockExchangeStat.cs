using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City.Model.DataSource.MainStats
{
    public class StockExchangeStat
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public StockExchangeStat(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public override string ToString()
        {
            return $"{Name}: {Value}";
        }
    }
}
