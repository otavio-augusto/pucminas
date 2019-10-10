using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_forms
{
    public partial class formEquacao : Form
    {

        public formEquacao()
        {
            InitializeComponent();
        }

        private void ButtonCalcular_Click(object sender, EventArgs e)
        {
            Equacao equacao = new Equacao();

            equacao.A = double.Parse(textA.Text);
            equacao.B = double.Parse(textB.Text);
            equacao.C = double.Parse(textC.Text);

            textDelta.Text = equacao.Delta.ToString();
            if (equacao.Delta != 0)
            {
                textRaiz1.Text = equacao.Raiz1.ToString();
                textRaiz2.Text = equacao.Raiz2.ToString();
            }
            else MessageBox.Show("Não Existem Raizes Reais.");
        }

        private void TextA_TextChanged(object sender, EventArgs e)
        {
            textA.Text = "";
            textB.Text = "";
            textB.Text = "";
            textDelta.Text = "";
            textRaiz1.Text = "";
            textRaiz2.Text = "";
        }
    }
}
