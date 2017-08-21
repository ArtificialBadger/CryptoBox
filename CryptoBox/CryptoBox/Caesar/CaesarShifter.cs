using CryptoBox.Alphabet;
using CryptoBox.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CryptoBox.Caeser
{
	public class CaesarShifter : ICaesarShifter
	{
		public string Shift(string text, LetterSet letterSet, int shiftAmount)
		{
			var letterCount = letterSet.LetterBictionary.Count;

			var builder = new StringBuilder(text.Length);

			foreach (var letter in text)
			{ 
				if (letterSet.LetterBictionary.ContainsKey(letter))
				{
					builder.Append(letterSet.LetterBictionary.LookupByCoKey((letterSet.LetterBictionary.LookupByKey(letter) + shiftAmount).GoodModulo(letterCount)));
				}
				else
				{
					builder.Append(letter);
				}
			}

			return builder.ToString();
		}
	}
}
