using System;
using System.Collections.Generic;
using System.Text;

namespace GenericClassAndFunc
{
    class Kruh : ISizable
    {
        public double radius;

        public double Size
        { get
            {
                return Math.PI * radius * radius;
            }
        }

        public override string ToString()
        {
            return $"Kruh o ploše {Size,10:F3}";
        }
    }
}
