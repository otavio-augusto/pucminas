using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade_abstracao_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (radioRetangulo.Checked)
            {
                Retangulo retangulo = new Retangulo();
                retangulo.A = double.Parse(textLadoA.Text);
                retangulo.B = double.Parse(textLadoB.Text);
                retangulo.C = double.Parse(textLadoC.Text);
                textArea.Text = retangulo.Area.ToString();
                textPerimetro.Text = retangulo.Perimetro.ToString();
            }
            else if (radioIsoceles.Checked)
            {
                Isoceles isoceles = new Isoceles();
                isoceles.A = double.Parse(textLadoA.Text);
                isoceles.B = double.Parse(textLadoB.Text);
                isoceles.C = double.Parse(textLadoC.Text);
                textArea.Text = isoceles.Area.ToString();
                textPerimetro.Text = isoceles.Perimetro.ToString();
            }
            else if (radioEquilatero.Checked)
            {
                Equilatero equilatero = new Equilatero();
                equilatero.A = double.Parse(textLadoA.Text);
                equilatero.B = double.Parse(textLadoB.Text);
                equilatero.C = double.Parse(textLadoC.Text);
                textArea.Text = equilatero.Area.ToString();
                textPerimetro.Text = equilatero.Perimetro.ToString();
            }
        }

        private void ButtonLimpar_Click(object sender, EventArgs e)
        {
            textLadoA.Text = "";
            textLadoB.Text = "";
            textLadoC.Text = "";
            textArea.Text = "";
            textPerimetro.Text = "";
        }
    }
}
