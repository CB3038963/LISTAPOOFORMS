using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AREADOTRIANGULOFORMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calcular area = new Calcular(double.Parse(txtBase.Text), double.Parse(txtAltura.Text));
            area.calculando();
            if(area.getArea() > 100) { lblResultado.Text = "TERRENO GRANDE"; }
            else { lblResultado.Text = "TERRENO PEQUENO"; }

            lblResultadoarea.Text = area.getArea().ToString();
        }
    }
}
