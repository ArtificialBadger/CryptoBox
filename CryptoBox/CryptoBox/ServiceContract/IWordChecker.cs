using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CryptoBox.ServiceContract
{
    public interface IWordChecker
    {
		Task<WordResult> CheckWord(string word);
    }
}
