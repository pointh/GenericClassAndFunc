using System;
using System.Collections.Generic;
using System.Text;

namespace GenericClassAndFunc
{
    class Ctverec : ISizable
    {
        public double strana;

        public double Size
        {
            get
            {
                return strana * strana;
            }
        }

        public override string ToString()
        {
            return $"Čtverec o ploše {Size,10:F3}";
        }
    }
}
