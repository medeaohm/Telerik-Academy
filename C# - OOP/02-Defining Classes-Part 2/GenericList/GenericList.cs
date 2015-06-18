namespace GenericClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GenericList<T> where T : IComparable, new()
    {
        const int DefaultCapacity = 1;

        private T[] arrayT;

        public GenericList (int capacity = DefaultCapacity)
        {
            this.Count = 0;
            this.Capacity = capacity;
            this.arrayT = new T[capacity];
        }

        public int Count { get; set; }

        public int Capacity { get; set; }

        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < this.arrayT.Length)
                {
                    return this.arrayT[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Index is out of range!");
                }
            }
            set
            {
                if (index >= 0 && index < this.arrayT.Length)
                {
                    this.arrayT[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Index is out of range!");
                }
            }
        }

        public void Add(T element)
        {
            this.Count++;
            this.Resize(this.Count);
            this.arrayT[this.Count - 1] = element;
        }

        public void Insert(int index, T element)
        {
            if (index < 0 || index >= this.arrayT.Length)
            {
                throw new IndexOutOfRangeException("Index is out of range!");
            }
            this.Count++;
            this.Resize(this.Count);
            Array.Copy(this.arrayT, index, this.arrayT, index + 1, this.Count - index - 1);
            this.arrayT[index] = element;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= this.arrayT.Length)
            {
                throw new IndexOutOfRangeException("Index is out of range!");
            }
            this.Count--;
            this.Resize(this.Count);
            Array.Copy(this.arrayT, index + 1, this.arrayT, index, this.Count - index);
            this.arrayT[index] = default(T);
        }

        public int IndexOf(T element)
        {
            return Array.IndexOf(this.arrayT, element);
        }

        public bool Contains(T item)
        {
            return this.arrayT.Contains(item);
        }

        public void Clear()
        {
            this.Count = 0;
            this.Capacity = DefaultCapacity;
            this.arrayT = new T[this.Capacity];
        }

        public T Min()
        {
            T minValue = arrayT[0];
            for (int i = 0; i < this.arrayT.Length; i++)
            {
                if ((dynamic)arrayT[i] < minValue)
                {
                    minValue = (dynamic)arrayT[i];
                }
            }
            return minValue;
        }

        public T Max()
        {
            T maxValue = arrayT[0];
            for (int i = 0; i < this.arrayT.Length; i++)
            {
                if ((dynamic)arrayT[i] > maxValue)
                {
                    maxValue = (dynamic)arrayT[i];
                }
            }
            return maxValue;
        }

        private void Resize(int capacity)
        {
            this.Capacity = capacity * 2;
            Array.Resize(ref this.arrayT, this.Capacity);
        }

        public override string ToString()
        {
            if (this.Count == 0)
            {
                return "Empty list!";
            }

            var result = new StringBuilder();
            result.Append("Element(s): ");
            for (int i = 0; i < this.Count; i++)
            {
                result.AppendFormat("{0}", this.arrayT[i]);
                if (i + 1 < this.Count)
                {
                    result.Append(", ");
                }
            }
            return result.ToString();
        }
    }
}
