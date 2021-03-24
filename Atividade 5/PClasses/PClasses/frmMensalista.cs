using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PClasses
{
    public partial class frmMensalista : Form
    {
        public frmMensalista()
        {
            InitializeComponent();
        }

        private void btnInstMens_Click(object sender, EventArgs e)
        {
            //set
            Mensalista objMensalista = new Mensalista();
            objMensalista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objMensalista.NomeEmpregado = txtNome.Text;
            objMensalista.DataEntradaEmpresa = Convert.ToDateTime(txtData.Text);
            objMensalista.SalarioMensal = Convert.ToDouble(txtSalarioM.Text);

            //get
            MessageBox.Show("Matrícula: " + objMensalista.Matricula +
                            "\nNome: " + objMensalista.NomeEmpregado +
                            "\nData de Entrada: " + objMensalista.DataEntradaEmpresa +
                            "\nSalário Bruto: " + "R$ " + objMensalista.SalarioBruto().ToString("N2") +
                            "\nTempo na Empresa (dias): " + objMensalista.TempoTrabalho());
        }

        private void btnInstMensPar_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista(Convert.ToInt32(txtMatricula.Text), 
                txtNome.Text, Convert.ToDateTime(txtData.Text), Convert.ToDouble(txtSalarioM.Text));

            MessageBox.Show("Matrícula: " + objMensalista.Matricula +
                            "\nNome: " + objMensalista.NomeEmpregado +
                            "\nData de Entrada: " + objMensalista.DataEntradaEmpresa +
                            "\nSalário Bruto: " + "R$ " + objMensalista.SalarioBruto().ToString("N2") +
                            "\nTempo na Empresa (dias): " + objMensalista.TempoTrabalho());

        }
    }
}
