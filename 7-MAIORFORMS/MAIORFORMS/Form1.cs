using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAIORFORMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            Comparar comparar = new Comparar(double.Parse(txtN1.Text),double.Parse(txtN2.Text));
            comparar.calculando();
            lblMaior.Text = comparar.getMaior().ToString();
        }
    }
}
