namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class SelectionSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            var iMin = 0;

            for (int j = 0; j < collection.Count - 1; j++)
            {
                iMin = j;

                for (int i = j+1; i < collection.Count; i++)
                {
                    if (collection[i].CompareTo(collection[iMin]) < 0)
                    {
                        iMin = i;
                    }
                }

                if (iMin != j)
                {
                    Swap(collection, iMin, j);
                }
            }
        }

        private void Swap(IList<T> collection, int firstIndex, int secondIndex)
        {
            var smallest = collection[firstIndex];
            collection[firstIndex] = collection[secondIndex];
            collection[secondIndex] = smallest;
        }
    }
}
