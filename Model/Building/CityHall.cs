namespace City.Model.Building
{
    internal class CityHall : Building
    {

        //Constructor
        public CityHall(int Id, 
            string Name, 
            int Quality, 
            string Description, 
            int WorkerCapacity, 
            float PriceBuy, 
            int BankruptTolerance, 
            int TaxPay)

            : base(Id, 
                  Name, 
                  Quality, 
                  Description, 
                  WorkerCapacity, 
                  PriceBuy, 
                  BankruptTolerance, 
                  TaxPay)
        {


            
        }
    }
}
