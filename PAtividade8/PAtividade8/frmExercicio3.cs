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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int[] quantidade = new int[10];
            double[] valor = new double[10];

            double total = 0;

            for (int venda = 0; venda < quantidade.Length; venda++)
            {
                var leitura = Interaction.InputBox("Quantidade vendida:", $" Produto #{venda+1} ");

                if (!int.TryParse(leitura, out quantidade[venda]))
                {
                    MessageBox.Show("Erro", "Atenção");
                    venda--;
                    continue;
                }

                leitura = Interaction.InputBox("Valor Unitário:", $" Produto #{venda +1} ");

                if(!double.TryParse(leitura, out valor[venda]))
                {
                    MessageBox.Show("Erro", "Atenção");
                    venda--;
                    continue;
                }

                total += quantidade[venda] * valor[venda];
            }

            MessageBox.Show(total.ToString("N2"), "Valor da Venda Mensal");
            //MessageBox.Show("Total faturado = " + total);
        }
    }
}
