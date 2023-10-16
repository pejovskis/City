using System.Security.Cryptography.X509Certificates;

namespace City.Model.Building
{
    public class CityHall : Building
    {

        //Constructor
        public CityHall(int Id, 
            string Name, 
            float Quality, 
            string Description, 
            int WorkerCapacity, 
            float PriceBuy, 
            float BankruptTolerance,
            float TaxRate)

            : base(Id, 
                  Name, 
                  Quality, 
                  Description, 
                  WorkerCapacity, 
                  PriceBuy, 
                  BankruptTolerance,
                  TaxRate)
        {
            
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
