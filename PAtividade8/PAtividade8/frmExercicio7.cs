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
    public partial class frmExercicio7 : Form
    {
        public frmExercicio7()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            int N = 8; //008

            string[] nomes = new string[N];
            int[] caracteres = new int[N];

            for (int i = 0; i < N; i++)
            {
                var nome = Interaction.InputBox($"Nome da {i + 1} pessoa:", "Registro de Nomes");
                int chars = 0;

                nomes[i] = nome;

                foreach (char letra in nome)
                {
                    if (!char.IsWhiteSpace(letra))
                    {
                        chars++;
                    }
                }

                caracteres[i] = chars;
            }

            for(int i = 0; i < N; i++)
            {
                listNomes.Items.Add($"O nome: {nomes[i]} tem {caracteres[i]} caracteres. \n");
            }
        }
    }
}
