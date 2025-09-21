using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAIOROUIDENTICOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            Comparar verificar = new Comparar(double.Parse(txtN1.Text),double.Parse(txtN2.Text));
            verificar.calculando();

            if (verificar.getMaior() == verificar.getMenor())
            {
                lblResultado.Text = "NUMEROS IDENTICOS";
            }
            else
            {
                lblResultado.Text = verificar.getMaior().ToString();
            }
            
            
        }
    }
}
