using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUADRADOFORMS
{
    internal class Aresta
    {
        private double aresta, area;
        
        public Aresta()
        {
            this.aresta = 0;
            this.area = 0;
        }
        public Aresta(double aresta)
        {
            this.aresta = aresta;  
        }
        public void setAresta(double aresta)
        {
            this.aresta = aresta;
        }
        public double getArea()
        {
            return this.area;
        }
        public void calcular()
        {
            this.area = Math.Pow(this.aresta,2);
        }

    }
}
