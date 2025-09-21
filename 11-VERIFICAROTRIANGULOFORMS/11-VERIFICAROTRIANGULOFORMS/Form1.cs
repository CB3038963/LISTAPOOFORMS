using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_VERIFICAROTRIANGULOFORMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            Verificando v = new Verificando(double.Parse(txtLadoA.Text), double.Parse(txtLadoB.Text), double.Parse(txtLadoC.Text));
            v.resolucao();

            if (double.Parse(txtLadoA.Text) < double.Parse(txtLadoB.Text) + double.Parse(txtLadoC.Text) &&
               double.Parse(txtLadoB.Text) < double.Parse(txtLadoA.Text) + double.Parse(txtLadoC.Text) &&
               double.Parse(txtLadoC.Text) < double.Parse(txtLadoA.Text) + double.Parse(txtLadoB.Text))

            {
                if (double.Parse(txtLadoA.Text) == double.Parse(txtLadoB.Text) &&
                   double.Parse(txtLadoA.Text) == double.Parse(txtLadoC.Text))
                { lblResultado.Text = "FORMA UM TRIANGULO EQUILATERO"; }

                if (double.Parse(txtLadoA.Text) != double.Parse(txtLadoB.Text) &&
                   double.Parse(txtLadoA.Text) != double.Parse(txtLadoC.Text) &&
                   double.Parse(txtLadoB.Text) != double.Parse(txtLadoC.Text))
                {
                    lblResultado.Text = "FORMA UM TRIANGULO ESCALENO";
                }

                if (double.Parse(txtLadoA.Text) == double.Parse(txtLadoB.Text) && double.Parse(txtLadoA.Text) != double.Parse(txtLadoC.Text) ||
                   double.Parse(txtLadoB.Text) == double.Parse(txtLadoC.Text) && double.Parse(txtLadoC.Text) != double.Parse(txtLadoA.Text) ||
                   double.Parse(txtLadoC.Text) == double.Parse(txtLadoA.Text) && double.Parse(txtLadoA.Text) != double.Parse(txtLadoB.Text))
                {
                    lblResultado.Text = "FORMA UM TRIANGULO ISOSCELES";
                }

            }

            else { lblResultado.Text = "ESSES VALORES NAO FORMAM UM TRIANGULO"; }
        }
    }
}
