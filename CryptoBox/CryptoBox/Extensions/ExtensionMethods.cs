using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoBox.Extensions
{
    public static class ExtensionMethods
    {
		public static int GoodModulo(this int number, int modulo)
		{
			var newNumber = number % modulo;
			if (newNumber < 0)
			{
				return (newNumber + modulo);
			}
			else
			{
				return newNumber;
			}
		}
	}
}
