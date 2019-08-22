using System;

namespace GenericClassAndFunc
{
    class Program
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T x;
            x = a;
            a = b;
            b = x;
        }

        public bool IsBigger<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) > 0;
        }
        static void Main()
        {
            Console.WriteLine("Hello World!");
            int ix = 0, iy = 4;
            double dx = 2.1, dy = 3.5;

            Swap(ref ix, ref iy);
            Swap(ref dx, ref dy);

            Console.WriteLine($"{ix}, {iy}");
            Console.WriteLine($"{dx}, {dy}");

            Console.ReadLine();
        }
    }
}
