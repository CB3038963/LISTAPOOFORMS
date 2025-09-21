using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace TRIANGULORETANGULO
{
    internal class Verificar
    {
        private double a, b, c;
        public Verificar() { this.a = 0;this.b = 0;this.c = 0; }
        public Verificar(double a, double b, double c) {this.a = a;this.b = b;this.c = c; } 
        public void setLadoA(double a) { this.a = a; }
        public void setLadoB(double b) { this.b = b; }
        public void setLadoC(double c) { this.c = c; }

        public void verificando() 
        {
            if (Math.Pow(this.a, 2) == Math.Pow(this.b, 2) + Math.Pow(this.c, 2) || Math.Pow(this.b, 2) == Math.Pow(this.a, 2) + Math.Pow(this.c, 2) || Math.Pow(this.c, 2) == Math.Pow(this.a, 2) + Math.Pow(this.a, 2))
            {}
            
        }
    }
}
