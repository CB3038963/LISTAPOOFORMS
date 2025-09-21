using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_TERRENOFORMS
{
    internal class Calcular
    {
        private double baze, altura, area;
        public Calcular() { this.baze = 0; this.altura = 0; }
        public Calcular(double baze, double altura) { this.baze = baze; ; this.altura = altura; }
        public void setBaze(double baze) { this.baze = baze; }
        public void setAltura(double altura) { this.altura = altura; }
        public double getArea() { return this.area; }
        public void calculando() { this.area = this.baze * this.altura; }
    }
}
