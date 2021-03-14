using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Psalario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnVerificar_Click(object sender, EventArgs e)
        {
            lblmensagem.Visible = true;
            double salariobruto = 0;

            if ((txtnome.Text == "") || (txtnome.Text.Length < 5))
                MessageBox.Show("Nome Inválido");
            else if (!double.TryParse(maskedTextsalbrut.Text, out salariobruto))
                MessageBox.Show("Salário Invalido");
            else
            {
                double descontoInss = 0;
                double descontoIr = 0;
                double salarioFamilia = 0;
                double salarioliquido = 0;

                if (salariobruto <= 800.47)
                {
                    txtinss.Text = "7.65%";
                    descontoInss = 0.0765 * salariobruto;
                    txtDInss.Text = descontoInss.ToString("N2");
                }
                else if (salariobruto <= 1400.77)
                {
                    txtinss.Text = "9.00%";
                    descontoInss = 0.09 * salariobruto;
                    txtDInss.Text = descontoInss.ToString();
                }
                else if (salariobruto <= 1050.00)
                {
                    txtinss.Text = "8.65%";
                    descontoInss = 0.0865 * salariobruto;
                    txtDInss.Text = descontoInss.ToString("N2");
                }
                else if (salariobruto <= 1400.77)
                {
                    txtinss.Text = "11%";
                    descontoInss = 0.11 * salariobruto;
                    txtDInss.Text = descontoInss.ToString("N2");
                }
                else
                {
                    txtinss.Text = "Teto";
                    descontoInss = 308.17;
                    txtDInss.Text = descontoInss.ToString("N2");
                }
                if (salariobruto <= 1275.12)
                {
                    txtir.Text = "Isento";
                    descontoIr = 0;
                }
                else if (salariobruto <= 2512.08)
                {
                    txtir.Text = "15%";
                    descontoIr = 0.15 * salariobruto;
                    txtdir.Text = descontoIr.ToString("N2");
                }
                else
                {
                    txtir.Text = "27.5%";
                    descontoIr = 0.275 * salariobruto;
                    txtdir.Text = descontoIr.ToString("N2");
                }
                if (salariobruto <= 435.32)
                {
                    salarioFamilia = Convert.ToDouble(comboBoxfilhos.SelectedItem) * 22.33;
                    txtsfamilia.Text = salarioFamilia.ToString("N2");
                }
                else if (salariobruto <= 654.61)
                {
                    salarioFamilia = Convert.ToDouble(comboBoxfilhos.SelectedItem) * 15.74;
                    txtsfamilia.Text = salarioFamilia.ToString("N2");
                }
                else
                {
                    salarioFamilia = 0;
                    txtsfamilia.Text = "0";
                }
                salarioliquido = salariobruto - descontoInss - descontoIr + salarioFamilia;
                txtsliquido.Text = salarioliquido.ToString("N2");
                //mensagem
                string mensagem = "Os descontos do salário ";
                if (comboBoxsexo.SelectedIndex == 1)
                {
                    mensagem = mensagem + "da Sra. " + txtnome.Text;
                }
                else
                {
                    mensagem = mensagem + "do Sr. " + txtnome.Text;
                }
                if (comboBoxEC.SelectedIndex == 1)
                {
                    mensagem = mensagem + " que é solteiro(a) ";
                }
                else
                {
                    mensagem = mensagem + " que é casado(a) ";
                }
                mensagem = mensagem + "e que tem " + comboBoxfilhos.SelectedItem + " filho(a)(s) são:";

                this.lblmensagem.Text = mensagem;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            
            
                txtinss.Clear();
                txtnome.Clear();
                txtir.Clear();
                txtDInss.Clear();
                txtir.Clear();
                txtsfamilia.Clear();
                txtsliquido.Clear();
                maskedTextsalbrut.Clear();
                comboBoxsexo.SelectedIndex = 0;
                comboBoxfilhos.SelectedIndex = 0;
                comboBoxEC.SelectedIndex = 0;
                lblmensagem.Visible = false;
                lblmensagem.Text = "";
            
        }
    }
}

        
