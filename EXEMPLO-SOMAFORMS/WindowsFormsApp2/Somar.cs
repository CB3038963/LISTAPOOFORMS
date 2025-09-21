using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Somar
    {
        private double n1, n2, resultado;

        public Somar()
        {
            this.n1 = 0;
            this.n2 = 0;
        }
        public Somar(double n1, double n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }

        public void setN1(double n1)
        { this.n1 = n1; }

        public void setN2(double n2)
        { this.n2 = n2; }
        
        
        public double getN1()
        { return this.n1; }

        public double getN2() 
        { return this.n2; }

        public double getResultado()
        { return this.resultado; }  

        public void calcular()
        {
            this.resultado = this.n1 + this.n2;
        }

    }
}
