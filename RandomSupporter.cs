using System;
using System.Collections.Generic;
using System.Linq;
namespace NetCoreSystemEnvHelper
{
    public static class RandomSupporter
    {
        static Random random = new Random ();
        static char[] constant = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        public static T RandomSelect<T> (this IEnumerable<T> enumerable)
        {
            return enumerable.ElementAt (random.Next (enumerable.Count ()));
        }
        public static char GetRandomChar ()
        {
            return constant.RandomSelect ();
        }
        public static char GetRandomLetter ()
        {
            return constant.ElementAt (random.Next (10, 36));
        }

    }
}