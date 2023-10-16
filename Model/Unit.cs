using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City.Model
{
    public abstract class Unit
    {
        // Fields
        public float TaxRate { get; set; }
        public float Health { get; set; }
        public float Efficiency
        {
            get
            {
                float efficiency = 100;

                // Based on Health
                if (Health < 100)
                {
                    float difference = 100 - Health;
                    efficiency -= difference;
                }
                return efficiency;
            }
            set { }
        }

    }
}
