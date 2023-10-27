using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaTrianguloForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            double n1, n2, resultado;
            n1 = double.Parse(txtBase.Text);
            n2 = double.Parse(txtAltura.Text);

            resultado = (n1 * n2) / 2;

            txbResultado.Text = resultado.ToString();
        }
    }
}
