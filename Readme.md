# City Game

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

