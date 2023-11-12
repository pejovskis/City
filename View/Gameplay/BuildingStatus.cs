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
using City.Model.DataSource.BuildingStatus;
using City.Model.Global;

namespace City.View.Gameplay
{
    public partial class BuildingStatus : Form
    {

        private Building _currentBuilding;
        private Building Building;
        //private List<Label> labels;

        // Constructor
        public BuildingStatus(Building building)
        {
            InitializeComponent();
            this.Building = building;
            DisplayStats(building);

        }

        private void DisplayStats(Building building)
        {
            BindingList<BuildingStatusStat> buildinglist = new BindingList<BuildingStatusStat> { };

            buildinglist.Add(new BuildingStatusStat("Id", building.Id.ToString()));
            buildinglist.Add(new BuildingStatusStat("Name", building.Name));
            buildinglist.Add(new BuildingStatusStat("Quality", building.Quality.ToString()));
            buildinglist.Add(new BuildingStatusStat("Description", building.Description));
            buildinglist.Add(new BuildingStatusStat("Owner", building.Owner.ToString()));
            buildinglist.Add(new BuildingStatusStat("Sold", building.Sold.ToString()));
            buildinglist.Add(new BuildingStatusStat("Maintenance", building.InMaintenance.ToString()));
            buildinglist.Add(new BuildingStatusStat("Bankrupt", building.IsBankrupt.ToString()));
            buildinglist.Add(new BuildingStatusStat("Level", building.Level.ToString()));
            buildinglist.Add(new BuildingStatusStat("Size", building.Size.ToString()));
            buildinglist.Add(new BuildingStatusStat("Capacity", building.WorkerCapacity.ToString()));
            buildinglist.Add(new BuildingStatusStat("Workers Employed", building.WorkersEmployed.ToString()));
            buildinglist.Add(new BuildingStatusStat("Health", building.Health.ToString()));
            buildinglist.Add(new BuildingStatusStat("Efficiency", building.Efficiency.ToString()));
            buildinglist.Add(new BuildingStatusStat("Repair Time", building.TimeToRepair.ToString()));
            buildinglist.Add(new BuildingStatusStat("Time to Upgrade", building.TimeToUpgrade.ToString()));
            buildinglist.Add(new BuildingStatusStat("Price to Buy", building.PriceToBuy.ToString()));
            buildinglist.Add(new BuildingStatusStat("Bankrupt Tolerance", building.BankruptTolerance.ToString()));
            buildinglist.Add(new BuildingStatusStat("Price to Upgrade", building.PriceToUpgrade.ToString()));
            buildinglist.Add(new BuildingStatusStat("Price to Repair", building.PriceToRepair.ToString()));
            buildinglist.Add(new BuildingStatusStat("Price to Promote", building.PriceToPromote.ToString()));
            buildinglist.Add(new BuildingStatusStat("Tax Rate", building.TaxRate.ToString()));
            buildinglist.Add(new BuildingStatusStat("Brutto Income", building.BruttoIncome.ToString()));
            buildinglist.Add(new BuildingStatusStat("Netto Income", building.NettoIncome.ToString()));
            buildinglist.Add(new BuildingStatusStat("Expenses", building.Expenses.ToString()));
            buildinglist.Add(new BuildingStatusStat("Netto Win", building.NettoWin.ToString()));
            buildinglist.Add(new BuildingStatusStat("Customer Satisfaction", building.CustomerSatisfaction.ToString()));
            buildinglist.Add(new BuildingStatusStat("Rating", building.Rating.ToString()));
            buildinglist.Add(new BuildingStatusStat("Time Lasting Promotion", building.TimeLastingPromotion.ToString()));
            buildinglist.Add(new BuildingStatusStat("Monthly Salary", building.SalaryMonhtly.ToString()));

            lbBuildingStats.DataSource = buildinglist;
        }

        private void inWorkersEmployed_ValueChanged(object sender, EventArgs e)
        {
            BuildingStatusController.WorkersEmployedChange(Building, inWorkersEmployed);
        }

        private void inSalaryMonthly_ValueChanged(object sender, EventArgs e)
        {
            BuildingStatusController.SalaryMonthlyChange(Building, inSalaryMonthly);
        }

        private void BuildingStatus_Load(object sender, EventArgs e)
        {

        }

        public void SetBuilding(Building building)
        {
            if (_currentBuilding != null)
            {
                _currentBuilding.PropertyChanged -= Building_PropertyChanged;
            }

            _currentBuilding = building;
            _currentBuilding.PropertyChanged += Building_PropertyChanged;

            DisplayStats(building);
        }

        private void Building_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            DisplayStats(_currentBuilding);
        }

    }

}
