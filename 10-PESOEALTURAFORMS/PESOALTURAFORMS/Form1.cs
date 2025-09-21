using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PESOALTURAFORMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calcular ideal = new Calcular(double.Parse(txtPeso.Text),double.Parse(txtAltura.Text));
            ideal.calculando();
            if (ideal.getResultado() < 20) { lblResultado.Text = "ABAIXO DO PESO"; }
            else if (ideal.getResultado() >= 25) { lblResultado.Text = "ACIMA DO PESO"; }
            else { lblResultado.Text = "PESO IDEAL"; }
        }
    }
}
