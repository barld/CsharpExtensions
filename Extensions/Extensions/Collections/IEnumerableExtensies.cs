using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions.Collections
{
    public static class IEnumerableExtensies
    {
        public static IEnumerable<T> Add<T>(this IEnumerable<T> nummerable, T value)
        {
            return nummerable.Concat(new[] { value });          
        }

        public static void test()
        {
            new int[1].Add(5);
        }
    }
}
