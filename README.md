# Vending-Machine-Tech-Test
## My Approach
Before I started coding I drew a simple rudimentary class diagram. I thought about the constraints and how to properly utilize Object Oriented Design in my code. Below is a Class diagram of my code.

![Imgur](http://i.imgur.com/28GcdcX.png)

## Functionality
- Only accepts 50p coins
- VendingMachine is stocked with other coin denominations to give correct change
- Has limited number of coins and can run out of change
- The machine only dispenses either bottled water at 60p or crisps at 40p
- The machine has a limited stock of items purchasing items will reduce Item stock

## Instructions
#### Prerequisite
- Visual Studio 2017 
- .Net Core package

1. Clone or download this repo
2. Open VendingMachineTechTest.sln in visual studio 2017

#### Tests
On the menu bar, select Test > Run > All Tests.

#### C# Interactive Example

To run code in C# Interactive:
Select each class Individually > Right Click > Execute in Interactive

![Imgur](http://i.imgur.com/7nfeBTN.png)
Once you have executed all classes in Interactive you can use code as follows:
```
> VendingMachine OfficeVendingMachine = new VendingMachine();
> OfficeVendingMachine.DisplayItems();
Name       Price
water       £0.60
water       £0.60
water       £0.60
crisps       £0.40
crisps       £0.40
crisps       £0.40
> OfficeVendingMachine.Select("water");
You Have Selected water
Total Price £0.60
> OfficeVendingMachine.Select("water");
You Have Selected water
Total Price £1.20
> OfficeVendingMachine.Insert(new Coin(50));
You Have Inserted £0.50
Total Paid £0.50
Total Price £1.20
Please Insert more coins To Complete purchase
> OfficeVendingMachine.Insert(new Coin(50));
You Have Inserted £0.50
Total Paid £1.00
Total Price £1.20
Please Insert more coins To Complete purchase
> OfficeVendingMachine.Insert(new Coin(50));
You Have Inserted £0.50
Total Paid £1.50
Total Price £1.20
Your Items(s):
2x water
Your Change: £0.30
```
