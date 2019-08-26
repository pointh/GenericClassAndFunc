using System;
using System.Collections.Generic;
using System.Text;

namespace GenericClassAndFunc
{
    public class SomeGenericMethods
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T x;
            x = a;
            a = b;
            b = x;
        }

        public static bool FirstIsBigger<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) > 0;
        }

        public static bool FirstIsBigger<T, U>(T a, U b) where T : ISizable where U : ISizable
        {
            return a.Size > b.Size;
        }

    }
}
