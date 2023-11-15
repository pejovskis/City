using System;
using System.ComponentModel;
using System.Diagnostics;
using City.Model.DataSource.MainStats;
using City.Model.Global;
using City.Model.Robot;

namespace City.Controller
{
    public class MainController
    {

        public BindingList<PopulationStat> populationStats;
        public BindingList<RessourcesStat> ressourcesStats;
        public BindingList<StockExchangeStat> stockExchangeStats;

        public void InitializeStatsPanel(ListBox lbPopulationStats, ListBox lbRessourcesStats, ListBox lbStockExchangeStats, Population population, Ressources ressources, StockExchange stockExchange)
        {
            // Population Stats
            populationStats = new BindingList<PopulationStat>
            {
                new PopulationStat("Size", population.Size.ToString()),
                new PopulationStat("Happiness", population.Happiness.ToString()),
                new PopulationStat("Hunger", population.Hunger.ToString()),
                new PopulationStat("Thirst", population.Thirst.ToString()),
                new PopulationStat("Education", population.Education.ToString()),
                new PopulationStat("Budget", population.Budget.ToString()),
                new PopulationStat("Efficiency", population.Efficiency.ToString()),
                new PopulationStat("Brutto Income", population.BruttoIncome.ToString()),
                new PopulationStat("Netto Income", population.NettoIncome.ToString()),
                new PopulationStat("Expenses", population.Expenses.ToString()),
                new PopulationStat("Health", population.Health.ToString()),
                new PopulationStat("Fuel", population.Fuel.ToString()),
                new PopulationStat("Social Life", population.SocialLife.ToString()),
                new PopulationStat("Forbidden Things", population.ForbbidenThings.ToString()),
                new PopulationStat("********** Stat Rates **********", ""),
                new PopulationStat("Hunger Rate", population.HungerRate.ToString()),
                new PopulationStat("Thirst Rate", population.ThirstRate.ToString()),
                new PopulationStat("Education Rate", population.EducationRate.ToString()),
                new PopulationStat("Health Rate", population.HealthRate.ToString()),
                new PopulationStat("Fuel Rate", population.FuelRate.ToString()),
                new PopulationStat("Social Life Rate", population.SocialLifeRate.ToString()),
                new PopulationStat("Forbidden Things Rate", population.ForbbidenThingsRate.ToString())
            };

            lbPopulationStats.DataSource = populationStats;

            // Ressources Stats
            ressourcesStats = new BindingList<RessourcesStat>
            {
                new RessourcesStat("Food Needed", ressources.FoodNeeded.ToString()),
                new RessourcesStat("Food Available", ressources.FoodAvailable.ToString()),
                new RessourcesStat("Water Needed", ressources.WaterNeeded.ToString()),
                new RessourcesStat("Water Available", ressources.WaterAvailable.ToString()),
                new RessourcesStat("Electricity Needed", ressources.ElectricityNeeded.ToString()),
                new RessourcesStat("Electricity Available", ressources.ElectricityAvailable.ToString()),
                new RessourcesStat("Fuel Needed", ressources.FuelNeeded.ToString()),
                new RessourcesStat("Fuel Available", ressources.FuelAvailable.ToString()),
                new RessourcesStat("Education Needed", ressources.EducationNeeded.ToString()),
                new RessourcesStat("Education Available", ressources.EducationAvailable.ToString()),
                new RessourcesStat("Culture Needed", ressources.CultureNeeded.ToString()),
                new RessourcesStat("Culture Available", ressources.CultureAvailable.ToString()),
                new RessourcesStat("Employment Needed", ressources.EmploymentNeeded.ToString()),
                new RessourcesStat("Employment Available", ressources.EmploymentAvailable.ToString())
            };

            lbRessourcesStats.DataSource = ressourcesStats;

            // Stock Exchange Stats
            stockExchangeStats = new BindingList<StockExchangeStat>
            {
                new StockExchangeStat("*************** City Stock Exchange ****************", ""),
                new StockExchangeStat("Tax Rate", stockExchange.TaxRate.ToString()),
                new StockExchangeStat("Food Rate", stockExchange.FoodRate.ToString()),
                new StockExchangeStat("Water Rate", stockExchange.WaterRate.ToString()),
                new StockExchangeStat("Electricity Rate", stockExchange.ElectricityRate.ToString()),
                new StockExchangeStat("Fuel Rate", stockExchange.FuelRate.ToString())
            };

            lbStockExchangeStats.DataSource = stockExchangeStats;
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

