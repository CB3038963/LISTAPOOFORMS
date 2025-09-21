using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAIOROUIDENTICOS
{
    internal class Comparar
    {
        private double n1, n2, maior, menor;
        public Comparar()
        {
            this.n1 = 0;
            this.n2 = 0;
        }
        public Comparar(double n1, double n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }
        public void setN1(double n1) { this.n1 = n1; }
        public void setN2(double n2) { this.n2 = n2; }

        public double getMaior() { return this.maior; }
        public double getMenor() { return this.menor; }

        public void calculando()
        {
            if (this.n1 > this.n2) { this.maior = this.n1; this.menor = this.n2; }
            else { this.maior = this.n2; this.menor = this.n1; }
            
        }
    }
}
