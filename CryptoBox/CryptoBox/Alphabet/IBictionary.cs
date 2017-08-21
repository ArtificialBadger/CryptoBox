
using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoBox.Alphabet
{
    public interface IBictionary<TKey, TCoKey>
    {
		int Count { get; }

		bool ContainsKey(TKey key);

		bool ContainsCoKey(TCoKey coKey);

		TKey LookupByCoKey(TCoKey coKey);

		TCoKey LookupByKey(TKey key);

		void AddMapping(TKey key, TCoKey coKey);
		
	}
}
