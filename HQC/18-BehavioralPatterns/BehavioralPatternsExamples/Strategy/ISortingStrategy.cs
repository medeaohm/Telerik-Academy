namespace Strategy
{
    using System.Collections.Generic;

    public interface ISortingStrategy
    {
        void Sort<T>(List<T> dataToBeSorted);
    }
}
