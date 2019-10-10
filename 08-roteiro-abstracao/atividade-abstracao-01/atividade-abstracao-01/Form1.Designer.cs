namespace atividade_abstracao_01
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textLadoA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textLadoB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textLadoC = new System.Windows.Forms.TextBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textArea = new System.Windows.Forms.TextBox();
            this.textPerimetro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.radioRetangulo = new System.Windows.Forms.RadioButton();
            this.radioIsoceles = new System.Windows.Forms.RadioButton();
            this.radioEquilatero = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioEquilatero);
            this.groupBox1.Controls.Add(this.radioIsoceles);
            this.groupBox1.Controls.Add(this.radioRetangulo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(114, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo do Triangulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lado A";
            // 
            // textLadoA
            // 
            this.textLadoA.Location = new System.Drawing.Point(135, 28);
            this.textLadoA.Name = "textLadoA";
            this.textLadoA.Size = new System.Drawing.Size(100, 20);
            this.textLadoA.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lado B";
            // 
            // textLadoB
            // 
            this.textLadoB.Location = new System.Drawing.Point(135, 67);
            this.textLadoB.Name = "textLadoB";
            this.textLadoB.Size = new System.Drawing.Size(100, 20);
            this.textLadoB.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lado C";
            // 
            // textLadoC
            // 
            this.textLadoC.Location = new System.Drawing.Point(135, 106);
            this.textLadoC.Name = "textLadoC";
            this.textLadoC.Size = new System.Drawing.Size(100, 20);
            this.textLadoC.TabIndex = 6;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCalcular.Location = new System.Drawing.Point(12, 132);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(114, 33);
            this.buttonCalcular.TabIndex = 7;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = false;
            this.buttonCalcular.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Area";
            // 
            // textArea
            // 
            this.textArea.Location = new System.Drawing.Point(135, 145);
            this.textArea.Name = "textArea";
            this.textArea.ReadOnly = true;
            this.textArea.Size = new System.Drawing.Size(100, 20);
            this.textArea.TabIndex = 9;
            // 
            // textPerimetro
            // 
            this.textPerimetro.Location = new System.Drawing.Point(135, 184);
            this.textPerimetro.Name = "textPerimetro";
            this.textPerimetro.Size = new System.Drawing.Size(100, 20);
            this.textPerimetro.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Permitro";
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLimpar.Location = new System.Drawing.Point(12, 171);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(114, 33);
            this.buttonLimpar.TabIndex = 12;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = false;
            this.buttonLimpar.Click += new System.EventHandler(this.ButtonLimpar_Click);
            // 
            // radioRetangulo
            // 
            this.radioRetangulo.AutoSize = true;
            this.radioRetangulo.Checked = true;
            this.radioRetangulo.Location = new System.Drawing.Point(6, 35);
            this.radioRetangulo.Name = "radioRetangulo";
            this.radioRetangulo.Size = new System.Drawing.Size(74, 17);
            this.radioRetangulo.TabIndex = 0;
            this.radioRetangulo.TabStop = true;
            this.radioRetangulo.Text = "Retangulo";
            this.radioRetangulo.UseVisualStyleBackColor = true;
            // 
            // radioIsoceles
            // 
            this.radioIsoceles.AutoSize = true;
            this.radioIsoceles.Location = new System.Drawing.Point(6, 58);
            this.radioIsoceles.Name = "radioIsoceles";
            this.radioIsoceles.Size = new System.Drawing.Size(64, 17);
            this.radioIsoceles.TabIndex = 1;
            this.radioIsoceles.Text = "Isoceles";
            this.radioIsoceles.UseVisualStyleBackColor = true;
            // 
            // radioEquilatero
            // 
            this.radioEquilatero.AutoSize = true;
            this.radioEquilatero.Location = new System.Drawing.Point(6, 81);
            this.radioEquilatero.Name = "radioEquilatero";
            this.radioEquilatero.Size = new System.Drawing.Size(72, 17);
            this.radioEquilatero.TabIndex = 2;
            this.radioEquilatero.Text = "Equilatero";
            this.radioEquilatero.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(253, 227);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.textPerimetro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textArea);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.textLadoC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textLadoB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textLadoA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Atividade Abstração 01";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textLadoA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textLadoB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textLadoC;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textArea;
        private System.Windows.Forms.TextBox textPerimetro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.RadioButton radioEquilatero;
        private System.Windows.Forms.RadioButton radioIsoceles;
        private System.Windows.Forms.RadioButton radioRetangulo;
    }
}

