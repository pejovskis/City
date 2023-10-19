using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using City.Controller;
using City.Controller.BuildingController;
using City.Model.Building;
using City.Model.Global;

namespace City.View.Gameplay
{
    public partial class BuildingStatus : Form
    {

        private Building Building;
        //private List<Label> labels;

        // Constructor
        public BuildingStatus(Building building)
        {
            InitializeComponent();
            this.Building = building;
            DisplayStats(building);

            // Labels Init
            //this.labels = new List<Label>();

            // Auto labels add
            //foreach (Control c in this.Controls)
            //{
            //    if (c is Label)
            //    {
            //        labels.Add((Label)c);
            //    }
            //}

        }

        private void DisplayStats(Building building)
        {
            // Building
            lblId.Text = "Id: " + building.Id.ToString();
            lblName.Text = "Name: " + building.Name;
            lblQuality.Text = "Quality: " + building.Quality.ToString();
            lblDescription.Text = "Description: " + building.Description;
            lblOwner.Text = "Owner: " + building.Owner.ToString();
            lblSold.Text = "Sold: " + building.Sold.ToString();
            lblInMaintenance.Text = "Maintenance: " + building.InMaintenance.ToString();
            lblIsBankrupt.Text = "Bankrupt: " + building.IsBankrupt.ToString();
            lblLevel.Text = "Level: " + building.Level.ToString();
            lblSize.Text = "Size: " + building.Size.ToString();
            lblWorkerCapacity.Text = "Capacity: " + building.WorkerCapacity.ToString();
            lblWorkersEmployed.Text = "Workers employed: " + building.WorkersEmployed.ToString();
            inWorkersEmployed.Value = building.WorkersEmployed;
            lblHealth.Text = "Heatlh: " + building.Health.ToString();
            lblEfficiency.Text = "Efficiency: " + building.Efficiency.ToString();
            lblTimeToRepair.Text = "Repair: " + building.TimeToRepair.ToString();
            lblTimeToUpgrade.Text = "Time to upgrade: " + building.TimeToUpgrade.ToString();
            lblPriceBuy.Text = "Price to buy: " + building.PriceToBuy.ToString();
            lblBankruptTolerance.Text = "Bankrupt tolerance: " + building.BankruptTolerance.ToString();
            lblPriceToUpgrade.Text = "Price to upgrade: " + building.PriceToUpgrade.ToString();
            lblPriceRepair.Text = "Price to repair: " + building.PriceToRepair.ToString();
            lblPricePromote.Text = "Price to promote: " + building.PriceToPromote.ToString();
            lblTaxPay.Text = "Tax to pay: " + building.TaxRate.ToString();
            lblBruttoInCome.Text = "Brutto income: " + building.BruttoIncome.ToString();
            lblNettoInCome.Text = "Netto income: " + building.NettoIncome.ToString();
            lblExpenses.Text = "Expenses: " + building.Expenses.ToString();
            lblWin.Text = "Win: " + building.NettoWin.ToString();
            lblCustomerSatisfiction.Text = "Customer satisfaction: " + building.CustomerSatisfaction.ToString();
            lblRating.Text = "Rating: " + building.Rating.ToString();
            lblTimeLastingPromotion.Text = "Time lasting promotion: " + building.TimeLastingPromotion.ToString();
            lblSalaryMonthly.Text = "Monthly Salary: ";
            inSalaryMonthly.Value = Convert.ToInt32(building.SalaryMonhtly);
        }

        private void inWorkersEmployed_ValueChanged(object sender, EventArgs e)
        {
            BuildingStatusController.WorkersEmployedChange(Building, inWorkersEmployed, lblWorkersEmployed);
        }

        private void inSalaryMonthly_ValueChanged(object sender, EventArgs e)
        {
            BuildingStatusController.SalaryMonthlyChange(Building, inSalaryMonthly, lblSalaryMonthly);
        }
    }

}
