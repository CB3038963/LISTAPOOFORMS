using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUADRADODIAGONAL
{
    internal class Calcular
    {
        private double diagonal, area;

        public Calcular()
        {
            this.diagonal = 0;
            this.area = 0;
        }
        public Calcular(double diagonal)
        {
            this.diagonal = diagonal;
        }

        public void setDiagonal(double diagonal)
        {
            this.diagonal = diagonal;  
        }
        public double getArea()
        {
            return this.area;
        }

        public void calcular()
        {
            this.area = (Math.Pow(this.diagonal,2))/2;
        }
    }
}
