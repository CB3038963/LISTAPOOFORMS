using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOLARFORMS
{
    internal class Converter
    {
        private double dolar, real;
        public Converter() { this.dolar = 0; }
        public Converter(double dolar) { this.dolar = dolar; }
        public void setDolar(double dolar) { this.dolar = dolar; }
        public double getReal() { return this.real; }
        public void converter() { this.real = this.dolar * 5; }
    }
}
