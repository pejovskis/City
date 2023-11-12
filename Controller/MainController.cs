using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using City.Model.Building;
using City.Model.DataSource.MainStats;
using City.Model.Global;
using City.Model.Robot;
using static City.Model.DataSource.MainStats.StockExchangeStat;

namespace City.Controller
{
    public class MainController
    {
        public static void InitializeStatsPanel(ListBox lbPopulationStats, ListBox lbRessourcesStats, ListBox lbStockExchangeStats, Population population, Ressources ressources, StockExchange stockExchange, StockExchange worldStockExchange)
        {
            // Population Stats
            BindingList<PopulationStat> populationStats = new BindingList<PopulationStat>();
            populationStats.Add(new PopulationStat("Size", population.Size.ToString()));
            populationStats.Add(new PopulationStat("Happiness", population.Happiness.ToString()));
            populationStats.Add(new PopulationStat("Hunger", population.Hunger.ToString()));
            populationStats.Add(new PopulationStat("Thirst", population.Thirst.ToString()));
            populationStats.Add(new PopulationStat("Education", population.Education.ToString()));
            populationStats.Add(new PopulationStat("Budget", population.Budget.ToString()));
            populationStats.Add(new PopulationStat("Efficiency", population.Efficiency.ToString()));
            populationStats.Add(new PopulationStat("Brutto Income", population.BruttoIncome.ToString()));
            populationStats.Add(new PopulationStat("Netto Income", population.NettoIncome.ToString()));
            populationStats.Add(new PopulationStat("Expenses", population.Expenses.ToString()));
            populationStats.Add(new PopulationStat("Health", population.Health.ToString()));
            populationStats.Add(new PopulationStat("Fuel", population.Fuel.ToString()));
            populationStats.Add(new PopulationStat("Social Life", population.SocialLife.ToString()));
            populationStats.Add(new PopulationStat("Forbidden Things", population.ForbbidenThings.ToString()));
            populationStats.Add(new PopulationStat("********** Stat Rates **********", ""));
            populationStats.Add(new PopulationStat("Hunger Rate", population.HungerRate.ToString()));
            populationStats.Add(new PopulationStat("Thirst Rate", population.ThirstRate.ToString()));
            populationStats.Add(new PopulationStat("Education Rate", population.EducationRate.ToString()));
            populationStats.Add(new PopulationStat("Health Rate", population.HealthRate.ToString()));
            populationStats.Add(new PopulationStat("Fuel Rate", population.FuelRate.ToString()));
            populationStats.Add(new PopulationStat("Social Life Rate", population.SocialLifeRate.ToString()));
            populationStats.Add(new PopulationStat("Forbidden Things Rate", population.ForbbidenThingsRate.ToString()));

            lbPopulationStats.DataSource = populationStats;

            // Ressources Stats
            BindingList<RessourcesStat> ressourcesStats = new BindingList<RessourcesStat>();
            ressourcesStats.Add(new RessourcesStat("Food Needed", ressources.FoodNeeded.ToString()));
            ressourcesStats.Add(new RessourcesStat("Food Available", ressources.FoodAvailable.ToString()));
            ressourcesStats.Add(new RessourcesStat("Water Needed", ressources.WaterNeeded.ToString()));
            ressourcesStats.Add(new RessourcesStat("Water Available", ressources.WaterAvailable.ToString()));
            ressourcesStats.Add(new RessourcesStat("Electricity Needed", ressources.ElectricityNeeded.ToString()));
            ressourcesStats.Add(new RessourcesStat("Electricity Available", ressources.ElectricityAvailable.ToString()));
            ressourcesStats.Add(new RessourcesStat("Fuel Needed", ressources.FuelNeeded.ToString()));
            ressourcesStats.Add(new RessourcesStat("Fuel Available", ressources.FuelAvailable.ToString()));
            ressourcesStats.Add(new RessourcesStat("Education Needed", ressources.EducationNeeded.ToString()));
            ressourcesStats.Add(new RessourcesStat("Education Available", ressources.EducationAvailable.ToString()));
            ressourcesStats.Add(new RessourcesStat("Culture Needed", ressources.CultureNeeded.ToString()));
            ressourcesStats.Add(new RessourcesStat("Culture Available", ressources.CultureAvailable.ToString()));
            ressourcesStats.Add(new RessourcesStat("Employment Needed", ressources.EmploymentNeeded.ToString()));
            ressourcesStats.Add(new RessourcesStat("Employment Available", ressources.EmploymentAvailable.ToString()));

            lbRessourcesStats.DataSource = ressourcesStats;

            // Stock Exchange Stats
            BindingList<StockExchangeStat> stockExchangeStats = new BindingList<StockExchangeStat>();
            stockExchangeStats.Add(new StockExchangeStat("*************** City Stock Exchange ****************", ""));
            stockExchangeStats.Add(new StockExchangeStat("Tax Rate", stockExchange.TaxRate.ToString()));
            stockExchangeStats.Add(new StockExchangeStat("Food Rate", stockExchange.FoodRate.ToString()));
            stockExchangeStats.Add(new StockExchangeStat("Water Rate", stockExchange.WaterRate.ToString()));
            stockExchangeStats.Add(new StockExchangeStat("Electricity Rate", stockExchange.ElectricityRate.ToString()));
            stockExchangeStats.Add(new StockExchangeStat("Fuel Rate", stockExchange.FuelRate.ToString()));
            stockExchangeStats.Add(new StockExchangeStat("*************** World Stock Exchange ****************", ""));
            stockExchangeStats.Add(new StockExchangeStat("Tax Rate", worldStockExchange.TaxRate.ToString()));
            stockExchangeStats.Add(new StockExchangeStat("Food Rate", worldStockExchange.FoodRate.ToString()));
            stockExchangeStats.Add(new StockExchangeStat("Water Rate", worldStockExchange.WaterRate.ToString()));
            stockExchangeStats.Add(new StockExchangeStat("Electricity Rate", worldStockExchange.ElectricityRate.ToString()));
            stockExchangeStats.Add(new StockExchangeStat("Fuel Rate", worldStockExchange.FuelRate.ToString()));

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

