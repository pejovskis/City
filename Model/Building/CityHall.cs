namespace City.Model.Building
{
    public class CityHall : Building
    {

        //Constructor
        public CityHall(int Id, 
            string Name, 
            int Quality, 
            string Description, 
            int WorkerCapacity, 
            float PriceBuy, 
            int BankruptTolerance, 
            int TaxRate)

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
