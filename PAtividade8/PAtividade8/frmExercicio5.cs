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
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //criar vetor

            List<string> nomeVetor = new List<string>()
            {
                "Ana", "André", "Débora", "Fátima", "João", "Janete", "Otávio", "Marcelo", "Pedro", "Thais"
            };

            //remover um nome
            nomeVetor.Remove("Otávio");

            //imprimir
            string aux = "";

            foreach (var nome in nomeVetor)
            {
                aux += nome + "\n";
            }

            MessageBox.Show(aux);
        }
    }
}
