# City Game

## ToDO
- Upcoming: Unit Health decrement with the time passed
- Maintenance set true IF object under 50% health || Repairing ||Hit Bancrupt Tolerance
- Function write that repairs the object
- Function write that calculates the repair time
- Function write/check that calculates the repair cost
- Function write to end the Maintenance Mode after the repair
- Function write and GET update that sets the bankrupt true IF Object income is lower than the expenses for X amount of time. // Upcoming: After that it sets the Owner to the default city for sale and until then is in Maintenance Mode;
- Function GET write that increases the Size with each Level upgrade
- Function GET write that increases the Worker Capacity with each Level upgrade
- Function write that sets the Health to max
- Function GET write that Calculates the Efficiency of a Building
- Function GET write that Calculates the Time needed to Upgrade
- Function GET write that Calculates the Time needed to Repair
- - Function GET write that Calculates the Price to Upgrade
- Function GET write that Calculates the Price to Repair
- Function GET write that Calculates the Promotion Price
- Field remove PriceToSell, it's the same as PriceToBuy
- Function GET write that Calculates the Buying Price IF the building is owned and needed for sale or bancrupcy
- Function GET write that Calculates the Time Lasting Promotion 
- NEW Field create TimeLastingPromotion := bool; get = boost efficiency; set;
- Field check TaxToPay if false set it to StockExchange tax var

- In context to create a new class RessourceProduct, that contains all info over the product.
- Building Field create RessourceProduct;
- Building Field create ProductQuantityMax; get = Calculate the possible units of production, Calculated from efficiency, max workers, size and quality - per second; set;
- Building Field create ProductQuantityRate; get = Calculate the actual quantity in Procent Depending on efficiency; set;  
- Building Field create ProductQuantity; get = Calculate result from ProductQuantityRate% * ProductQuantityMax; 

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

