# City Game

## Upcoming:
- Unit Health decrement with the time passed
- Bankrupt true IF Object income is lower than the expenses for X amount of time After that it sets the Owner to the default city for sale and until then is in Maintenance Mode;

## ToDO
- WorldStockExchange Random Events (drops, increases calculated with keys like: 1-100 drop 0.1 and exactly 550 drop 3 in fuel or similar)
- 

## Calculations needed for:
- Building Field create ProductQuantityMax; get = Calculate the possible units of production, Calculated from efficiency, max workers, size and quality - per second; set;
- Building Field create ProductQuantityRate; get = Calculate the actual quantity in Procent Depending on efficiency; set;  
- Building Field create ProductQuantity; get = Calculate result from ProductQuantityRate% * ProductQuantityMax;
- Building Field create ProductBruttoPrice; get; set;
- Maintenance set true IF object under 50% health || Repairing || Hit Bancrupt Tolerance
- Function write that calculates the repair time
- Function write/check that calculates the repair cost
- Function GET write that increases the Size with each Level upgrade
- Function GET write that increases the Worker Capacity with each Level upgrade
- Function GET write that Calculates the Efficiency of a Building
- Function GET write that Calculates the Time needed to Upgrade
- Function GET write that Calculates the Time needed to Repair
- Function GET write that Calculates the Price to Upgrade
- Function GET write that Calculates the Price to Repair
- Function GET write that Calculates the Promotion Price
- Function GET write that Calculates the Buying Price IF the building is owned and needed for sale or bancrupcy
- Function GET write that Calculates the Time Lasting Promotion 
- NEW Field create TimeLastingPromotion := bool; get = boost efficiency; set;

## Done
- Field remove PriceToSell, it's the same as PriceToBuy
- Function write that sets the Health to max
- Function write to end the Maintenance Mode after the repair
- Function write and GET update that sets the bankrupt true IF Object income is lower than the expenses for X amount of time.
- Field check TaxToPay if false set it to StockExchange tax var

## Class Unit
- Mother of Models
- Attributes: TaxRate, Health, Efficiency

### Class Building
- Child of Unit
- Mother of all Buildings
- Attributes: 
	- Id 
	- Name 
	- Description
	- Quality
	- Owner
	- Sold
	- InMaintenance
	- IsBankrupt
	- Level
	- Size
	- WorkerCapacity
	- WorkersEmployed
	- Efficiency := override from Unit
	- TimeToRepair
	- TimeToUpgrade
	- TimeLastingPromotion
	- PriceToBuy
	- BankruptTolerance
	- PriceToUpgrade
	- PriceToRepair
	- PriceToPromote
	- PriceToSell
	- SalaryMonthly
	- CostsElectricity
	- CostsWater
	- ProductionItemQuantity
	- ProductionPiecePrice
	- BruttoIncome
	- NettoIncome
	- Expenses
	- NettoWin
	- CustomerSatisfaction
	- Rating
- Constructor:
	- Id
	- Name
	- Quality
	- Description
	- WorkerCapacity
	- WorkersEmployed
	- PriceToBuy
	- BankruptTolerance
	- TaxRate
- Functions
	- UpgradeLevel()
	- SalaryPay()
	- EmployWorkerg
	- FireWorker
	- StartRepair()
	- EndRepair()
	- SetHealthMax()


### Class Player
- Child of Unit
- Attributes:
	- Id
	- Name
	- Capital
	- OwnedBuildings
- Constructor:
	- Id
	- Name
	- Capital
	- OwnedBuildings := new List
- Functions:
	- BuildingBuy(Building building)
	- BuildingUpgrade(Building building)
	- BuildingPromote(Building building)
	- BuildingRepair(Building building)

### Class StockExchange
- Attributes:
	- TaxRate
	- FoodRate
	- WaterRate
	- ElectricityRate
	- FuelRate
	- Building
	- FoodAvailable
	- WaterAvailable
	- ElectricityAvailable
	- FuelAvailable
	- EducationAvailable
	- CultureAvailable
	- EmploymentAvailable
	- FoodNeeded
	- WaterNeeded
	- ElectricityNeeded
	- FuelNeeded
	- EducationNeeded
	- CultureNeeded
	- EmploymentNeeded
- Constructor:

