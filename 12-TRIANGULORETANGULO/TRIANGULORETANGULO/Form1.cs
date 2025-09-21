using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRIANGULORETANGULO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Verificar v = new Verificar(double.Parse(txtLadoA.Text), double.Parse(txtLadoB.Text), double.Parse(txtLadoC.Text));
            v.verificando();

            if (Math.Pow(double.Parse(txtLadoA.Text), 2) == Math.Pow(double.Parse(txtLadoB.Text), 2) + Math.Pow(double.Parse(txtLadoC.Text), 2) ||
              Math.Pow(double.Parse(txtLadoB.Text), 2) == Math.Pow(double.Parse(txtLadoA.Text), 2) + Math.Pow(double.Parse(txtLadoC.Text), 2) ||
              Math.Pow(double.Parse(txtLadoC.Text), 2) == Math.Pow(double.Parse(txtLadoA.Text), 2) + Math.Pow(double.Parse(txtLadoB.Text), 2))
            {
                lblResultado.Text = "FORMA UM TRIANGULO RETANGULO";
            }
            else { lblResultado.Text = "NAO FORMA UM TRIANGULO RETANGULO"; }

        }
    }
}
