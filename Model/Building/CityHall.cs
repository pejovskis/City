using System.Security.Cryptography.X509Certificates;

namespace City.Model.Building
{
    public class CityHall : Building
    {

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
