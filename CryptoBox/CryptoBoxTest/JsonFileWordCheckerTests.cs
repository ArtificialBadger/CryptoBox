using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CryptoBox.Service;
using System.Threading.Tasks;
using CryptoBox.ServiceContract;

namespace CryptoBoxTest
{
    [TestClass]
    public class JsonFileWordCheckerTests
    {
		[TestMethod]
		public async Task ValidWordIsWord()
		{
			var a = new JsonFileWordChecker();

			var result = await a.CheckWord("bread");

			Assert.AreEqual(WordResult.IsWord, result);
		}

		[TestMethod]
		public async Task NonsenseIsNotWord()
		{
			var a = new JsonFileWordChecker();

			var result = await a.CheckWord("vasdf");

			Assert.AreEqual(WordResult.IsNotWord, result);
		}

		[TestMethod]
		public async Task SpecicalCharactersAreNotTreatedAsWords()
		{
			var a = new JsonFileWordChecker();

			var result = await a.CheckWord("pass-word");

			Assert.AreEqual(WordResult.IsNotWord, result);
		}
	}
}
