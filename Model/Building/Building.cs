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
        private int _size;  // Backing field 

        public int Size
        {
            get
            {
                return _size * Level;
            }
            set  // Optional, if you need to set Size from outside or within the class
            {
                _size = 100;  // Here, you can add additional logic, like enforcing a max value if needed.
            }
        }

        public int WorkerCapacity { get; set; }
        public int WorkersEmployed { get; set; }
        public int Health { get; set; } = 1000;
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
        public int TimeLastingPromotion { get; set; }

        // Price
        private float _priceToBuy;  // backing field
        public float PriceToBuy
        {
            get
            {
                if (Level > 1)
                {
                    return _priceToBuy + PriceToRepair;
                }
                return _priceToBuy;
            }
            private set
            {
                _priceToBuy = value;
            }
        }

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
        public int TaxRate { get; private set; } = 190;
        public float BruttoIncome
        {
            get;
            set;
        }
        public float NettoIncome
        {
            get
            {
                float TaxToPay = BruttoIncome * (TaxRate / 100);

                float NettoIncome = BruttoIncome - TaxToPay;

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
        public float NettoWin
        {
            get
            {
                float TaxToPay = NettoIncome * (TaxRate / 100);

                float Win = NettoIncome - Expenses - TaxToPay;

                return Win;
            }
        }

        // Social
        public int CustomerSatisfaction { get; set; } = 1000;
        public int Rating { get; set; } = 1000;



        public Building(
            int id,
            string name,
            int quality,
            string description,
            int workerCapacity,
            float priceToBuy,
            int bankruptTolerance,
            int taxRate
        )
        {
            // Manual Constructor
            Id = id;
            Name = name;
            Quality = quality;
            Description = description;
            WorkerCapacity = workerCapacity;
            WorkersEmployed = WorkerCapacity;  // Assuming this should always match initially
            PriceToBuy = priceToBuy;
            BankruptTolerance = bankruptTolerance;
            TaxRate = taxRate;
        }


        // Interactions
        public void UpgradeLevel()
        {
            this.Level++;
        }

    }
}
