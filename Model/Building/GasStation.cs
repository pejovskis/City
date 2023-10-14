namespace City.Model.Building
{
    public class GasStation : Building
    {

       

        public GasStation(int id, 
            string name, 
            float quality, 
            string description, 
            int workerCapacity, 
            float priceToBuy, 
            float bankruptTolerance) 
            : 
            base(id, 
                name, 
                quality, 
                description, 
                workerCapacity, 
                priceToBuy, 
                bankruptTolerance
                )
        {

        }

    }
}
