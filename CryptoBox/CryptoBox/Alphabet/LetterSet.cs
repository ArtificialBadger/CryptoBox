using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoBox.Alphabet
{
    public class LetterSet
    {
		public IBictionary<char, int> LetterBictionary;

		public LetterSet(IBictionary<char, int> letterBictionary)
		{
			this.LetterBictionary = letterBictionary;
		}

		public static LetterSet LowerCaseLatin = CreateLetterSet(new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' });

		public static LetterSet CreateLetterSet(IList<char> orderedAlphabetValues)
		{
			var bictionary = new Bictionary<char, int>();

			var alphabetCount = orderedAlphabetValues.Count;

			for( int i = 0; i < alphabetCount; i++)
			{
				bictionary.AddMapping(orderedAlphabetValues[i], i);
			}

			return new LetterSet(bictionary);

		}

    }
}
