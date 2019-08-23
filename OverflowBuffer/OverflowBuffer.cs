using System;
using System.Collections.Generic;
using System.Text;

namespace OverflowBufferNS
{
    class OverflowBuffer<T>
    {
        T[] buff;
        int position;
        int count;

        public OverflowBuffer(int size = 10)
        {
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

        public void List()
        {
            Console.WriteLine(buff[position]);

            int i = (position != 0) ? position-1 : buff.Length-1;
            while ( i != (count%buff.Length)-1 )
            {
                Console.WriteLine(buff[i]);
                if (i == 0)
                    i = buff.Length;
                i--;
            }
        }
    }
}
