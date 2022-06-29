using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MassaCorporal
{
    public partial class txtNumero1 : Form
    {
        

        public txtNumero1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
           

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso;
            double altura;
            double imc;

            peso = double.Parse(txtPeso.Text);
            altura = double.Parse(txtAltura.Text);
            imc = peso / (altura * altura);
            txtimc.Text = Math.Round(imc, 2).ToString();



           if (imc < 18.5)
            {
                txtResultado.Text = "Abaixo do peso";
                txtResultado.ForeColor = Color.Red;
            }
            else if (imc > 18.6 && imc < 24.9)
            {
                txtResultado.Text = "Peso ideal";
                txtResultado.ForeColor = Color.Green;
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                txtResultado.Text = "Levemente acima do peso";
                txtResultado.ForeColor = Color.Red;
            }
            else if (imc >= 30 && imc <= 34.9)
            {
                txtResultado.Text = "Obesidade grau I";
                txtResultado.ForeColor = Color.Red;
            }
            else if (imc >= 35 && imc <= 39.9)
            {
                txtResultado.Text = "Obesidade grau II";
                txtResultado.ForeColor = Color.Red;

            }
            else if (imc >= 40)
            {
                txtResultado.Text = "Obesidade grau III";
                txtResultado.ForeColor = Color.Red;
            }

            txtimc.Text = imc.ToString();
        }
    }
}