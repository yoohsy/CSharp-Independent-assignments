using System;
using System.Collections.Generic;
using System.Text;

namespace Практическая
{
    internal class Figura
    {
        protected double visota;
        protected double dlina;
        protected Figura(double v, double d )
        {
            visota = v;
            dlina = d;
        }
        public string pl()
        {
            return (visota * dlina).ToString();
        }
    }
}
