using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_AREADORETANGULOFORMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            Calcular area = new Calcular(double.Parse(txtBase.Text), double.Parse(txtAltura.Text));
            area.calculando();

            lblResultado.Text = area.getArea().ToString();
        }
    }
}
