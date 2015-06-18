namespace ExtensionMethods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class IEnumerableExtensions
    {
        public static T IEnumerableSum<T>(this IEnumerable<T> iEnumT) where T : struct
        {
            T sum = (dynamic)0;

            foreach (var item in iEnumT)
            {
                sum += (dynamic)item;
            }
            return sum;
        }

        public static T IEnumerableProduct<T>(this IEnumerable<T> iEnumT) where T : struct
        {
            T product = (dynamic)1;

            foreach (var item in iEnumT)
            {
                product *= (dynamic)item;
            }
            return product;
        }

        public static T IEnumerableMin<T>(this IEnumerable<T> iEnumT) where T : struct
        {
            T min = iEnumT.First();

            foreach (var item in iEnumT)
            {
                if ((dynamic)item < min)
                {
                    min = (dynamic)item;
                }
            }
            return min;
        }

        public static T IEnumerableMax<T>(this IEnumerable<T> iEnumT) where T : struct
        {
            T max = iEnumT.First();

            foreach (var item in iEnumT)
            {
                if ((dynamic)item > max)
                {
                    max = (dynamic)item;
                }
            }
            return max;
        }

        public static T IEnumerableAverage<T>(this IEnumerable<T> iEnumT) where T : struct
        {
            T sum = (dynamic)0;

            foreach (var item in iEnumT)
            {
                sum += (dynamic)item;
            }
            return sum/(dynamic)iEnumT.Count();
        }
    }
}
