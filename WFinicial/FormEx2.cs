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
    public partial class FormEx2 : Form
    {
        public FormEx2()
        {
            InitializeComponent();
        }

        private void btnEscolher_Click(object sender, EventArgs e)
        {
        byte opcao = byte.Parse(txtDiaSemana.Text); // Para tratar pode usar! ou ??"" para usar um espaço caso o resultado seja zero.

            switch (opcao)
            {
                case 1:
                    MessageBox.Show("Domingo");

                    break;
                case 2:
                    MessageBox.Show("Segunda-Feira");
                    break;
                case 3:
                    MessageBox.Show("Terça-Feira");

                    break;
                case 4:
                    MessageBox.Show("Quarta-Feira");
                    break;
                case 5:
                    MessageBox.Show("Quinta-Feira");
                    break;
                case 6:
                    MessageBox.Show("Sexta-Feira");
                    break;
                case 7:
                    MessageBox.Show("Sábado");
                    break;
                default:
                    break;
            }
        }   
    }
}
