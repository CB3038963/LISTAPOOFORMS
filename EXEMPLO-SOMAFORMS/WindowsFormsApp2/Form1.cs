using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            Somar r = new Somar();

            r.setN1(double.Parse(txtn1.Text));
            r.setN2(double.Parse(txtn2.Text));

            r.calcular();    


            lblResultado.Text = r.getResultado().ToString();
        }
    }
}
