using System;

namespace VendingMachine
{
    public class Item
    {
		public string Name { get; private set; }
		public double Price { get; private set; }

		public Item(string Name, double Price)
		{
			this.Name = Name;
			this.Price = Price;
		}
    }
}
