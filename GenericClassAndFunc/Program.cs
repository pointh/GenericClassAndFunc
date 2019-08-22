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

        public static bool FirstIsBigger<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) > 0;
        }

        public static bool FirstShapeIsBigger<T, U>(T a, U b) where T: Shape, ISizable where U: Shape, ISizable
        {
            return a.Size > b.Size;
        }

        static void Main()
        {
            Console.WriteLine("Hello World!");
            int ix = 0, iy = 4;
            double dx = 2.1, dy = 3.5;

            Console.WriteLine($"{ix}, {iy}, první je větší: {FirstIsBigger(ix, iy)}");
            Console.WriteLine($"{dx}, {dy}, první je větší: {FirstIsBigger(dx, dy)}");

            Swap(ref ix, ref iy);
            Swap(ref dx, ref dy);

            Console.WriteLine("\nPo volání Swap:");

            Console.WriteLine($"{ix}, {iy}, první je větší: {FirstIsBigger(ix, iy)}");
            Console.WriteLine($"{dx}, {dy}, první je větší: {FirstIsBigger(dx, dy)}");

            Console.ReadLine();

            Ctverec c = new Ctverec { strana = 12.0 };
            Kruh k = new Kruh { radius = 4.0 };

            Console.WriteLine($"{c}, {k}, první je větší: {FirstShapeIsBigger(c, k)}");

            Console.ReadLine();
        }
    }
}
