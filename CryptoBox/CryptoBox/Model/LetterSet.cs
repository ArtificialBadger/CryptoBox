using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoBox.Model
{
    public class LetterSet
    {
		public LetterSet(IList<char> letters)
		{
			this.Letters = letters;
		}

		public IList<char> Letters
		{
			get;
		}

		public static LetterSet StandardEnglish
		{
			get
			{
				return new LetterSet(new List<char>() { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' });
			}
		}
	}
	
}
