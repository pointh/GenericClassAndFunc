using System;
using OverflowBufferNS;

namespace OverflowBufferNS
{
    class Program
    {
        static void Main(string[] args)
        {
            OverflowBuffer<int> ovInt = new OverflowBuffer<int>();
            OverflowBuffer<double> ovDouble = new OverflowBuffer<double>();


            int[] iArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            double[] dArr = { 1.2, 2.3, 4.5, 6.3 };

            ovInt.Add(iArr);
            ovInt.List();

            ovDouble.Add(dArr);
            ovDouble.List();
        }
    }
}
