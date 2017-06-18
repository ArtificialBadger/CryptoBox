using CryptoBox.Model;
using CryptoBox.ServiceContract;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CryptoBox.Service
{
	public sealed class JsonFileWordChecker : IWordChecker
	{
		private bool hasLoadedWords = false;

		private IList<string> words = new List<string>();

		public async Task<WordResult> CheckWord(string word)
		{
			if (!hasLoadedWords)
			{
				await LoadWords();
			}
		
			if (this.words.Contains(word))
			{
				return WordResult.IsWord;
			}
			else
			{
				return WordResult.IsNotWord;
			}

		}

		private async Task LoadWords()
		{
			using (var reader = new StreamReader(this.GetType().GetTypeInfo().Assembly.GetManifestResourceStream("CryptoBox.Resources.Words.json")))
			{
				var text = await reader.ReadToEndAsync();
				this.words = JsonConvert.DeserializeObject<WordList>(text).Words;
				this.hasLoadedWords = true;
			}
		}
	}
}
