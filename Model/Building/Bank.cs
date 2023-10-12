namespace City.Model.Building
{
    public class Bank : Building
    {
        public Bank(int Id, string Name, int Quality, string Description, int Size, int WorkerCapacity, float PriceBuy, int BankruptTolerance, int TaxPay) : base(Id, Name, Quality, Description, Size, WorkerCapacity, PriceBuy, BankruptTolerance, TaxPay)
        {
        }
    }
}
