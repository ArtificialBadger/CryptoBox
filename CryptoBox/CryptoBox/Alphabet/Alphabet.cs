using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoBox.Alphabet
{
    public class Alphabet
    {

		public Bictionary<char, int> CreateAlphabet(IList<char> orderedAlphabetValues)
		{
			var bictionary = new Bictionary<char, int>();

			var alphabetCount = orderedAlphabetValues.Count;

			for( int i = 0; i < alphabetCount; i++)
			{
				bictionary.AddMapping(orderedAlphabetValues[i], i);
			}

			return bictionary;
		}

    }
}
