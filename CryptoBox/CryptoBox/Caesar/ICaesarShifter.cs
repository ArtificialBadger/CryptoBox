using CryptoBox.Alphabet;
using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoBox.Caeser
{
    public interface ICaesarShifter
    {
		string Shift(string text, LetterSet letterSet, int shiftAmount);
    }
}
