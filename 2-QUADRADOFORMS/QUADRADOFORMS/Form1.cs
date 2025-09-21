using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUADRADOFORMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            Aresta h = new Aresta(double.Parse(txtAresta.Text));
            h.calcular();

            lblArea.Text = h.getArea().ToString();

        }
    }
}
