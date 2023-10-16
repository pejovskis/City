namespace City.Model.Building
{
    public class Bank : Building
    {
        public Bank(int Id, 
            string Name, 
            int Quality, 
            string Description, 
            int WorkerCapacity, 
            float PriceBuy, 
            int BankruptTolerance,
            float TaxRate
            ) 
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



    }
}
