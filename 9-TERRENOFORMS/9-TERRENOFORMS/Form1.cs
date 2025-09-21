using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_TERRENOFORMS
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

            lblArea.Text = area.getArea().ToString();
            
            if(area.getArea() < 100) { lblTerreno.Text = "TERRENO PEQUENO"; }
            else { lblTerreno.Text = "TERRENO GRANDE"; }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
