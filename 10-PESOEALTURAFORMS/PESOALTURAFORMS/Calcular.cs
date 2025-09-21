using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PESOALTURAFORMS
{
    internal class Calcular
    {
        private double peso, altura, resultado;
        public Calcular() { this.peso = 0; this.altura = 0; }
        public Calcular(double peso, double altura) { this.peso = peso; this.altura = altura; }
        public void setPeso(double peso) { this.peso = peso; }  
        public void setAltura(double altura) { this.altura = altura; }  
        public double getResultado() { return this.resultado; }
        public void calculando() { this.resultado = this.peso / (Math.Pow(this.altura, 2)); }
    }
}
