using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachine
{
    public class Coin
    {
		public double Value { get; private set; }
		public static double[] Denominations = { 1, 2, 5, 10, 20, 50, 100, 200 };

		public Coin(double Value)
		{
			if (!Denominations.Contains(Value))
			{
				throw new ArgumentException("Not a valid coin denomination");
			}

			this.Value = Value;
		}
    }
}
