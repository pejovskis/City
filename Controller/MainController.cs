using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using City.Model.Building;
using City.Model.Global;
using City.Model.Robot;

namespace City.Controller
{
    public class MainController
    {
        public static void InitializeStatsPanel(ListBox lbPopulationStats, ListBox lbRessourcesStats, ListBox lbStockExchangeStats, Population population, Ressources ressources, StockExchange stockExchange, StockExchange worldStockExchange)
        {
            lbPopulationStats.Items.Clear();
            lbPopulationStats.Items.Add("population.Size: " + population.Size);
            lbPopulationStats.Items.Add("population.Happiness: " + population.Happiness);
            lbPopulationStats.Items.Add("population.Hunger: " + population.Hunger);
            lbPopulationStats.Items.Add("population.Thirst: " + population.Thirst);
            lbPopulationStats.Items.Add("population.Education: " + population.Education);
            lbPopulationStats.Items.Add("population.Budget: " + population.Budget);
            lbPopulationStats.Items.Add("population.Efficiency: " + population.Efficiency);
            lbPopulationStats.Items.Add("population.BruttoIncome: " + population.BruttoIncome);
            lbPopulationStats.Items.Add("population.NettoIncome: " + population.NettoIncome);
            lbPopulationStats.Items.Add("population.Expenses: " + population.Expenses);
            lbPopulationStats.Items.Add("population.Health: " + population.Health);
            lbPopulationStats.Items.Add("population.Fuel: " + population.Fuel);
            lbPopulationStats.Items.Add("population.SocialLife: " + population.SocialLife);
            lbPopulationStats.Items.Add("population.ForbbidenThings: " + population.ForbbidenThings);
            lbPopulationStats.Items.Add("**********.Stat Rates: **********" + population.ForbbidenThings);
            lbPopulationStats.Items.Add("population.HungerRate: " + population.HungerRate);
            lbPopulationStats.Items.Add("population.ThirstRate: " + population.ThirstRate);
            lbPopulationStats.Items.Add("population.EducationRate: " + population.EducationRate);
            lbPopulationStats.Items.Add("population.HealthRate: " + population.HealthRate);
            lbPopulationStats.Items.Add("population.FuelRate: " + population.FuelRate);
            lbPopulationStats.Items.Add("population.SocialLifeRate: " + population.SocialLifeRate);
            lbPopulationStats.Items.Add("population.ForbbidenThingsRate: " + population.ForbbidenThingsRate);

            lbRessourcesStats.Items.Add("FoodNeeded: " + ressources.FoodNeeded);
            lbRessourcesStats.Items.Add("FoodAvailable: " + ressources.FoodAvailable);
            lbRessourcesStats.Items.Add("WaterNeeded: " + ressources.WaterNeeded);
            lbRessourcesStats.Items.Add("WaterAvailable: " + ressources.WaterAvailable);
            lbRessourcesStats.Items.Add("ElectricityNeeded: " + ressources.ElectricityNeeded);
            lbRessourcesStats.Items.Add("ElectricityAvailable: " + ressources.ElectricityAvailable);
            lbRessourcesStats.Items.Add("FuelNeeded: " + ressources.FuelNeeded);
            lbRessourcesStats.Items.Add("FuelAvailable: " + ressources.FuelAvailable);
            lbRessourcesStats.Items.Add("EducationNeeded: " + ressources.EducationNeeded);
            lbRessourcesStats.Items.Add("EducationAvailable: " + ressources.EducationAvailable);
            lbRessourcesStats.Items.Add("CultureNeeded: " + ressources.CultureNeeded);
            lbRessourcesStats.Items.Add("CultureAvailable: " + ressources.CultureAvailable);
            lbRessourcesStats.Items.Add("EmploymentNeeded: " + ressources.EmploymentNeeded);
            lbRessourcesStats.Items.Add("EmploymentAvailable: " + ressources.EmploymentAvailable);


            lbStockExchangeStats.Items.Add("*************** City Stock Exchange ****************");
            lbStockExchangeStats.Items.Add("TaxRate: " + stockExchange.TaxRate);
            lbStockExchangeStats.Items.Add("FoodRate: " + stockExchange.FoodRate);
            lbStockExchangeStats.Items.Add("WaterRate: " + stockExchange.WaterRate);
            lbStockExchangeStats.Items.Add("ElectricityRate: " + stockExchange.ElectricityRate);
            lbStockExchangeStats.Items.Add("FuelRate: " + stockExchange.FuelRate);
            lbStockExchangeStats.Items.Add("*************** World Stock Exchange ****************");
            lbStockExchangeStats.Items.Add("TaxRate: " + worldStockExchange.TaxRate);
            lbStockExchangeStats.Items.Add("FoodRate: " + worldStockExchange.FoodRate);
            lbStockExchangeStats.Items.Add("WaterRate: " + worldStockExchange.WaterRate);
            lbStockExchangeStats.Items.Add("ElectricityRate: " + worldStockExchange.ElectricityRate);
            lbStockExchangeStats.Items.Add("FuelRate: " + worldStockExchange.FuelRate);
        }

        // Game Stats Fields
        public static Stopwatch gameTimeDuration = new Stopwatch();

        public static void StartGame()
        {
            StartStopwatch();
        }

        // At begginnig of game
        public static void StartStopwatch()
        {
            gameTimeDuration.Start();
        }           

    }

}   

