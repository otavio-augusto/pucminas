using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade_forms_02
{
    public partial class Form1 : Form
    {
        Conta conta;
        public Form1()
        {
            InitializeComponent();
            conta = new Conta();
            conta.Saldo = 250;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                int[] notas = conta.saque((double)numericValor.Value);
                if (notas != null)
                {
                    label1.Text = notas[0].ToString();
                    label2.Text = notas[1].ToString();
                    label3.Text = notas[2].ToString();
                    label4.Text = notas[3].ToString();
                    textSaldo.Text = conta.Saldo.ToString();
                }
            }
            else
            {
                conta.Saldo += (double)numericValor.Value;
                textSaldo.Text = conta.Saldo.ToString();
            }
        }

        private void TextSaldo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
