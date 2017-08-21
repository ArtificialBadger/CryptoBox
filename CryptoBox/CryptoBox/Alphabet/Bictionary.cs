
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CryptoBox.Alphabet
{
	// TODO ILZ: A Lot can be done to improve this like not storing every object twice. Maybe I'll get to it later.
	public class Bictionary<TKey, TCoKey> : IBictionary<TKey, TCoKey>
	{
		private IDictionary<TKey, TCoKey> keyDictionary = new Dictionary<TKey, TCoKey>();

		private IDictionary<TCoKey, TKey> coKeyDictionary = new Dictionary<TCoKey, TKey>();

		public int Count
		{
			get
			{
				return this.keyDictionary.Count; // coDictionaryCount would work just as well.
			}
		}

		public bool ContainsKey(TKey key)
		{
			return this.keyDictionary.ContainsKey(key);
		}

		public bool ContainsCoKey(TCoKey coKey)
		{
			return this.coKeyDictionary.ContainsKey(coKey);
		}

		public TKey LookupByCoKey(TCoKey coKey)
		{
			return this.coKeyDictionary[coKey];
		}

		public TCoKey LookupByKey(TKey key)
		{
			return this.keyDictionary[key];
		}

		public void AddMapping(TKey key, TCoKey coKey)
		{
			this.keyDictionary.Add(key, coKey);
			this.coKeyDictionary.Add(coKey, key);
		}

	}

}