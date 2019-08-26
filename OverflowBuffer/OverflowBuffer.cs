using System;
using System.Collections.Generic;
using System.Text;

namespace OverflowBufferNS
{
    public class OverflowBuffer<T>
    {
        readonly T[] buff;
        int position;
        int count;
        public int Size { get; }

        public OverflowBuffer(int size = 10)
        {
            Size = size;
            buff = new T[size];
            position = -1;
            count = 0;
        }

        public void Add(T x)
        {
            buff[++position] = x;
            count++;
            if (position == buff.Length - 1)
                position = -1;
        }

        public void Add(T[] xArr)
        {
            foreach (var x in xArr)
                Add(x);
        }

        public void Print()
        {
            Console.WriteLine(buff[position]);

            int i = (position != 0) ? position-1 : buff.Length-1;
            while ( i != (count%buff.Length)-1 )
            {
                Console.WriteLine(buff[i]);
                if (i == 0)
                    i = buff.Length - 1;
                else
                    i--;
            }
        }

        public List<T> GetList()
        {
            List<T> lst = new List<T>();

            lst.Add(buff[position]);
   
            int i = (position != 0) ? position - 1 : buff.Length - 1;
            while (i != (count % buff.Length) - 1)
            {
                lst.Add(buff[i]);
                if (i == 0)
                    i = buff.Length - 1;
                else
                    i--;
            }

            return lst;
        }
    }
}
