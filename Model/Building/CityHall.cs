namespace City.Model.Building
{
    internal class CityHall : Building
    {

        //Constructor
        public CityHall(int Id, 
            string Name, 
            int Quality, 
            string Description, 
            int Size, 
            int WorkerCapacity, 
            float PriceBuy, 
            int BankruptTolerance, 
            int TaxPay)

            : base(Id, 
                  Name, 
                  Quality, 
                  Description, 
                  Size, 
                  WorkerCapacity, 
                  PriceBuy, 
                  BankruptTolerance, 
                  TaxPay)
        {


            
        }
    }
}
