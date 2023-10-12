namespace City.Model.Building
{
    public class Bank : Building
    {
        public Bank(int Id, string Name, int Quality, string Description, int WorkerCapacity, float PriceBuy, int BankruptTolerance, int TaxPay) : base(Id, Name, Quality, Description, WorkerCapacity, PriceBuy, BankruptTolerance, TaxPay)
        {
        }
    }
}
