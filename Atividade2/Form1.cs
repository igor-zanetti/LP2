using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numero1, numero2, resultado;

            numero1 = Convert.ToInt32(txtNumero1.Text);
            numero2 = Convert.ToInt32(txtNumero2.Text);

            resultado = numero1 / numero2;

            txtResultado.Text = resultado.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtResultado.Clear();

            txtNumero1.Focus();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            int numero1, numero2, resultado;

            numero1 = Convert.ToInt32(txtNumero1.Text);
            numero2 = Convert.ToInt32(txtNumero2.Text);

            resultado = numero1 + numero2;

            txtResultado.Text = resultado.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int numero1, numero2, resultado;

            numero1 = Convert.ToInt32(txtNumero1.Text);
            numero2 = Convert.ToInt32(txtNumero2.Text);

            resultado = numero1 * numero2;

            txtResultado.Text = resultado.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            int numero1, numero2, resultado;

            numero1 = Convert.ToInt32(txtNumero1.Text);
            numero2 = Convert.ToInt32(txtNumero2.Text);

            resultado = numero1 / numero2;

            txtResultado.Text = resultado.ToString();

        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
