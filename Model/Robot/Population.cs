using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using City.Model.Building;

namespace City.Model.Robot
{
    public class Population : Unit
    {
        // Fields

        // Professional
        public float Budget { 
            get
            {
                return BruttoIncome - NettoIncome;
            }
        } // Saves NettoIncome on top. Handles the costs. If - everything rapidly down.
        public float Efficiency
        {
            get
            {
                return base.Efficiency - (Happiness < 100 ? (100 - Happiness) : 0);
            }
        }
        public Building.Building Building { get; set; }
        public float BruttoIncome {
            get
            {
                return Building.SalarayPay();
            }
        }
        public float NettoIncome { 
            get
            {
                return BruttoIncome - TaxRate;
            } 
        }

        // Costs
        public float Expenses { 
            get
            {
                return HungerRate + ThirstRate + EducationRate + HealthRate + SocialLifeRate + ForbbidenThingsRate + FuelRate;
            }
        }


        // Needs
        public float Happiness { 
            get
            {
                return Hunger + Thirst + Education + Health + SocialLife + ForbbidenThings / 6;
            }
        } 
        public float Hunger { get; set; } 
        public float HungerRate { get; set; } // use it in the calculation for food needs. Higer = more costs
        public float Thirst {  get; set; } 
        public float ThirstRate { get; set; } // use it in the calculation for thirst needs. Higer = more costs
        public float Education { get; set; } // 0 - Born
        public float EducationRate { get; set; } // use it in the calculation for education needs. Higer = less costs
        public float HealthRate { get; set; } // use it in the calculation for health needs. Higer = more costs
        public float SocialLife { get; set; } // // use it in the calculation for Social Life needs. Higer = more costs, but also happiness.
        public float SocialLifeRate { get;set; }
        public float ForbbidenThings { get; set; }
        public float ForbbidenThingsRate { get; set; } // use it in the calculation for the forbiddenThings. Higher = happier, but also higher healrth Rate
        public float FuelAvailable { get; set; }
        public float FuelRate {  get; set; }

        public Population(
            float hungerRate,
            float thirstRate,
            float educationRate,
            float socialLifeRate,
            float fuelRate
            )
        {
            HungerRate = hungerRate;
            ThirstRate = thirstRate;
            EducationRate = educationRate;
            SocialLifeRate = socialLifeRate;
            FuelRate = fuelRate;
        }










    }
}
