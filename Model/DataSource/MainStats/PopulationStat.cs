using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City.Model.DataSource.MainStats
{
    public class PopulationStat
    {

        public string Name { get; set; }
        public string Value { get; set; }

        public PopulationStat(string name, string value)
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
