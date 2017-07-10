using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public class CoinManager
    {
		public static Coin[] ValidUserCoins = { new Coin(0.50) };
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

		public void Insert(Coin coin)
		{
			if (!IsValid(coin))
			{
				throw new ArgumentException("Only accpets 50p coins");
			}
			UserCoins.Add(coin);
		}

		private bool IsValid(Coin PassedCoin)
		{
			bool Valid = false;
			foreach (Coin coin in ValidUserCoins)
			{
				if (coin.Value == PassedCoin.Value)
				{
					Valid = true;
					break;
				}
			}
			return Valid;
		}
	}
}
