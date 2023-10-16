using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using City.Model.Building;
using City.Model.Global;

namespace City.View.Gameplay
{
    public partial class Main : Form
    {
        private Building[] buildings; // Assuming you have an array of buildings

        // Constructor
        public Main()
        {
            InitializeComponent();
            InitializeBuildings();
            InitializeButtons();
        }

        private void InitializeBuildings()
        {
            StockExchange StockExchange = new StockExchange(0.19f, 30f, 18f, 35f, 20f);
            buildings = new Building[]
            {
                new CityHall(0, "City Hall", 100, "Hearth of the city", 50, 10000000, 60, StockExchange.TaxRate),
                new Bank(1, "City Bank", 95, "Bank of the bros", 50, 1000000, 40, StockExchange.TaxRate),
            };
        }

        private void InitializeButtons()
        {
            btnCityHall.Click += (sender, e) => DisplayStats(buildings[0]); // Display stats for the first building
            btnBank.Click += (sender, e) => DisplayStats(buildings[1]); // Display stats for the second building
        }

        private void DisplayStats(Building building)
        {
            BuildingStatus buildingStatus = new BuildingStatus(building);
            buildingStatus.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
