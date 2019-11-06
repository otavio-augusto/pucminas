namespace atividade_crud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonIncluir = new System.Windows.Forms.ToolStripButton();
            this.toolPrincipal = new System.Windows.Forms.ToolStrip();
            this.buttonExcluir = new System.Windows.Forms.ToolStripButton();
            this.buttonProcurar = new System.Windows.Forms.ToolStripButton();
            this.textProcurar = new System.Windows.Forms.ToolStripTextBox();
            this.buttonSair = new System.Windows.Forms.ToolStripButton();
            this.gridAluno = new System.Windows.Forms.DataGridView();
            this.toolPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonIncluir
            // 
            this.buttonIncluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonIncluir.Image = ((System.Drawing.Image)(resources.GetObject("buttonIncluir.Image")));
            this.buttonIncluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonIncluir.Name = "buttonIncluir";
            this.buttonIncluir.Size = new System.Drawing.Size(23, 22);
            this.buttonIncluir.Text = "toolStripButton1";
            this.buttonIncluir.Click += new System.EventHandler(this.ButtonIncluir_Click);
            // 
            // toolPrincipal
            // 
            this.toolPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonIncluir,
            this.buttonExcluir,
            this.buttonProcurar,
            this.textProcurar,
            this.buttonSair});
            this.toolPrincipal.Location = new System.Drawing.Point(0, 0);
            this.toolPrincipal.Name = "toolPrincipal";
            this.toolPrincipal.Size = new System.Drawing.Size(574, 25);
            this.toolPrincipal.TabIndex = 0;
            this.toolPrincipal.Text = "toolStrip1";
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonExcluir.Image = ((System.Drawing.Image)(resources.GetObject("buttonExcluir.Image")));
            this.buttonExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonExcluir.Size = new System.Drawing.Size(23, 22);
            this.buttonExcluir.Text = "toolStripButton1";
            this.buttonExcluir.Click += new System.EventHandler(this.ButtonExcluir_Click);
            // 
            // buttonProcurar
            // 
            this.buttonProcurar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonProcurar.Image = ((System.Drawing.Image)(resources.GetObject("buttonProcurar.Image")));
            this.buttonProcurar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonProcurar.Name = "buttonProcurar";
            this.buttonProcurar.Size = new System.Drawing.Size(23, 22);
            this.buttonProcurar.Text = "toolStripButton1";
            this.buttonProcurar.Click += new System.EventHandler(this.ButtonProcurar_Click);
            // 
            // textProcurar
            // 
            this.textProcurar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textProcurar.Name = "textProcurar";
            this.textProcurar.Size = new System.Drawing.Size(100, 25);
            // 
            // buttonSair
            // 
            this.buttonSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonSair.Image = ((System.Drawing.Image)(resources.GetObject("buttonSair.Image")));
            this.buttonSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(23, 22);
            this.buttonSair.Text = "toolStripButton1";
            this.buttonSair.Click += new System.EventHandler(this.ButtonSair_Click);
            // 
            // gridAluno
            // 
            this.gridAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAluno.Location = new System.Drawing.Point(12, 28);
            this.gridAluno.Name = "gridAluno";
            this.gridAluno.Size = new System.Drawing.Size(550, 379);
            this.gridAluno.TabIndex = 1;
            this.gridAluno.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridAluno_CellEndEdit);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(574, 419);
            this.Controls.Add(this.gridAluno);
            this.Controls.Add(this.toolPrincipal);
            this.Name = "Form1";
            this.Text = "CRUD - Simulação";
            this.toolPrincipal.ResumeLayout(false);
            this.toolPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton buttonIncluir;
        private System.Windows.Forms.ToolStrip toolPrincipal;
        private System.Windows.Forms.ToolStripButton buttonExcluir;
        private System.Windows.Forms.ToolStripButton buttonProcurar;
        private System.Windows.Forms.ToolStripTextBox textProcurar;
        private System.Windows.Forms.ToolStripButton buttonSair;
        private System.Windows.Forms.DataGridView gridAluno;
    }
}

