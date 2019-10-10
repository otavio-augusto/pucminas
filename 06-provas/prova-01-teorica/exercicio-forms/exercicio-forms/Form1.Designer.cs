namespace exercicio_forms
{
    partial class formEquacao
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textA = new System.Windows.Forms.TextBox();
            this.textB = new System.Windows.Forms.TextBox();
            this.textC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textDelta = new System.Windows.Forms.TextBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.textRaiz1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textRaiz2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "C";
            // 
            // textA
            // 
            this.textA.Location = new System.Drawing.Point(12, 25);
            this.textA.Name = "textA";
            this.textA.Size = new System.Drawing.Size(45, 20);
            this.textA.TabIndex = 3;
            this.textA.TextChanged += new System.EventHandler(this.TextA_TextChanged);
            // 
            // textB
            // 
            this.textB.Location = new System.Drawing.Point(12, 64);
            this.textB.Name = "textB";
            this.textB.Size = new System.Drawing.Size(45, 20);
            this.textB.TabIndex = 4;
            // 
            // textC
            // 
            this.textC.Location = new System.Drawing.Point(12, 103);
            this.textC.Name = "textC";
            this.textC.Size = new System.Drawing.Size(45, 20);
            this.textC.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(60, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Delta";
            // 
            // textDelta
            // 
            this.textDelta.Location = new System.Drawing.Point(63, 25);
            this.textDelta.Name = "textDelta";
            this.textDelta.Size = new System.Drawing.Size(82, 20);
            this.textDelta.TabIndex = 7;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonCalcular.Location = new System.Drawing.Point(12, 138);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(133, 32);
            this.buttonCalcular.TabIndex = 8;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.ButtonCalcular_Click);
            // 
            // textRaiz1
            // 
            this.textRaiz1.Location = new System.Drawing.Point(63, 64);
            this.textRaiz1.Name = "textRaiz1";
            this.textRaiz1.Size = new System.Drawing.Size(82, 20);
            this.textRaiz1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(60, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Raiz 1";
            // 
            // textRaiz2
            // 
            this.textRaiz2.Location = new System.Drawing.Point(63, 103);
            this.textRaiz2.Name = "textRaiz2";
            this.textRaiz2.Size = new System.Drawing.Size(82, 20);
            this.textRaiz2.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(60, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Raiz 2";
            // 
            // formEquacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(293, 191);
            this.Controls.Add(this.textRaiz2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textRaiz1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.textDelta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textC);
            this.Controls.Add(this.textB);
            this.Controls.Add(this.textA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "formEquacao";
            this.Text = "Atividade Forms - Equação de 2º Grau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textA;
        private System.Windows.Forms.TextBox textB;
        private System.Windows.Forms.TextBox textC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textDelta;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.TextBox textRaiz1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textRaiz2;
        private System.Windows.Forms.Label label6;
    }
}

