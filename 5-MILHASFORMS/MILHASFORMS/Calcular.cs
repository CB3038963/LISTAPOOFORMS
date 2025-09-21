using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MILHASFORMS
{
    internal class Calcular
    {
        private double milha, metros;
        private double maritima = 1852;
        public Calcular() { this.milha = 0; }
        public Calcular (double milha) { this.milha = milha; }
        public void setMilha (double milha) {this.milha = milha; }
        public double getMetro() { return this.metros; }
        public void calcular() { this.metros =  this.milha * this.maritima; }
    }
}
