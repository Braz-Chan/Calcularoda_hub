using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcularoda_hub
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtBxResultado.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtBxResultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtBxResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtBxResultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtBxResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtBxResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtBxResultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtBxResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtBxResultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtBxResultado.Text += "9";
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtBxResultado.Text, CultureInfo.InvariantCulture);
            txtBxResultado.Text = "";
            operacao = "SOMA";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtBxResultado.Text, CultureInfo.InvariantCulture);

            if (operacao == "SOMA")
            {
                txtBxResultado.Text = Convert.ToString(valor1 + valor2);
            }
            if (operacao == "SUB")
            {
                txtBxResultado.Text = Convert.ToString(valor1 - valor2);
            }
            if (operacao == "VEZ")
            {
                txtBxResultado.Text = Convert.ToString(valor1 * valor2);
            }
            if(operacao == "DIV")
            {
                txtBxResultado.Text = Convert.ToString(valor1 / valor2);
            }
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            txtBxResultado.Text += ".";
        }

        private void btnVeze_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtBxResultado.Text, CultureInfo.InvariantCulture);
            txtBxResultado.Text = "";
            operacao = "VEZ";
        }

        private void btnDivi_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtBxResultado.Text, CultureInfo.InvariantCulture);
            txtBxResultado.Text = "";
            operacao = "DIV";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtBxResultado.Text = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtBxResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
        }

        private void btnMenus_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtBxResultado.Text, CultureInfo.InvariantCulture);
            txtBxResultado.Text = "";
            operacao = "SUB";
        }
    }
}
