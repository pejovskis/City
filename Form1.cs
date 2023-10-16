using City.Model.Building;
using City.Model.Player;
using City.View.Gameplay;

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
            lblTaxPay.Text += CityHall.TaxRate + " => ";
            lblBruttoInCome.Text += CityHall.BruttoIncome + " => ";
            lblNettoInCome.Text += CityHall.NettoIncome + " => ";
            lblExpenses.Text += CityHall.Expenses + " => ";
            lblWin.Text += CityHall.NettoWin + " => ";
            lblCustomerSatisfiction.Text += CityHall.CustomerSatisfaction + " => ";
            lblRating.Text += CityHall.Rating + " => ";
            lblTimeLastingPromotion.Text += CityHall.TimeLastingPromotion + " => ";
            lblSalaryMonthly.Text += CityHall.SalaryMonhtly + " => ";

            // Player
            lblPlayerId.Text += PlayerOne.Id + " => ";
            lblPlayerName.Text += PlayerOne.Name + " => ";
            lblPlayerCapital.Text += PlayerOne.Capital.ToString() + " => ";
            if (PlayerOne.OwnedBuildings != null)
            {
                foreach (int OwnedBuilding in PlayerOne.OwnedBuildings)
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

        private void btnFrontEnd_Click(object sender, EventArgs e)
        {
            var MainWindow = new Main();
            MainWindow.Show();
        }
    }
}