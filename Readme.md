### City Game

## Class Unit
- Mother of Models
- Attributes: TaxRate, Health, Efficiency

# Class Building
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
