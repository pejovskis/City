using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using City.Controller;
using City.Model.Building;
using City.Model.Global;
using City.Model.Robot;

namespace City.View.Gameplay
{
    public partial class Main : Form
    {
        private Building[] buildings;
        private StockExchange stockExchange;
        private Population population;
        private Ressources ressources;

        // Constructor
        public Main()
        {
            InitializeComponent();
            InitializeUnits();
            InitializeButtons();
            InitializeStatsPanel();
        }

        private System.Windows.Forms.Timer timer1;

        private void InitializeUnits()
        {
            InitializeBuildings();
            InitalizeStockExchange();
            InitializePopulation();
            InitializeRessources();
            InitializeTime();
            //Start the Timer
            timerStart(timer1);
        }

        public void timerStart(System.Windows.Forms.Timer timer1)
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000; // Set the interval to 1000 milliseconds
            timer1.Tick += new EventHandler(Timer1_Tick); // Attach the Tick event handler
            timer1.Start(); // Start the timer
        }

        private void InitializeTime()
        {
            MainController.StartGame();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            GetGameTime(); // Call your ShowTime method

            if (buildings[0] is CityHall cityHall)
            {
                cityHall.TaxIncrease();
            }


            // GameCurrentStatusUpdate(); // TEST FUNCTION EXAMPLE
        }

        /* TEST FUNCTION EXAMPLE 
        private void GameCurrentStatusUpdate()
        {
            population.Size++;
            if(GetGameTimeStr() == "00:00:05")
            {
                MessageBox.Show("FUCK YOU", population.Size.ToString());
            }
        }
        */

        private void GetGameTime()
        {
            lblTime.Text = GetGameTimeStr();
        }

        private string GetGameTimeStr()
        {
            // Get the elapsed time as a TimeSpan value
            TimeSpan ts = MainController.gameTimeDuration.Elapsed;

            // Format and display the TimeSpan value
            // Example: "Hours:Minutes:Seconds.Milliseconds"
            return String.Format("{0:00}:{1:00}:{2:00}",
                                         ts.Hours, ts.Minutes, ts.Seconds);
        }


        private void InitalizeStockExchange()
        {
            stockExchange = new StockExchange(buildings, 30f, 18f, 35f, 20f);
        }

        private void InitializePopulation()
        {
            population = new Population(100, 1.4f, 1.5f, 1.3f, 1.6f, 1.9f);
        }

        private void InitializeRessources()
        {
            ressources = new Ressources(buildings, population);
        }

        private void InitializeBuildings()
        {

            buildings = new Building[]
            {
                new CityHall(0, "City Hall", 100, 58, "Hearth of the city", 50, 10000000, 60, 0.19f),
                new Bank(1, "City Bank", 95, 60, "Bank of the bros", 50, 1000000, 40, 0.19f),
                new GasStation(2, "Gas Station", 85, 50,"Fuel for the bros", 50, 750000, 10, 0.19f)
            };

        }

        private void InitializeButtons()
        {
            btnCityHall.Click += (sender, e) => DisplayStats(buildings[0]); // Display stats for the first building
            btnBank.Click += (sender, e) => DisplayStats(buildings[1]);
            btnGasStation.Click += (sender, e) => DisplayStats(buildings[2]);
        }

        private void DisplayStats(Building building)
        {
            BuildingStatus buildingStatus = new BuildingStatus(building);
            buildingStatus.Show();
        }

        private void InitializeStatsPanel()
        {
            MainController.InitializeStatsPanel(lbPopulationStats, lbRessourcesStats, lbStockExchangeStats, population, ressources, stockExchange);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBoxNotifications_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbStockExchangeStats_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
