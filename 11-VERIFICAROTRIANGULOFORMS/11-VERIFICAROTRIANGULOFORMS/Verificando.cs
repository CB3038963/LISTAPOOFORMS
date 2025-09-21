using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_VERIFICAROTRIANGULOFORMS
{
    internal class Verificando
    {
        private double a, b, c, r;
        //construtores
        public Verificando()
        { this.a = 0; this.b = 0; this.c = 0; }
        public Verificando(double a, double b, double c)
        { this.a = a; this.b = b; this.c = c; }
        //set
        public void SetA(double a) { this.a = a; }
        public void SetB(double b) { this.b = b; }
        public void SetC(double c) { this.c = c; }
        //get
        public double GetA(double a) { return this.a; }
        public double GetB(double b) { return this.b; }
        public double GetC(double c) { return this.c; }

        //resultado

        public void resolucao()
        {
            if (this.a < this.b + this.c && this.b < this.c + this.a && this.c < this.a + this.b)
            {
                if (this.a == this.b && this.a == this.c) { Console.WriteLine("Forma um triangulo Equilatero"); }
                if (this.a != this.b && this.a != this.c && this.c != this.b) { Console.WriteLine("Forma um triangulo Escaleno"); }
                if (this.a == this.b && this.a != this.c || this.b == this.c && this.c != this.a ||
                    this.c == this.a && this.a != this.b) { }

            }
        }

    }
}
