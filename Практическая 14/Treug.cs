using System;
using System.Collections.Generic;
using System.Text;

namespace Практическая
{
    internal class Treug:Figura
    {
        public string tip;
        public Treug(string t, double v, double d) : base(v, d)
        {
        tip = t;
        }
        public string inf()
        {
            return "Тип треугольника:" + tip;
        }
    }
}
