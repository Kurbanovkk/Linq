using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal static class IEnumerableExtensions
    {
        public static IEnumerable<T> Top<T>(this IEnumerable<T> source, int percentage)
        {
            if (percentage < 1 || percentage > 100)
            {
                throw new ArgumentException("Число должно быть от 1 до 100.");
            }

            int count = (int)Math.Ceiling(source.Count() * percentage / 100.0);
            return source.OrderByDescending(item => item).Take(count);
        }

        public static IEnumerable<T> Top<T, TKey>(this IEnumerable<T> source, int percentage, Func<T, TKey> keySelector)
        {
            if (percentage < 1 || percentage > 100)
            {
                throw new ArgumentException("Число должно быть от 1 до 100.");
            }

            int count = (int)Math.Ceiling(source.Count() * percentage / 100.0);
            return source.OrderByDescending(keySelector).Take(count);
        }
    }
}
