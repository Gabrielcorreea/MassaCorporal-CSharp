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
        private object txtN2;

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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n1 = 0;
            double n2 = 0;
            // Variáveis para armazernar os valores dos campos:
            if (txtN1.Text != "" && txtNumero2.Text != "")
            {
                n1 = double.Parse(txtN1.Text);
                n2 = double.Parse(txtNumero2.Text);
            }


            double resultado = 0;

            // Verificar qual está marcado:
            if (rbSomar.Checked)
            {
                resultado = n1 + n2;
            }
            else if (rbSubtrair.Checked)
            {
                resultado = n1 - n2;
            }
            else if (rbMultiplicar.Checked)
            {
                if (n2 == 0)
                {
                    MessageBox.Show("Impossível dividir por 0");
                }
                else
                {
                    resultado = n1 * n2;
                }
            }
            else if (rbDividir.Checked)
            {
                resultado = n1 / n2;
            }
            else
            {
                MessageBox.Show("Escolha uma opção, frango");
            }
            // Mostrar o valor no lblResultado:
            lblResultado.Text = resultado.ToString();
        }

        private void txtN1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumero1_Load(object sender, EventArgs e)
        {

        }
    }
}