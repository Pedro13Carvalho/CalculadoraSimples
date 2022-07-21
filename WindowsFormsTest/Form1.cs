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

namespace WindowsFormsTest
{
    public partial class Form1 : Form
    {
        double resultado = 0, valor1 = 0, valor2 = 0;
        string operacao = "x";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teste supimpa parte two");
        }

        private void Teste_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teste supimpa");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += ".";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "2";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "6";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "5";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            lblSinal.Text = "-";
            operacao = "-";
            valor1 = double.Parse(txtOperacao.Text, CultureInfo.InvariantCulture);
            txtOperacao.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            lblSinal.Text = "*";
            operacao = "*";
            valor1 = double.Parse(txtOperacao.Text, CultureInfo.InvariantCulture);
            txtOperacao.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            lblSinal.Text = "+";
            operacao = "+";
            valor1 = double.Parse(txtOperacao.Text, CultureInfo.InvariantCulture);
            txtOperacao.Clear();
        }

        private void txtOperacao_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSinal_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtOperacao.Text = Convert.ToString(Math.PI).Replace(",",".");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            lblSinal.Text = "x^y";
            operacao = "x^y";
            valor1 = double.Parse(txtOperacao.Text, CultureInfo.InvariantCulture);
            txtOperacao.Clear();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            txtOperacao.Clear();
            valor1 = 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtOperacao.Clear();
            valor1 = 0;
            valor2 = 0;
            operacao = "";
            lblSinal.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            lblSinal.Text = "/";
            operacao = "/";
            valor1 = double.Parse(txtOperacao.Text, CultureInfo.InvariantCulture);
            txtOperacao.Clear();
        }
        private void button20_Click(object sender, EventArgs e)
        {
            valor2 = double.Parse(txtOperacao.Text, CultureInfo.InvariantCulture);
            switch (operacao)
            {
                case "+":
                    txtOperacao.Text = Convert.ToString(valor1 + valor2);
                    break;

                case "-":
                    txtOperacao.Text = Convert.ToString(valor1 - valor2);
                    break;

                case "*":
                    txtOperacao.Text = Convert.ToString(valor1 * valor2);
                    break;

                case "/":
                    txtOperacao.Text = Convert.ToString(valor1 / valor2);
                    break;

                case "x^y":
                    {
                        int i = 1;
                        resultado = valor1;
                        while(i != valor2)
                        {
                            resultado *= valor1;
                            i++;
                        }
                        txtOperacao.Text = Convert.ToString(resultado);

                    }
                    break;

                default:
                    MessageBox.Show("Erro na operação");
                    break;
            }
        }
    }
}
