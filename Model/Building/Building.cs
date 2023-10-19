using System;
using City.Model.Global;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        public bool _inMaintenance = false;
        public bool InMaintenance { 
            get
            {
                if(Health < 50 || IsBankrupt)
                {
                    return true;
                }
                return _inMaintenance;
            } 
            set
            {
                _inMaintenance = value;
            }
        }
        public bool IsBankrupt { 
            get
            {
                if(BruttoIncome < Expenses)
                {
                    return true;
                }
                return false;
            } 
        }
        public string ProductName { get; set; }

        // Stats
        public int Level { get; set; } = 1;
        public int _size;

        public int Size { 
            get
            {
                if(Level > 1)
                {
                    Size *= Level;
                }
                return _size;
            } 
            set { _size = value; }
        }

        public int _workerCapacity;
        public int WorkerCapacity { 
            get
            {
                if(Level > 1)
                {
                    return (int)Math.Floor(Size / Quality);
                }
                return _workerCapacity;
            }
        }
        public int WorkersEmployed { get; set; }
        public float Efficiency
        {
            get
            {
                return base.Efficiency -= (WorkersEmployed / WorkerCapacity * 100);
            }
            set
            {
                base.Efficiency = value;
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
        public int TimeLastingPromotion { 
            get
            {
                return (int)(Level * Size * Quality);
            }  
            set
            {

            }
        }
        public bool IsPromoted { get; set; } = false;

        // Price
        public float _priceToBuy;
        public float PriceToBuy { 
            get
            {
                if(Owner != 0)
                {
                    if(Health < 100)
                    {
                        return _priceToBuy - (100 - Health) * _priceToBuy / 100;
                    }
                    
                }

                return _priceToBuy;
                
            } 
            set
            {
                
            }
        }

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

        // Salary
        private float _salaryMonthlyBacking;

        public float SalaryMonhtly
        {
            get
            {
                //return (_salaryMonthlyBacking * WorkersEmployed * Quality * Level) / 100;
                return _salaryMonthlyBacking;
            }
            set
            {
                _salaryMonthlyBacking = value;
            }
        }

        // Costs
        public int EctricityNeeded { 
            get
            {
                return (int)(Size * Quality * Level / Efficiency);
            }
        }
        public int WaterNeeded {
            get
            {
                return (int)(Size * Quality * Level / Efficiency);
            }
        }

        // Production
        public float ProductQuantityMax
        {
            get
            {
                return Efficiency * Size * Quality * WorkerCapacity;
            }
        }
        public float ProductQuantityRate { get; set; }
        public int ProductQuantity { get; set; }
        public float ProductBruttoPrice { get; set; }
        public float BruttoIncome
        {
            get
            {
                return ProductQuantity * ProductBruttoPrice;
            }
            set { }
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
                return SalaryMonhtly + EctricityNeeded + WaterNeeded;
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
            int size,
            string description,
            int _workerCapacity,
            float priceToBuy,
            float bankruptTolerance,
            float taxRate
        )
        {
            // Manual Constructor
            Id = id;
            Name = name;
            Quality = quality;
            Size = size;
            Description = description;
            this._workerCapacity = _workerCapacity;
            WorkersEmployed = WorkerCapacity;  // Assuming this should always match initially
            PriceToBuy = priceToBuy;
            BankruptTolerance = bankruptTolerance;
            TaxRate = taxRate;
        }


        // Interactions
        public void StartPromotion()
        {
            Efficiency = 100;
        }

        public void EndPromotion()
        {

        }

        public void StartRepair()
        {
            _inMaintenance = true;
            // Wait (TimeToRepair); add in server logic
            EndRepair();
        }

        public void EndRepair()
        {
            _inMaintenance = false;
            SetHealthMax();
        }

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

        public void SetHealthMax()
        {
            Health = 100;
        }

    }
}
