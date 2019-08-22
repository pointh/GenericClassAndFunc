using System;
using System.Collections.Generic;
using System.Text;

namespace GenericClassAndFunc
{
    class Kruh : Shape, ISizable
    {
        public double radius;

        public double Size
        { get
            {
                return Math.PI * radius * radius;
            }
        }
    }
}
