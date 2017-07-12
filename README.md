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
## Improvements
There are 2 more possible class extractions from VendingMachine. I could extract an ItemManager class to be solely responsible for managing Items and also Display class to be responsible for displaying output to screen. This would also make unit testing easier. 

There are some edge cases that need fixing, at the moment if there is no change available there isn't a way for user to know about it, adding this functionality would be a major improvement.

I have left some function open to extension for future improvements. For example the `IsValid` function in `CoinManager` has been intentionally coded to iterate through an array of valid coins instead of a fixed coin. This would mean that you could easily add another acceptable coin for the machine.
