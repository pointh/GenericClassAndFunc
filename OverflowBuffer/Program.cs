using System;
using System.Collections.Generic;
using OverflowBufferNS;

namespace OverflowBufferNS
{
    class Program
    {
        static void Main()
        {
            OverflowBuffer<int> ovInt = new OverflowBuffer<int>();
            OverflowBuffer<double> ovDouble = new OverflowBuffer<double>();


            int[] iArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            double[] dArr = { 1.2, 2.3, 4.5, 6.3, 6, 7, 8, 9, 10, 11, 12 };

            ovInt.Add(iArr);
            List<int> li = ovInt.GetList();
            ovInt.Print();

            ovDouble.Add(dArr);
            List<double> ld = ovDouble.GetList();
            ovDouble.Print();
        }
    }
}
