using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachine
{
    public class Coin
    {
		public virtual double Value { get; private set; }
		public static double[] Denominations = { 0.01, 0.02, 0.05, 0.10, 0.20, 0.50, 1.00, 2.00 };

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
