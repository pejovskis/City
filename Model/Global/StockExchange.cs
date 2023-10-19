using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using City.Model.Building;

namespace City.Model.Global
{
    public class StockExchange
    {

        // Stock Exchange
        public float TaxRate { get; set; }
        public float FoodRate { get; set; }
        public float WaterRate { get; set; }
        public float ElectricityRate { get; set; }
        public float FuelRate { get; set; }
        public Building.Building Building { get; set; }

        // Constructor
        public StockExchange(float taxRate, float foodRate, float waterRate, float electricityRate, float fuelRate) 
        {
            TaxRate = taxRate;
            FoodRate = foodRate;
            WaterRate = waterRate;
            ElectricityRate = electricityRate;
            FuelRate = fuelRate;
        }

    }
}
