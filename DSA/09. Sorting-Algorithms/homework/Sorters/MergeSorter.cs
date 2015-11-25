namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MergeSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException("collection", "Collection cannot be null");
            }

            if (collection.Count <= 1)
            {
                return;
            }

            MergeSort(collection, 0, collection.Count - 1);
        }

        private void MergeSort(IList<T> collection, int start, int end)
        {
            if (start < end)
            {
                var middle = (start + end) / 2;
                MergeSort(collection, start, middle);
                MergeSort(collection, middle + 1, end);

                // merging
                var currentPositon = start;
                var secondCollectionPosition = middle + 1;
                while (currentPositon <= middle)
                {
                    if (collection[currentPositon].CompareTo(collection[secondCollectionPosition]) > 0)
                    {
                        Swap(collection, currentPositon, secondCollectionPosition);

                        // keep second part sorted
                        while (secondCollectionPosition < end && collection[secondCollectionPosition].CompareTo(collection[secondCollectionPosition + 1]) > 0)
                        {
                            Swap(collection, secondCollectionPosition, secondCollectionPosition + 1);
                            ++secondCollectionPosition;
                        }

                        secondCollectionPosition = middle + 1;
                    }
                    ++currentPositon;
                }

                while (currentPositon < end && collection[currentPositon].CompareTo(collection[currentPositon + 1]) > 0)
                {
                    Swap(collection, currentPositon, currentPositon + 1);
                    ++currentPositon;
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