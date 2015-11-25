namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class QuickSorter<T> : ISorter<T> where T : IComparable<T>
    {
        private IList<T> array;

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

            this.array = collection;
            QuickSort(0, collection.Count - 1);
        }

        private void QuickSort(int lelftValue, int rightValue)
        {
            if (rightValue - lelftValue <= 0)
            {
                return;
            }

            int pivotIndex = Partition(array, array[rightValue], lelftValue, rightValue);

            QuickSort(lelftValue, pivotIndex - 1);
            QuickSort(pivotIndex + 1, rightValue);
        }

        private int Partition(IList<T> collection, T pivot, int leftIndex, int rightIndex)
        {
            int currentLeft = leftIndex;
            int currentRight = rightIndex - 1;

            while (true)
            {
                while (this.array[currentLeft].CompareTo(pivot) < 0)
                {
                    currentLeft++;
                }

                while (currentRight > 0 && this.array[currentRight].CompareTo(pivot) > 0)
                {
                    currentRight--;
                }

                if (currentLeft >= currentRight)
                {
                    break;
                }

                this.Swap(collection, currentLeft, currentRight);
            }

            this.Swap(collection, currentLeft, rightIndex);

            return currentLeft;
        }

        private void Swap(IList<T> collection, int firstIndex, int secondIndex)
        {
            var smallest = collection[firstIndex];
            collection[firstIndex] = collection[secondIndex];
            collection[secondIndex] = smallest;
        }
    }
}

