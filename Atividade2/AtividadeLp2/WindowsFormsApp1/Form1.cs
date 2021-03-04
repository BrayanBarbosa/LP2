using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double peso, altura, resultado;

        private void BLimp_Click(object sender, EventArgs e)
        {
            TextAlt.Clear();
            TextPeso.Clear();
            TextAlt.Focus();
        }

        private void BSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(TextAlt.Text, out altura) ||!double.TryParse(TextPeso.Text, out peso))
            {
                MessageBox.Show("Valores Inválidos!");
            }
            else
            {
                if (RadFem.Checked)
                {
                    resultado = (62.1 * altura) - 44.7;
                    if (resultado == peso || resultado == peso + 1 || resultado == peso -1)
                    {
                        MessageBox.Show("Você está no peso ideal. parabéns");
                    }
                    else if (resultado < peso)
                        {
                            MessageBox.Show("Você está acima do peso, Procure uma academia");
                        }
                    else
                    {
                        MessageBox.Show("Você está abaixo do peso, Procure um nutricionista!");
                    }

                    
                }
                else
                {
                    resultado = (72.7 * altura) - 58;
                    if (resultado == peso)
                    {
                        MessageBox.Show("Você está no peso ideal. parabéns");
                    }
                    else if (resultado < peso)
                    {
                        MessageBox.Show("Você está acima do peso, Procure uma academia");
                    }
                    else
                    {
                        MessageBox.Show("Você está abaixo do peso, Procure um nutricionista!");
                    }
                }
            }
        }
       
    }
}
