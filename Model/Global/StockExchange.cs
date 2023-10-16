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

        // Available
        public float FoodAvailable { get; set; }
        public float WaterAvailable { get; set; }
        public float ElectricityAvailable { get; set; }
        public float FuelAvailable { get; set; }
        public float EducationAvailable { get; set; }
        public float CultureAvailable { get; set; } // ToDo
        public float EmploymentAvailable { get; set; }


        // Needed
        public float FoodNeeded { get; set; }
        public float WaterNeeded { get; set; }
        public float ElectricityNeeded { get; set; }
        public float FuelNeeded { get; set; }
        public float EducationNeeded { get; set; }
        public float CultureNeeded { get; set; } // ToDo
        public float EmploymentNeeded { get; set; }
    }
}
