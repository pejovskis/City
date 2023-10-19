using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using City.Model.Building;
using City.Model.Robot;

namespace City.Model.Global
{
    public class Ressources
    {
        // Available
        public int FoodAvailable { get; set; }
        public int WaterAvailable { get; set; }
        public int ElectricityAvailable { get; set; }
        public int FuelAvailable { get; set; }
        public int EducationAvailable { get; set; }
        public int CultureAvailable { get; set; } // ToDo
        public int EmploymentAvailable { get; set; }


        // Needed
        public int FoodNeeded { get; set; }
        public int WaterNeeded { get; set; }
        public int ElectricityNeeded { get; set; }
        public int FuelNeeded { get; set; }
        public int EducationNeeded { get; set; }
        public int CultureNeeded { get; set; } // ToDo
        public int EmploymentNeeded { get; set; }

        public Ressources(Building.Building[] building, Population population)
        {
            InitRessources(building, population);
        }

        public void InitRessources(Building.Building[] building, Population population)
        {
            FoodNeeded = 0;
            WaterNeeded = 0;
            ElectricityNeeded = 0;
            FuelNeeded = 0;
            EducationNeeded = 0;
            EmploymentNeeded = 0;

            FoodAvailable = 0;
            WaterAvailable = 0;
            ElectricityAvailable = 0;
            FuelAvailable = 0;
            EducationAvailable = 0;
            EmploymentAvailable = 0;

            // Set available ressource. EmploymentNeeded is actually available places to work
            foreach (Building.Building b in building)
            {

                CalculateStartAvailableRessources(b);

                // EmploymentAvailable = p.Quantity;
                EmploymentNeeded += b.WorkerCapacity;
                ElectricityNeeded += b.EctricityNeeded;

            }

            FoodNeeded = population.Hunger;
            WaterNeeded = population.Thirst;
            FuelNeeded = population.Fuel;
            EmploymentNeeded = population.Size;
            EducationNeeded = population.Education;
            
        }

        public void CalculateStartAvailableRessources(Building.Building building)
        {
            switch (building.ProductName)
            {
                case "Food":
                    FoodAvailable += building.ProductQuantity;
                    break;
                case "Water":
                    WaterAvailable += building.ProductQuantity;
                    break;
                case "Electricity":
                    ElectricityAvailable += building.ProductQuantity;
                    break;
                case "Fuel":
                    FuelAvailable += building.ProductQuantity;
                    break;
                case "Education":
                    EducationAvailable += building.ProductQuantity;
                    break;
            }
        }

    }
}
