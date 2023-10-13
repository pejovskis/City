using System;

namespace City.Model.Building
{
    abstract public class Building
    {

        // Main
        public int Id { get; set; }
        public string Name { get; set; }
        public float Quality { get; set; } // Assuming a max of 1000 can be enforced elsewhere
        public string Description { get; set; }
        public int Owner { 
            get; 
            set; } = 0;  // Default 0. 0 = City
        public bool Sold { get; set; } = false;
        public bool InMaintenance { get; private set; } = false;
        public bool IsBankrupt { get; private set; } = false;
        public float IncomeBase { get; set; }
        public float OutcomeBase { get; set; }

        // Stats
        public int Level { get; private set; } = 1;

        public int Size { get; set; }

        public int WorkerCapacity { get; set; }
        public int WorkersEmployed { get; set; }
        public float Health { get; set; } = 100;
        public float Efficiency
        {
            get
            {
                float efficiency = 100;

                if (this.Health < 100)
                {
                    float difference = 100 - this.Health;
                    efficiency -= (difference * (1 + this.Level / 10));
                }

                efficiency = efficiency - (WorkersEmployed / WorkerCapacity * 100); 

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
        public float PriceToBuy { get; set; }

        public float BankruptTolerance { get; set; }
        public float PriceToUpgrade { 
            get
            {
                return PriceToBuy + (PriceToBuy / 3) * Level;
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
                int Narrower = 10;

                float priceToSell = (this.PriceToBuy + this.Size + this.Quality) * this.Level / Narrower;

                return priceToSell;
            }
        }

        // Salary
        public float SalaryMonhtly
        {

            get
            {
                int Narrower = 400;

                return (WorkersEmployed * Quality * Efficiency * Level) / Narrower;
            }
        }

        public float TaxPay
        {
            get
            {
                return (BruttoIncome * TaxRate) + (SalaryMonhtly * TaxRate);
            }
        }

        // Costs
        public float TaxRate { get; set; }
        public float BruttoIncome
        {
            get
            {
                return (IncomeBase * Level * Quality * Efficiency);
            }
            set { }
        }
        public float NettoIncome
        {
            get
            {
                return BruttoIncome - BruttoIncome * 0.19f;
            }
        }
        public float Expenses
        {
            get
            {
                int Multiplicator = 50; // 50 %
                float Expenses = 0;

                Expenses += SalaryMonhtly + TaxPay;

                return Expenses;
            }
        }
        public float NettoWin
        {
            get
            {
                return NettoIncome - Expenses;
            }
        }

        // Social
        public float CustomerSatisfaction { get; set; } = 100;
        public float Rating { get; set; } = 100;



        public Building(
            int id,
            string name,
            float quality,
            string description,
            int workerCapacity,
            float priceToBuy,
            float bankruptTolerance,
            float taxRate,
            float incomeBase,
            float outcomeBase
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
            IncomeBase = incomeBase;
            OutcomeBase = outcomeBase;
            TaxRate = 0.19f;
        }


        // Interactions
        public void UpgradeLevel()
        {
            this.Level++;
        }
        public float SalarayPay()
        {
            return Expenses / WorkersEmployed;
        }

        public void EmployWorker()
        {
            WorkersEmployed++;
        }

        public void FireWorker()
        {
            WorkersEmployed--;
        }

    }
}
