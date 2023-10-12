using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using City.Model.Building;

namespace City.Model.Robot
{
    public class Resident
    {
        // Fields

        // Personall
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int AgeMonths { get; set; }
        public float _ageYears;
        public float AgeYears
        {
            get
            {
                return _ageYears / 12;
            }

            set
            {
                _ageYears = value;                    
            }
        }
        public int Gender { get; set; } // 0 - Female, 1 - Male
        public int Iq { get; set; }
        public string Profession { get; set; } // Student 
        public float Budget { 
            get
            {
                return BruttoIncome - NettoIncome;
            }
        } // Saves NettoIncome on top. Handles the costs. If - everything rapidly down.
        public float BruttoIncome {
            get
            {
                return WorkPlace.SalarayPay();
            }
        }
        public float NettoIncome { 
            get
            {
                return BruttoIncome - CityHall.TaxRate;
            } 
        }
        public float Expenses { 
            get
            {
                int Multiplier = 10;
                return (HungerRate + ThirstRate + EducationRate + HealthRate + SocialLifeRate + ForbbidenThingsRate) * 10;
            }
        }

        // Work
        public CityHall CityHall { get; set; }
        public Building.Building WorkPlace { get; set; } 
        public bool NotAbleToWork { get; set; } = false;
        public int SicknessDuration { 
            get
            {
                int Duration = 0;
                if(NotAbleToWork)
                {
                    Duration = 1000 - Health; 
                }
                return Duration;
            }
        }


        // Needs
        public int Happiness { 
            get
            {
                int Happiness = 1000;
                Happiness -= (Hunger + Thirst + Education + Health + SocialLife + ForbbidenThings) / 6;
                return Happiness;
            }
        } 
        public int Hunger { get; set; } 
        public float HungerRate { get; set; } // use it in the calculation for food needs. Higer = more costs
        public int Thirst {  get; set; } 
        public float ThirstRate { get; set; } // use it in the calculation for thirst needs. Higer = more costs
        public int Education { get; set; } // 0 - Born
        public float EducationRate { get; set; } // use it in the calculation for education needs. Higer = less costs
        public int Health { get; set; }
        public float HealthRate { get; set; } // use it in the calculation for health needs. Higer = more costs
        public int SocialLife { get; set; } // // use it in the calculation for Social Life needs. Higer = more costs, but also happiness.
        public float SocialLifeRate { get;set; }
        public int ForbbidenThings { get; set; }
        public int ForbbidenThingsRate { get; set; } // use it in the calculation for the forbiddenThings. Higher = happier, but also higher healrth Rate

        public Resident(int id,
            string name,
            string description,
            int ageMonths,
            int gender,
            string profession,
            float hungerRate,
            float thirstRate,
            float educationRate,
            float socialLifeRate
            )
        {
            Name = name;
            Description = description;
            AgeMonths = ageMonths;
            Gender = gender;
            Profession = profession;
            HungerRate = hungerRate;
            ThirstRate = thirstRate;
            EducationRate = educationRate;
            SocialLifeRate = socialLifeRate;
        }










    }
}
