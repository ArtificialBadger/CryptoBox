using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoBox.Caeser
{
    public interface IStringDecryptor
    {
		string Decrypt(string ciphertext);
    }
}
