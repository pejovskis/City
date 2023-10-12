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

        private int Id;
        private string Name;
        private float Capital;
        private List<int> OwnedBuildings;

        public Player(int Id, string Name, float Capital)
        {
            this.Id = Id;
            this.Name = Name;
            this.Capital = Capital;
            this.OwnedBuildings = new List<int>();
        }



        // Building Interactions
        public void BuildingBuy(Building.Building Building)
        {
            // Variable Init
            bool Sold = Building.Sold;
            float BuildingBuyPrice = Building.PriceToBuy;
            int BuildingId = Building.Id; 

            if(!Sold && BuildingBuyPrice < this.Capital)
            {
                this.Capital -= BuildingBuyPrice; 
                Building.Owner = this.Id;
                Building.Sold = true;
                SetOwnedBuildings(BuildingId);
            } else
            {
                if (Sold)
                {
                    MessageBox.Show("The building is already sold.", "Error");
                }
                else if (BuildingBuyPrice >= this.Capital)
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
            int BuildingOwner = Building.Owner;
            float BuildingPriceToUpgrade = Building.PriceToUpgrade;
            int BuildingLevel = Building.Level;

            if(BuildingLevel < 10 && BuildingOwner == this.Id && BuildingPriceToUpgrade < this.Capital)
            {
                Building.UpgradeLevel();
            } else
            {
                if (BuildingLevel >= 10)
                {
                    MessageBox.Show("The building is already at the maximum level.", "Error");
                }
                else if (BuildingOwner != this.Id)
                {
                    MessageBox.Show("You do not own this building.", "Error");
                }
                else if (BuildingPriceToUpgrade >= this.Capital)
                {
                    MessageBox.Show("Not enough money to upgrade the building.", "Error");
                }
                else
                {
                    MessageBox.Show("Unknown error.", "Error");
                }
            }
            
        }



        // Getter & Setter
        public int GetId()
        {
            return this.Id;
        }

        public void SetId(int Id)
        {
            this.Id = Id;
        }

        public string GetName()
        {
            return this.Name;
        }

        public void SetName(string Name)
        {
            this.Name = Name;
        }

        public float GetCapital()
        {
            return this.Capital;
        }

        public void SetCapital(float Capital)
        {
            this.Capital = Capital;
        }

        public List<int> GetOwnedBuildings()
        {
            return this.OwnedBuildings;
        }

        public void SetOwnedBuildings(int NewBuilding)
        {
            this.OwnedBuildings.Add(NewBuilding);
        }

    }
}
