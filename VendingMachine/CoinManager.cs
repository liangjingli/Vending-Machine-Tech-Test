using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public class CoinManager
    {
		private List<Coin> _userCoins = new List<Coin>();

		public List<Coin> UserCoins
		{
			get { return _userCoins; }
			set { _userCoins = value; }
		}

		public CoinManager()
		{
			this.UserCoins = UserCoins;
		}
    }
}
