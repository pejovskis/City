﻿using System;
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
            InitalizeStockExchange();
            InitializeBuildings();
            InitializePopulation();
            InitializeRessources();
            InitializeButtons();
            MessageBox.Show("kurac", ressources.ToString());
        }

        private void InitalizeStockExchange()
        {
            stockExchange = new StockExchange(0.19f, 30f, 18f, 35f, 20f);
        }

        private void InitializePopulation() 
        {
            population = new Population(1.4f, 1.5f, 1.3f, 1.6f, 1.9f);
        }

        private void InitializeRessources() 
        {
            ressources = new Ressources(buildings, population);
        }

        private void InitializeBuildings()
        {

            buildings = new Building[]
            {
                new CityHall(0, "City Hall", 100, 58, "Hearth of the city", 50, 10000000, 60, stockExchange.TaxRate),
                new Bank(1, "City Bank", 95, 60, "Bank of the bros", 50, 1000000, 40, stockExchange.TaxRate),
                new GasStation(2, "Gas Station", 85, 50,"Fuel for the bros", 50, 750000, 10, stockExchange.TaxRate)
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
