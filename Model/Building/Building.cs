using System;

namespace City.Model.Building
{
    abstract public class Building
    {

        // Main
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quality { get; set; } // Assuming a max of 1000 can be enforced elsewhere
        public string Description { get; set; }
        public int Owner { 
            get; 
            set; } = 0;  // Default 0. 0 = City
        public bool Sold { get; set; } = false;
        public bool InMaintenance { get; private set; } = false;
        public bool IsBankrupt { get; private set; } = false;

        // Stats
        public int Level { get; private set; } = 1;
        public int Size { get; set; } // Assuming a max of 1000 can be enforced elsewhere
        public int WorkerCapacity { get; set; }
        public int WorkersEmployed { get; private set; }
        public int Health { get; private set; } = 1000;
        public int Efficiency
        {
            get
            {
                int efficiency = 1000;

                if (this.Health < 1000)
                {
                    int difference = 1000 - this.Health;
                    efficiency -= (int)(difference * (1 + this.Level / 10));
                }

                return efficiency;
            }
        }

        public int TimeToRepair
        {
            get
            {
                int TimeToRepair = 0;

                int Narrower = 100;

                if (this.Health < 1000)
                {
                    int Difference = 1000 - this.Health;
                    TimeToRepair = (this.Size + Difference + this.Quality) * this.Level / Narrower;
                }



                return TimeToRepair;
            }
        }
        public int TimeToUpgrade
        {
            get
            {
                int Narrower = 30;
                int TimeToUpgrade = (this.Size + this.Quality) * this.Level / Narrower;

                return TimeToUpgrade;
            }
        }

        // Price
        public float PriceToBuy { get; set; }
        public int BankruptTolerance { get; set; }
        public float PriceToUpgrade { 
            get
            {
                float PriceToUpgrade = this.PriceToBuy + (this.PriceToBuy / 3) * this.Level;

                return PriceToUpgrade;
            }
        }
        public float PriceToRepair { 
            get
            {
                float PriceToRepair = 0;
                int narrower = 100;

                if (this.Health < 1000)
                {

                    int Difference = 1000 - this.Health;

                    PriceToRepair += (this.Size + this.Quality + Difference) * this.Level / narrower;

                }

                return PriceToRepair;
            }
        }
        public float PriceToPromote { 
            get
            {
                int Narrower = 100;
                float PriceToPromote = (this.Size + this.Quality) * this.Level / Narrower;

                return PriceToPromote;
            }
        }
        public float PriceToSell
        {
            get
            {
                float PriceToSell = 0;
                int Narrower = 10;

                PriceToSell = (this.PriceToBuy + this.Size + this.Quality) * this.Level / Narrower;

                return PriceToSell;
            }
        }

        // Costs
        public int TaxPay { get; private set; } = 190;
        public float BruttoIncome
        {
            get
            {
                float BruttoIncome = 0;

                return BruttoIncome;
            }
        }
        public float NettoIncome
        {
            get
            {
                float NettoIncome = 0;

                return NettoIncome;
            }
        }
        public float Expenses
        {
            get
            {
                float Expenses = 0;

                return Expenses;
            }
        }
        public float Win
        {
            get
            {
                float Win = 0;

                return Win;
            }
        }

        // Social
        public int CustomerSatisfaction { get; private set; } = 1000;
        public int Rating { get; private set; } = 1000;



        public Building(
            int id,
            string name,
            int quality,
            string description,
            int size,
            int workerCapacity,
            float priceToBuy,
            int bankruptTolerance,
            int taxPay
        )
        {
            // Manual Constructor
            Id = id;
            Name = name;
            Quality = quality;
            Description = description;
            Size = size;
            WorkerCapacity = workerCapacity;
            WorkersEmployed = WorkerCapacity;  // Assuming this should always match initially
            PriceToBuy = priceToBuy;
            BankruptTolerance = bankruptTolerance;
            TaxPay = taxPay;
        }


        // Interactions
        public void UpgradeLevel()
        {
            this.Level++;
        }

    }
}
