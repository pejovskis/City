using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using City.Model.Building;

namespace City.Model.Player
{
    public class Player
    {

        public int Id
        {
            get;
        }
        public string Name
        {
            get;
        }
        public float Capital
        {
            get;
            set;
        }
        public List<int> OwnedBuildings
        {
            get;
            set;
        }

        public Player(int id, string name, float capital)
        {
            Id = id;
            Name = name;
            Capital = capital;
            OwnedBuildings = new List<int>();
        }



        // Building Interactions
        public void BuildingBuy(Building.Building Building)
        {

            if(!Building.Sold && Building.PriceToBuy < Capital)
            {
                this.Capital -= Building.PriceToBuy; 
                Building.Owner = this.Id;
                Building.Sold = true;
                OwnedBuildings.Add(Building.Id);
            } else
            {
                if (Building.Sold)
                {
                    MessageBox.Show("The building is already sold.", "Error");
                }
                else if (Building.PriceToBuy >= this.Capital)
                {
                    MessageBox.Show("Not enough money to buy the building.", "Error");
                }
                else
                {
                    MessageBox.Show("Unknown error.", "Error");
                }
            }

        }

        public void BuildingUpgrade(Building.Building Building)
        {

            if(Building.Level < 10 && Building.Owner == this.Id && Building.PriceToUpgrade < this.Capital)
            {
                Building.UpgradeLevel();
            } else
            {
                if (Building.Level >= 10)
                {
                    MessageBox.Show("The building is already at the maximum level.", "Error");
                }
                else if (Building.Owner != this.Id)
                {
                    MessageBox.Show("You do not own this building.", "Error");
                }
                else if (Building.PriceToUpgrade >= this.Capital)
                {
                    MessageBox.Show("Not enough money to upgrade the building.", "Error");
                }
                else
                {
                    MessageBox.Show("Unknown error.", "Error");
                }
            }
            
        }

        public void BuildingPromote(Building.Building Building)
        {
            if(Capital > Building.PriceToPromote)
            {
                Capital -= Building.PriceToPromote;
                Building.TimeLastingPromotion = 100;
                Building.BruttoIncome *= 1.3f;
            }
        }

        public void BuildingRepair(Building.Building Building)
        {
            if(Building.Health < 1000 && Capital > Building.PriceToRepair)
            {
                Capital -= Building.PriceToRepair;
                Building.Health = 1000;
            }
        }

        public void BuildingEmployWorker(Building.Building Building)
        {
            if(Building.WorkersEmployed < Building.WorkerCapacity)
            {
                Building.WorkersEmployed++;
            }
        }

        public void BuildingFireWorker(Building.Building Building)
        {
            if(Building.WorkersEmployed > 1)
            {
                Building.WorkersEmployed--;
            }
        }



    }
}
