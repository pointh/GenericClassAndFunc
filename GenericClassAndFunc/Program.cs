using System;

namespace GenericClassAndFunc
{
    class Program
    {
        
        static void Main()
        {
            Console.WriteLine("Hello World!");
            int ix = 0, iy = 4;
            double dx = 2.1, dy = 3.5;

            Console.WriteLine($"{ix}, {iy}, první je větší: {SomeGenericMethods.FirstIsBigger(ix, iy)}");
            Console.WriteLine($"{dx}, {dy}, první je větší: {SomeGenericMethods.FirstIsBigger(dx, dy)}");

            SomeGenericMethods.Swap(ref ix, ref iy);
            SomeGenericMethods.Swap(ref dx, ref dy);

            Console.WriteLine("\nPo volání Swap:");

            Console.WriteLine($"{ix}, {iy}, první je větší: {SomeGenericMethods.FirstIsBigger(ix, iy)}");
            Console.WriteLine($"{dx}, {dy}, první je větší: {SomeGenericMethods.FirstIsBigger(dx, dy)}");

            Console.ReadLine();

            Ctverec c = new Ctverec { strana = 12.0 };
            Kruh k = new Kruh { radius = 14.0 };

            Console.WriteLine($"{c}, {k}, první tvar {(SomeGenericMethods.FirstIsBigger(c, k) ? "je" : "není")} větší.");
        }
    }
}
