using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoBox.Caeser
{
	public class CaeserDecryptor : IStringDecryptor
	{
		public string Decrypt(string ciphertext)
		{
			var delims = new List<string>() { " " };

			var plaintextWords = ciphertext.Split(delims.ToArray(), StringSplitOptions.RemoveEmptyEntries);

			return "Sorry, I couldn't do anything " + ciphertext;
		}

		//public string Shift(params stringp[] ciphertexts)
		//{
		//}
	}
}
