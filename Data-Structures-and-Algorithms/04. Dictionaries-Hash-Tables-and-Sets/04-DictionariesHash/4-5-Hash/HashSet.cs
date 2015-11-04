//5. Implement the data structure `set` in a class `HashedSet<T>` using your class `HashTable<K, T>` to hold the elements.Implement all standard set operations like
//    * `Add(T)`
//    * `Find(T)`
//    * `Remove(T)`
//    * `Count`
//    * `Clear()`
//    * union and
//    * intersect

//    Write unit tests for your class.

namespace Hash
{
    using System.Collections;
    using System.Collections.Generic;

    public class HashedSet<T> : IEnumerable<T>
    {
        private HashTable<T, T> data;

        public HashedSet()
        {
            this.data = new HashTable<T, T>();
        }

        public int Count
        {
            get
            {
                return this.data.Count;
            }
        }

        public int Capacity
        {
            get
            {
                return this.data.Capacity;
            }
        }

        public void Add(T value)
        {
            this.data.Add(value, value);
        }

        public bool Find(T value)
        {
            var valueFound = this.data.Find(value);
            return true;
        }

        public void Remove(T value)
        {
            this.data.Remove(value);
        }

        public void Clear()
        {
            this.data.Clear();
        }

        public HashedSet<T> Union(HashedSet<T> set)
        {
            foreach (var pair in this.data)
            {
                foreach (var key in set)
                {
                    if (!key.Equals(pair.Key))
                    {
                        set.Add(pair.Key);
                    }
                }
            }

            return set;
        }

        public HashedSet<T> Intersect(HashedSet<T> set)
        {
            var result = new HashedSet<T>();
            foreach (var pair in this.data)
            {
                foreach (var key in set)
                {
                    if (key.Equals(pair.Key))
                    {
                        result.Add(key);
                    }
                }
            }

            return result;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var pair in this.data)
            {
                yield return pair.Key;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
