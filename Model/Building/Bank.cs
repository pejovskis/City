namespace City.Model.Building
{
    public class Bank : Building
    {
        public Bank(int Id, 
            string Name, 
            int Quality, 
            int Size,
            string Description, 
            int WorkerCapacity, 
            float PriceBuy, 
            int BankruptTolerance
            ) 
            : base(Id, 
                  Name, 
                  Quality, 
                  Size,
                  Description, 
                  WorkerCapacity, 
                  PriceBuy, 
                  BankruptTolerance)
        {
        }



    }
}
