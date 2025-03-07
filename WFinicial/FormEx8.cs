using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFinicial
{
    public partial class FormEx8 : Form
    {
        public FormEx8()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double resultado,numero1, numero2 = 0;

            bool ehValidoNum1 = double.TryParse(txtNum1.Text, out numero1);
            bool ehValidoNum2 = double.TryParse(txtNum2.Text, out numero2); // se der true vai converter o valor para as variáveis. vai tentar converter para double vai dar true.

            if (ehValidoNum1 == false || ehValidoNum2 == false)
            {
                MessageBox.Show("Os valores digitados não são um número",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (rdbSoma.Checked == true)
                {
                    resultado = numero1 + numero2;
                    String mensagem = $"A soma de {numero1} + {numero2} = {resultado}";
                    MessageBox.Show(mensagem, "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (rdbSubtracao.Checked == true)
                {
                    resultado = numero1 - numero2;
                    String mensagem = $"A subtração de {numero1} - {numero2} = {resultado}";
                    MessageBox.Show(mensagem, "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (rdbMultiplicacao.Checked == true)
                {
                    resultado = numero1 * numero2;
                    String mensagem = $"A Múltiplicação de {numero1} * {numero2} = {resultado}";
                    MessageBox.Show(mensagem, "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (rdbDivisao.Checked == true)
                {
                    if (numero2 == 0)
                    {
                        MessageBox.Show("O dominador não pode ser zero!",
                       "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        resultado = numero1 / numero2;
                        String mensagem = $"A Divisão de {numero1} / {numero2} = {resultado}";
                        MessageBox.Show(mensagem, "Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                else if (rdbPotenciacao.Checked == true)
                {
                    resultado = Math.Pow(numero1, numero2);
                    String mensagem = $"A Potênciação de {numero1} e {numero2} = {resultado}";
                    MessageBox.Show(mensagem, "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (rdbRadiciacao.Checked == true)
                {
                    if (numero2 == 0)
                        resultado = 1;
                    else

                        resultado = Math.Pow(numero1, (1 / numero2));
                    String mensagem = $"A Raiz de {numero1} / {numero2} = {resultado}";
                    MessageBox.Show(mensagem, "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Você deve escolher uma operação", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
