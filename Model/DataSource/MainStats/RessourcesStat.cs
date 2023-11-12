using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City.Model.DataSource.MainStats
{
    public class RessourcesStat
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public RessourcesStat(string name, string value)
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
