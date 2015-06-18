/* Problem 5. 64 Bit array
Define a class `BitArray64` to hold `64` bit values inside an `ulong` value. Implement `IEnumerable<int>` and `Equals(…)`, `GetHashCode()`, `[]`, `==` and `!=`.
*/

namespace BitArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class BitArray64 : IEnumerable<int>
    {
        private ulong number;

        public BitArray64(ulong number)
        {
            this.Number = number;
        }

        public ulong Number 
        {
            get { return this.number; }
            set { this.number = value; }
        }

        public int this[int pos]
        {
            get
            {
                if (pos < 0 || pos >= 64)
                {
                    throw new IndexOutOfRangeException();
                }
                return ((int)(this.Number >> pos) & 1);
            }
            set
            {
                if (pos < 0 || pos >= 64)
                {
                    throw new IndexOutOfRangeException("Invalid bit position");
                }
                if (value < 0 || value > 1)
                {
                    throw new ArgumentException("Invalid bit value");
                }
                if (((int)(this.Number >> pos) & 1) != value)
                {
                    this.Number ^= (1ul << pos);
                }
            }
        }

        public static bool operator == (BitArray64 b1, BitArray64 b2)
        {
            return b1.Equals(b2);
        }

        public static bool operator !=(BitArray64 b1, BitArray64 b2)
        {
            return !(b1.Equals(b2));
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int pos = 0; pos < 64; pos++)
            {
                result.Insert(0, ((this.Number >> pos) & 1));
            }
            return result.ToString();
        }

        public override int GetHashCode()
        {
            return this.Number.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return this.Number.Equals((obj as BitArray64).Number);
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int pos = 0; pos < 64; pos++)
            {
                yield return this[pos];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
