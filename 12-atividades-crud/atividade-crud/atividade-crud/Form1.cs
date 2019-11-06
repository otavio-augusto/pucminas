using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade_crud
{
    public partial class Form1 : Form
    {
        ArrayList cadastro = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void carregarGrid()
        {
            gridAluno.DataSource = null;
            gridAluno.DataSource = cadastro;
            gridAluno.ClearSelection();
            gridAluno.Columns[0].Width = 150;
            gridAluno.Columns[1].Width = 150;
            gridAluno.Columns[2].Width = 50;
            gridAluno.Columns[3].Width = 50;
        }

        private void ButtonIncluir_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno.nome = "Digite o Nome:";
            aluno.endereco = "";
            aluno.telefone = "";
            aluno.email = "";

            cadastro.Add(aluno);
            carregarGrid();
            gridAluno.CurrentCell = gridAluno.Rows[gridAluno.RowCount - 1].Cells[0];
        }

        private void GridAluno_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno.nome = gridAluno.CurrentRow.Cells[0].Value.ToString();
            aluno.endereco = gridAluno.CurrentRow.Cells[1].Value.ToString();
            aluno.telefone = gridAluno.CurrentRow.Cells[2].Value.ToString();
            aluno.email = gridAluno.CurrentRow.Cells[3].Value.ToString();
            cadastro[gridAluno.CurrentRow.Index] = aluno;
        }

        private void ButtonExcluir_Click(object sender, EventArgs e)
        {
            cadastro.RemoveAt(gridAluno.CurrentRow.Index);
            carregarGrid();
        }

        private void ButtonProcurar_Click(object sender, EventArgs e)
        {
            string pesquisa = textProcurar.Text;
            gridAluno.ClearSelection();

            for (int i = 0; i < gridAluno.RowCount; i++)
            {
                if (gridAluno.Rows[i].Cells[0].Value.ToString() == pesquisa)
                    gridAluno.CurrentCell = gridAluno.Rows[i].Cells[0];
            }
        }
    }
}
