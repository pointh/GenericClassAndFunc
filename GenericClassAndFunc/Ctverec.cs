using System;
using System.Collections.Generic;
using System.Text;

namespace GenericClassAndFunc
{
    class Ctverec : Shape, ISizable
    {
        public double strana;

        public double Size
        {
            get
            {
                return strana * strana;
            }
        }
    }
}
