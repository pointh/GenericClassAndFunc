using System;
using Xunit;
using Xunit.Abstractions;
using OverflowBufferNS;
using System.Collections.Generic;
using GenericClassAndFunc;
using System.Diagnostics;
using System.Drawing;

namespace XUnitTestGeneric
{
    public class UnitTestOverflowBuffer
    {
        private readonly ITestOutputHelper output;

        public UnitTestOverflowBuffer(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void TestOverflowBufferInt()
        {
            OverflowBuffer<int> ovInt = new OverflowBuffer<int>();
            int[] iArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            
            ovInt.Add(iArr);
            List<int> li = ovInt.GetList();

            Assert.Equal(iArr[iArr.Length - 1], li[0]);
            Assert.Equal(iArr[iArr.Length - ovInt.Size], li[ovInt.Size-1]);
        }

        [Fact]
        public void TestOverflowBufferDouble()
        {
            OverflowBuffer<double> ovDouble = new OverflowBuffer<double>();
            double[] dArr = { 1.2, 2.3, 4.5, 6.3, 6, 7, 8, 9, 10, 11, 12, 13 };

            ovDouble.Add(dArr);
            List<double> ld = ovDouble.GetList();
            Assert.Equal(dArr[dArr.Length-1], ld[0]);
            Assert.Equal(dArr[dArr.Length - ovDouble.Size], ld[ovDouble.Size - 1]);
        }

        [Fact]
        public void TestOverflowBufferDoubleWithSize7()
        {
            OverflowBuffer<double> ovDouble = new OverflowBuffer<double>(7);
            //                  0    1    2    3  4  5  6  7   8   9  10  11 
            //                                       6  5  4   3   2   1   0
            double[] dArr = { 1.2, 2.3, 4.5, 6.3, 6, 7, 8, 9, 10, 11, 12, 13 };

            ovDouble.Add(dArr);
            List<double> ld = ovDouble.GetList();
            Assert.Equal(dArr[dArr.Length - 1], ld[0]);
            output.WriteLine($"{dArr[dArr.Length - 1]} ... {ld[0]}");
            Assert.Equal(dArr[dArr.Length - ovDouble.Size], ld[ovDouble.Size - 1]);
            output.WriteLine($"{dArr[dArr.Length - ovDouble.Size]} ... {ld[ovDouble.Size - 1]}");
        }

        [Fact]
        public void TestSwapObjects()
        {
            Point p = new Point(20, 30);
            Point q = new Point(33, 77);

            SomeGenericMethods.Swap(ref p, ref q);

            Assert.Equal(33, p.X);
            Assert.Equal(30, q.Y);

            output.WriteLine($"P: {p.X}, {p.Y} \nQ: {q.X}, {q.Y}");
        }
    }
}
