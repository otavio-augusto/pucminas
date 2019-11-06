using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade_forms_04
{
    public partial class Form1 : Form
    {
        Calculo calculo;
        public Form1()
        {
            InitializeComponent();
            calculo = new Calculo();
        }

        #region Numeros
        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            textBox2.Text += "1";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
            textBox2.Text += "2";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            textBox2.Text += "3";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            textBox2.Text += "4";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
            textBox2.Text += "5";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
            textBox2.Text += "6";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
            textBox2.Text += "7";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
            textBox2.Text += "8";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
            textBox2.Text += "9";
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
            textBox2.Text += "0";
        }
        #endregion

        #region Operações
        private void ButtonMais_Click(object sender, EventArgs e)
        {
            calculo.operacao = new Soma();
            calculo.numero1 = double.Parse(textBox2.Text);
            textBox1.Text += "+";
            textBox2.Text = "";
        }

        private void ButtonMenos_Click(object sender, EventArgs e)
        {
            calculo.operacao = new Subtracao();
            calculo.numero1 = double.Parse(textBox2.Text);
            textBox1.Text += "-";
            textBox2.Text = "";
        }

        private void ButtonMult_Click(object sender, EventArgs e)
        {
            calculo.operacao = new Multiplicacao();
            calculo.numero1 = double.Parse(textBox2.Text);
            textBox1.Text += "*";
            textBox2.Text = "";
        }

        private void ButtonDiv_Click(object sender, EventArgs e)
        {
            calculo.operacao = new Divisao();
            calculo.numero1 = double.Parse(textBox2.Text);
            textBox1.Text += "/";
            textBox2.Text = "";
        }

        private void ButtonRaiz_Click(object sender, EventArgs e)
        {
            calculo.operacao = new Raiz();
            calculo.numero1 = double.Parse(textBox2.Text);
            calculo.numero2 = 0;
            textBox1.Text += "";
            buttonIgual.PerformClick();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            calculo.operacao = new Potenciacao();
            try
            {
                calculo.numero1 = double.Parse(textBox2.Text);
            }
            catch (Exception)
            {

                throw;
            }
            
            textBox1.Text += "^";
            textBox2.Text = "";
        }

        private void ButtonIgual_Click(object sender, EventArgs e)
        {
            try
            {
                calculo.numero2 = double.Parse(textBox2.Text);
            }
            catch (Exception)
            {
                calculo.numero2 = 0;
            }
            textBox1.Text = "";
            textBox2.Text = calculo.calcular().ToString();
        }
        #endregion

        public void controle(Keys key)
        {
            switch (key)
            {
                case Keys.NumPad0:
                    button0.PerformClick();
                    break;
                case Keys.NumPad1:
                    button1.PerformClick();
                    break;
                case Keys.NumPad2:
                    button2.PerformClick();
                    break;
                case Keys.NumPad3:
                    button3.PerformClick();
                    break;
                case Keys.NumPad4:
                    button4.PerformClick();
                    break;
                case Keys.NumPad5:
                    button5.PerformClick();
                    break;
                case Keys.NumPad6:
                    button6.PerformClick();
                    break;
                case Keys.NumPad7:
                    button7.PerformClick();
                    break;
                case Keys.NumPad8:
                    button8.PerformClick();
                    break;
                case Keys.NumPad9:
                    button9.PerformClick();
                    break;
                case Keys.Enter:
                    buttonIgual.PerformClick();
                    break;
                    break;
                case Keys.Multiply:
                    buttonMult.PerformClick();
                    break;
                case Keys.Add:
                    buttonMais.PerformClick();
                    break;
                    break;
                case Keys.Subtract:
                    buttonMenos.PerformClick();
                    break;
                case Keys.Decimal:
                    break;
                case Keys.Divide:
                    buttonDiv.PerformClick();
                    break;
            }
        }

        private void TextBox2_Leave(object sender, EventArgs e)
        {
            textBox2.Focus();
        }

        private void TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            controle(e.KeyCode);
        }

        private void ButtonApagar_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
            }
            catch (Exception)
            {
                //Textbox Vazios
            }
            
        }
    }
}
