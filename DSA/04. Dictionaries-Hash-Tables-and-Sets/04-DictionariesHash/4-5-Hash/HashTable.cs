//4. Implement the data structure `hash table` in a class `HashTable<K, T>`. Keep the data in array of lists of key-value pairs(`LinkedList<KeyValuePair<K, T>>[]`) with initial capacity of 16. When the hash table load runs over 75%, perform resizing to 2 times larger capacity.Implement the following methods and properties:

//    * `Add(key, value)`
//    * `Find(key)->value`
//    * `Remove(key)`
//    * `Count`
//    * `Clear()`
//    * `this[]`
//    * `Keys`

namespace Hash
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class HashTable<K, V> : IEnumerable<KeyValuePair<K, V>>
    {
        private int initialSize;

        private LinkedList<KeyValuePair<K, V>>[] data;

        private int counter;

        public HashTable()
        {
            this.initialSize = 16;
            this.data = new LinkedList<KeyValuePair<K, V>>[this.initialSize];
            this.counter = 0;
        }

        public int Count
        {
            get
            {
                return this.counter;
            }
        }

        public int Capacity
        {
            get
            {
                return this.data.Length;
            }
        }

        public HashSet<K> Keys
        {
            get
            {
                var keys = new HashSet<K>();
                foreach (var collection in this.data)
                {
                    if (collection != null)
                    {
                        foreach (var pair in collection)
                        {
                            keys.Add(pair.Key);
                        }
                    }
                }

                return keys;
            }
        }

        public V this[K key]
        {
            get
            {
                return this.Find(key);
            }

            set
            {
                var hash = key.GetHashCode();
                hash = Math.Abs(hash % this.Capacity);

                if (this.data[hash] == null)
                {
                    this.data[hash] = new LinkedList<KeyValuePair<K, V>>();
                }

                var existPair = this.data[hash].FirstOrDefault(p => p.Key.Equals(key));
                if (existPair.Key == null)
                {
                    throw new ArgumentException("This key does not exist!");
                }

                var newPair = new KeyValuePair<K, V>(existPair.Key, value);
                this.data[hash].Remove(existPair);
                this.data[hash].AddLast(newPair);
            }
        }

        public void Add(K key, V value)
        {
            var hash = key.GetHashCode();
            hash = Math.Abs(hash % this.Capacity);

            if (this.data[hash] == null)
            {
                this.data[hash] = new LinkedList<KeyValuePair<K, V>>();
            }

            var existKey = this.data[hash].Any(p => p.Key.Equals(key));
            if (existKey)
            {
                throw new ArgumentException("This key already exist!");
            }

            var pair = new KeyValuePair<K, V>(key, value);
            this.data[hash].AddLast(pair);
            this.counter++;

            if (this.Count >= 0.75 * this.Capacity)
            {
                this.counter = 0;
                this.ResizeDataCapacity();
            }
        }

        public V Find(K key)
        {
            var hash = key.GetHashCode();
            hash = Math.Abs(hash % this.Capacity);

            if (this.data[hash] == null)
            {
                this.data[hash] = new LinkedList<KeyValuePair<K, V>>();
            }

            var existKey = this.data[hash].FirstOrDefault(p => p.Key.Equals(key));
            if (existKey.Key == null)
            {
                throw new ArgumentException("This key does not exist!");
            }

            return existKey.Value;
        }

        public void Remove(K key)
        {
            var hash = key.GetHashCode();
            hash = Math.Abs(hash % this.Capacity);

            if (this.data[hash] == null)
            {
                this.data[hash] = new LinkedList<KeyValuePair<K, V>>();
            }

            var existKey = this.data[hash].FirstOrDefault(p => p.Key.Equals(key));
            if (existKey.Key == null)
            {
                throw new ArgumentException("This key does not exist!");
            }

            this.data[hash].Remove(existKey);
            this.counter--;
        }

        public void Clear()
        {
            this.data = new LinkedList<KeyValuePair<K, V>>[this.initialSize];
            this.counter = 0;
        }

        public IEnumerator<KeyValuePair<K, V>> GetEnumerator()
        {
            foreach (var collection in this.data)
            {
                if (collection != null)
                {
                    foreach (var pair in collection)
                    {
                        yield return pair;
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private void ResizeDataCapacity()
        {
            var dataCopy = new LinkedList<KeyValuePair<K, V>>[this.initialSize];
            this.data.CopyTo(dataCopy, 0);

            this.initialSize *= 2;
            this.data = new LinkedList<KeyValuePair<K, V>>[this.initialSize];

            foreach (var collection in dataCopy)
            {
                if (collection != null)
                {
                    foreach (var pair in collection)
                    {
                        this.Add(pair.Key, pair.Value);
                    }
                }
            }
        }
    }
}
