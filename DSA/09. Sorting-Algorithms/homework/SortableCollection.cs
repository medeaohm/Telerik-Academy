namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class SortableCollection<T> where T : IComparable<T>
    {
        private readonly IList<T> items;

        private static Random random = new Random();

        public SortableCollection()
        {
            this.items = new List<T>();
        }

        public SortableCollection(IEnumerable<T> items)
        {
            this.items = new List<T>(items);
        }

        public IList<T> Items
        {
            get
            {
                return this.items;
            }
        }

        public void Sort(ISorter<T> sorter)
        {
            sorter.Sort(this.items);
        }

        public bool LinearSearch(T item)
        {
            int listCount = items.Count;
            bool itemFound = false;
            for (int i = 0; i < listCount; i++)
            {
                if (items[i].CompareTo(item) == 0)
                {
                    itemFound = true;
                    return itemFound;
                }
            }

            return itemFound;
        }

        public bool BinarySearch(T item)
        {
            int lowerBound = 0;
			int upperBound = Items.Count - 1;
			int current = 0;
			bool found = false;

			while (true)
			{
				current = (lowerBound + upperBound) / 2;

				if (lowerBound > upperBound)
				{
					break;
				}
				else if (items[current].CompareTo(item) == 0)
				{
					found = true;
                    break;
				}
				else
				{
					if (items[current].CompareTo(item) < 0)
					{
						lowerBound = current + 1;
					}
					else
					{
						upperBound = current - 1;
					}
				}
			}

			return found;
        }

        /// <summary>
        /// Fisher-Yates Shuffle.Shuffling an array randomizes its element order. With the Fisher-Yates shuffle, first implemented on 
        /// computers by Durstenfeld in 1964, we randomly sort elements. This is an accurate, effective shuffling method for all array types.
        /// Complexity - N
        /// </summary>
        public void Shuffle()
        {
            int itemsCount = Items.Count;

            for (int i = 0; i < itemsCount; i++)
            {
                int randomNumber = i + (int)(random.NextDouble() * (itemsCount - i));
                T currentItem = Items[randomNumber];
                Items[randomNumber] = Items[i];
                Items[i] = currentItem;
            }
        }

        public void PrintAllItemsOnConsole()
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(this.items[i]);
                }
                else
                {
                    Console.Write(" " + this.items[i]);
                }
            }

            Console.WriteLine();
        }
    }
}
