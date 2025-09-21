using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_AREADOTRIANGULOFORMS
{
    internal class Calcular
    {
        private double baze, h, a;
        public Calcular()
        {
            this.baze = 0;
            this.h = 0;
            this.a = 0;
        }
        public Calcular(double baze, double h)
        {
            this.baze = baze;
            this.h = h;
        }
        public void setBase(double baze)
        { this.baze = baze; }
        public void setH(double h)
        { this.h = h; }

        public double getArea()
        { return this.a; }

        public void calcular()
        {
            this.a = (this.h * this.baze)/2;
            
        }
    }
}
