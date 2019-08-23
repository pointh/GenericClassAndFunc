using System;
using OverflowBufferNS;

namespace OverflowBufferNS
{
    class Program
    {
        static void Main(string[] args)
        {
            OverflowBuffer<int> ov = new OverflowBuffer<int>();

            int[] iArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            ov.Add(iArr);
            ov.List();
        }
    }
}
