namespace Source
{
    using System;
    using System.Collections.Generic;

    public class Hash
    {
        private const ulong BASE1 = 31;
        private const ulong MOD1 = 1000000009;

        private const ulong BASE2 = 10037;
        private const ulong MOD2 = 1000000033;

        private ulong power1;
        private ulong[] power2;

        private int[] lastIndex;
        private int[] distances;

        public ulong Hash1
        {
            get;
            private set;
        }

        public ulong Hash2
        {
            get;
            private set;
        }

        public Hash(string str)
        {
            this.distances = new int[1000000];
            this.lastIndex = new int[26];
            for (int i = 0; i < lastIndex.Length; i++)
            {
                lastIndex[i] = -1;
            }

            this.Hash1 = 0;
            this.Hash2 = 0;

            this.power1 = 1;
            this.power2 = new ulong[str.Length + 1];
            power2[0] = 1;

            for (int i = 0; i < str.Length; i++)
            {
                this.Add(str[i], i);
                this.power1 = this.power1 * BASE1 % MOD1;
                power2[i+1] = this.power2[i] * BASE2 % MOD2;
            }
        }

        public void Add(char c, int index)
        {
            this.Hash1 *= BASE1;
            this.Hash2 *= BASE2;
            if ('A' <= c && c <= 'Z')
            {
                this.Hash1 += (ulong)(c - 'A' + 1);
                this.Hash2 += MOD2 - 1; // upcase
            }
            else
            {
                this.Hash1 += MOD1 - 1; // lowcase
                this.Hash2 += MOD2 - 2; // last of kind
                this.distances[index] = (int)(MOD2 - 2);
                if (this.lastIndex[c - 'a'] >= 0)
                {
                    int distance = index - lastIndex[c - 'a'];
                    this.distances[lastIndex[c - 'a']] = distance;
                    this.Hash2 += (ulong)(distance + 2) * this.power2[distance];
                }

                lastIndex[c - 'a'] = index;

            }

            this.Hash1 %= MOD1;
            this.Hash2 %= MOD2;
        }

        public void Remove(char c, int index)
        {
            if ('A' <= c && c <= 'Z')
            {
                this.Hash1 += MOD1 * MOD1 - (ulong)(c - 'A' + 1) * this.power1;
                this.Hash2 += MOD2 * MOD2 - (MOD2 - 1) * this.power2[this.power2.Length - 1];
            }
            else
            {
                this.Hash1 += MOD1 * MOD1 - (MOD1 - 1) * this.power1;
                this.Hash2 += MOD2 * MOD2 - (ulong)distances[index] * this.power2[this.power2.Length - 1];
                if (lastIndex[c - 'a'] == index)
                {
                    lastIndex[c - 'a'] = -1;
                }
            }

            this.Hash1 %= MOD1;
            this.Hash2 %= MOD2;
        }
    }

    public class Startup
    {
        public static void Main()
        {
            var pattern = Console.ReadLine();
            var text = Console.ReadLine();

            if (pattern.Length > text.Length)
            {
                Console.WriteLine(0);
                return;
            }

            Hash hpattern = new Hash(pattern);
            Hash hwindow = new Hash(text.Substring(0, pattern.Length));

            List<int> matches = new List<int>();

            if (hpattern.Hash1 == hwindow.Hash1 && hpattern.Hash2 == hwindow.Hash2)
            {
                matches.Add(1);
            }

            for (int i = pattern.Length; i < text.Length; i++)
            {
                hwindow.Add(text[i], i);
                hwindow.Remove(text[i - pattern.Length], i - pattern.Length);

                if (hpattern.Hash1 == hwindow.Hash1 && hpattern.Hash2 == hwindow.Hash2)
                {
                    matches.Add(i - pattern.Length + 2);
                }
            }

            Console.WriteLine("{0}\n{1}", matches.Count, string.Join(" ", matches));
        }
    }
}
