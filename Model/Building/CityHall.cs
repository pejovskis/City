using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace City.Model.Building
{
    public class CityHall : Building
    {

        private float taxRate;
        public float TaxRate
        {
            get { return taxRate; }
            set
            {
                if (taxRate != value)
                {
                    taxRate = value;
                    OnPropertyChanged(nameof(TaxRate)); // Assuming OnPropertyChanged is implemented in Unit
                }
            }
        }

        //Constructor
        public CityHall(int Id, 
            string Name, 
            float Quality, 
            int Size,
            string Description, 
            int WorkerCapacity, 
            float PriceBuy, 
            float BankruptTolerance,
            float TaxRate)

            : base(Id, 
                  Name, 
                  Quality, 
                  Size,
                  Description, 
                  WorkerCapacity, 
                  PriceBuy, 
                  BankruptTolerance)
        {
            this.TaxRate = TaxRate;
        }

        public void TaxIncrease()
        {
            TaxRate++;
        }

        public void TaxDecrease() 
        {
            TaxRate--;
        }

    }
}
