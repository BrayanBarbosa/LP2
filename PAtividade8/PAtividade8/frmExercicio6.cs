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
    public partial class frmExercicio6 : Form
    {
        public frmExercicio6()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            int linhas = 20;// mudar pra 20 ok
            int colunas = 3;

            double[,] notasAlunos = new double[linhas, colunas];
            double[] media = new double[linhas];

            for (int i = 0; i < linhas; i++)
            {
                media[i] = 0;

                for (int j = 0; j < colunas; j++)
                {
                    var leitura = Interaction.InputBox($"Nota #{j + 1}", $"Notas do Aluno {i + 1}");

                    if(!double.TryParse(leitura, out notasAlunos[i, j]))
                    {
                        MessageBox.Show("Erro");
                        j--;
                        continue;
                    }

                    media[i] += notasAlunos[i, j];
                }

                media[i] = media[i] / 3.0;
            }

            string saida = "";

            for (int i = 0; i < linhas; i++)
            {
                saida += $"Aluno {i+1} | Média: {media[i]:N2} \n";
            }

            MessageBox.Show(saida, "Médias");
        }
    }
}
