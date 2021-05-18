using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAtividade8
{
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20];
            string auxiliar = "";

            for (int i = 0; i < vetor.Length; i++)
            {
                auxiliar = Interaction.InputBox("Digite um número para a posição: " + (i + 1).ToString() + "\n" + "Entrada de dados: ");

                if (!int.TryParse(auxiliar, out vetor[i]))
                {
                    MessageBox.Show("Valor inválido.");
                    i--;
                }
            }

            auxiliar = "";

            /*for (int i = vetor.Length - 1; i >= 0; i--)
            {
                auxiliar += vetor[i] + "\n";
            }*/
            Array.Reverse(vetor);

            for (int i = 0; i<vetor.Length; i++)
            {
                auxiliar += vetor[i] + "\n";
            }

            MessageBox.Show(auxiliar);
        }
    }
}
