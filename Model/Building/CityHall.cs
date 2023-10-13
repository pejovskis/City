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
            float TaxRate,
            float IncomeBase,
            float OutcomeBase)

            : base(Id, 
                  Name, 
                  Quality, 
                  Description, 
                  WorkerCapacity, 
                  PriceBuy, 
                  BankruptTolerance, 
                  TaxRate,
                  IncomeBase,
                  OutcomeBase)
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
