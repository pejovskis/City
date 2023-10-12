using City.Model.Building;
using City.Model.Player;

namespace City
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Building CityHall = new CityHall(1, "City Hall", 800, "Hearth of the City", 300, 30, 150, 650, 190);
            Player PlayerOne = new Player(1, "Player One", 1000);

            // Label Init
            lblInit(CityHall, PlayerOne);

            PlayerOne.BuildingBuy(CityHall);
            PlayerOne.BuildingUpgrade(CityHall);

            lblInit(CityHall, PlayerOne);
        }

        public void lblInit(Building CityHall, Player PlayerOne)
        {
            // Building
            lblId.Text += CityHall.Id.ToString() + " => ";
            lblName.Text += CityHall.Name + " => ";
            lblQuality.Text += CityHall.Quality + " => ";
            lblDescription.Text += CityHall.Description + " => ";
            lblOwner.Text += CityHall.Owner + " => ";
            lblSold.Text += CityHall.Sold + " => ";
            lblInMaintenance.Text += CityHall.InMaintenance + " => ";
            lblIsBankrupt.Text += CityHall.IsBankrupt + " => ";
            lblLevel.Text += CityHall.Level + " => ";
            lblSize.Text += CityHall.Size + " => ";
            lblWorkerCapacity.Text += CityHall.WorkerCapacity + " => ";
            lblWorkersEmployed.Text += CityHall.WorkersEmployed + " => ";
            lblHealth.Text += CityHall.Health + " => ";
            lblEfficiency.Text += CityHall.Efficiency + " => ";
            lblTimeToRepair.Text += CityHall.TimeToRepair.ToString() + " => ";
            lblTimeToUpgrade.Text += CityHall.TimeToUpgrade + " => ";
            lblPriceBuy.Text += CityHall.PriceToBuy + " => ";
            lblBankruptTolerance.Text += CityHall.BankruptTolerance + " => ";
            lblPriceToUpgrade.Text += CityHall.PriceToUpgrade + " => ";
            lblPriceRepair.Text += CityHall.PriceToRepair + " => ";
            lblPricePromote.Text += CityHall.PriceToPromote + " => ";
            lblPriceSell.Text += CityHall.PriceToSell + " => ";
            lblTaxPay.Text += CityHall.TaxPay + " => ";
            lblBruttoInCome.Text += CityHall.BruttoIncome + " => ";
            lblNettoInCome.Text += CityHall.NettoIncome + " => ";
            lblExpenses.Text += CityHall.Expenses + " => ";
            lblWin.Text += CityHall.Win + " => ";
            lblCustomerSatisfiction.Text += CityHall.CustomerSatisfaction + " => ";
            lblRating.Text += CityHall.Rating + " => ";

            // Player
            lblPlayerId.Text += PlayerOne.GetId() + " => ";
            lblPlayerName.Text += PlayerOne.GetName() + " => ";
            lblPlayerCapital.Text += PlayerOne.GetCapital().ToString() + " => ";
            if(PlayerOne.GetOwnedBuildings() != null)
            {
                foreach (int OwnedBuilding in PlayerOne.GetOwnedBuildings())
                {
                    lblPlayerBuildings.Text += OwnedBuilding.ToString() + ", ";
                }
            }
        }

        private void lblTimeToUpgrade_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblWorkerCapacity_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}