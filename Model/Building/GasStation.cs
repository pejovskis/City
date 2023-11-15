namespace City.Model.Building
{
    public class GasStation : Building
    {
        public GasStation(int id, string name, float quality, int size, string description, int _workerCapacity, float priceToBuy, float bankruptTolerance) : base(id, name, quality, size, description, _workerCapacity, priceToBuy, bankruptTolerance)
        {
        }
    }
}
