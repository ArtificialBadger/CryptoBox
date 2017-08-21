using CryptoBox.Alphabet;
using CryptoBox.Caeser;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoBoxTest
{
	[TestClass]
    public class CaesarShifterBaseline
    {
		[TestCategory("Area: Caesar")]
		[TestMethod]
		public void WellKnownCaesarShiftProducesWellKnownResult()
		{
			var plaintext = "this is a secret message";
			var expected = "wklv lv d vhfuhw phvvdjh";

			var shifter = new CaesarShifter();

			var shiftedText = shifter.Shift(plaintext, LetterSet.LowerCaseLatin, 3);

			Assert.AreEqual(expected, shiftedText);
		}

		[TestCategory("Area: Caesar")]
		[TestMethod]
		public void ShiftByLargeNumberShiftsViaMoulus()
		{
			var plaintext = "this is a secret message";
			var expected = "wklv lv d vhfuhw phvvdjh";

			var shifter = new CaesarShifter();

			var shiftedText = shifter.Shift(plaintext, LetterSet.LowerCaseLatin, 29);

			Assert.AreEqual(expected, shiftedText);
		}

		[TestCategory("Area: Caesar")]
		[TestMethod]
		public void ShiftByNegativeNumberShiftsViaMoulus()
		{
			var plaintext = "this is a secret message";
			var expected = "wklv lv d vhfuhw phvvdjh";

			var shifter = new CaesarShifter();

			var shiftedText = shifter.Shift(plaintext, LetterSet.LowerCaseLatin, -23);

			Assert.AreEqual(expected, shiftedText);
		}

		[TestCategory("Area: Caesar")]
		[TestMethod]
		public void ShiftWithUnkownCharactersLeavesThemInvariant()
		{
			var plaintext = "this is a secret message.";
			var expected = "wklv lv d vhfuhw phvvdjh.";

			var shifter = new CaesarShifter();

			var shiftedText = shifter.Shift(plaintext, LetterSet.LowerCaseLatin, 3);

			Assert.AreEqual(expected, shiftedText);
		}

		[TestCategory("Area: Caesar")]
		[TestMethod]
		public void ForwardThenInverseShiftProducesSimilarText()
		{
			var plaintext = "this is a secret message";

			var shifter = new CaesarShifter();

			var shiftedText = shifter.Shift(plaintext, LetterSet.LowerCaseLatin, 3);
			var unshiftedText = shifter.Shift(shiftedText, LetterSet.LowerCaseLatin, 23);

			Assert.AreEqual(plaintext, unshiftedText);
		}

		[TestCategory("Area: Caesar")]
		[TestMethod]
		public void ForwardThenInverseShiftProducesSimilarTextWithUnknownLetters()
		{
			var plaintext = "this is a secret message";

			var shifter = new CaesarShifter();

			var shiftedText = shifter.Shift(plaintext, LetterSet.LowerCaseLatin, 3);
			var unshiftedText = shifter.Shift(shiftedText, LetterSet.LowerCaseLatin, 23);

			Assert.AreEqual(plaintext, unshiftedText);
		}
	}
}
