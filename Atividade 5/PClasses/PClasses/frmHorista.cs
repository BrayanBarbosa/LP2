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
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();
        }

     
        private void btnInstHor_Click(object sender, EventArgs e)
        {
            Horista objHorista = new Horista();
            objHorista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objHorista.NomeEmpregado = txtNome.Text;
            objHorista.SalarioHora = Convert.ToDouble(txtSalHora.Text);          
            objHorista.NumeroHora = Convert.ToDouble(txtNumHoras.Text);
            objHorista.DataEntradaEmpresa = Convert.ToDateTime(txtData.Text);
            objHorista.DiasFalta = Convert.ToInt32(txtFaltas.Text);
            

            //get
            MessageBox.Show("Matrícula: " + objHorista.Matricula +
                            "\nNome: " + objHorista.NomeEmpregado +
                            "\nData de Entrada: " + objHorista.DataEntradaEmpresa +
                            "\nSalário Bruto: " + "R$ " + objHorista.SalarioBruto().ToString("N2") +
                            "\nTempo na Empresa (dias): " + objHorista.TempoTrabalho());
        }
    }
}
