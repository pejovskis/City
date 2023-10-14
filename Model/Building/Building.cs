using System;
using City.Model.Global;

namespace City.Model.Building
{
    abstract public class Building : Unit
    {

        // Main
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Quality { get; set; } // Assuming a max of 1000 can be enforced elsewhere
        public int Owner { 
            get; 
            set; } = 0;  // Default 0. 0 = City
        public bool Sold { get; set; } = false;
        public bool InMaintenance { get; private set; } = false;
        public bool IsBankrupt { get; private set; } = false;

        // Stats
        public int Level { get; private set; } = 1;

        public int Size { get; set; }

        public int WorkerCapacity { get; set; }
        public int WorkersEmployed { get; set; }
        public float Efficiency
        {
            get
            {
                return base.Efficiency -= (WorkersEmployed / WorkerCapacity * 100);
            }
        }
        public float TimeToRepair
        {
            get
            {
                return (Health < 100) ? (Size + (100 - Health) * Level) : 0;
            }
        }
        public int TimeToUpgrade
        {
            get
            {
                return Size * (int)Quality * Level;
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
                return (Health < 100) ? (Size + Quality + (100 - Health) * Level) : 0;
            }
        }
        public float PriceToPromote { 
            get
            {

                return Size + Quality * Level ;
            }
        }
        public float PriceToSell
        {
            get
            {

                return PriceToBuy + Size + Quality * Level;
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
        // Costs
        public float CostsElectricity { 
            get
            {
                return Size * Quality * Level / Efficiency;
            }
        }
        public float CostsWater {
            get
            {
                return Size * Quality * Level / Efficiency;
            }
        }

        // Production
        public float ProductionItemQuantity
        {
            get
            {
                return Efficiency * Size * Quality;
            }
        }

        public float ProductionPiecePrice { get; set; }
        public float BruttoIncome
        {
            get
            {
                return ProductionItemQuantity * ProductionPiecePrice;
            }
        }
        public float NettoIncome
        {
            get
            {
                return BruttoIncome - BruttoIncome * TaxRate;
            }
        }
        public float Expenses
        {
            get
            {
                return SalaryMonhtly + CostsElectricity + CostsWater;
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
            float bankruptTolerance
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
            if (WorkersEmployed < WorkerCapacity)
            {
                WorkersEmployed++;
            }
        }

        public void FireWorker()
        {
            if (WorkersEmployed > 1)
            {
                WorkersEmployed--;
            }
        }

    }
}
