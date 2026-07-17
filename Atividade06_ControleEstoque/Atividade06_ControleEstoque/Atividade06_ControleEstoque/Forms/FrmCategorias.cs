using System;
using System.Windows.Forms;
using Atividade06_ControleEstoque.Models;
using Atividade06_ControleEstoque.Data;

namespace Atividade06_ControleEstoque.Forms
{
    public partial class FrmCategorias : Form
    {
        private readonly CategoriaDAO dao = new CategoriaDAO();

        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            dgvCategorias.DataSource = dao.Listar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("O nome da categoria é obrigatório.");
                return;
            }

            Categoria cat = new Categoria { Nome = txtNome.Text.Trim() };

            if (string.IsNullOrEmpty(txtId.Text))
            {
                dao.Inserir(cat);
                MessageBox.Show("Categoria inserida com sucesso.");
            }
            else
            {
                cat.Id = Convert.ToInt32(txtId.Text);
                dao.Atualizar(cat);
                MessageBox.Show("Categoria atualizada com sucesso.");
            }

            Limpar();
            AtualizarGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text)) return;

            if (MessageBox.Show("Deseja realmente excluir?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    dao.Excluir(Convert.ToInt32(txtId.Text));
                    MessageBox.Show("Excluída com sucesso.");
                    Limpar();
                    AtualizarGrid();
                }
                catch (Exception)
                {
                    MessageBox.Show("Não é possível excluir categorias vinculadas a produtos.");
                }
            }
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtId.Text = dgvCategorias.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNome.Text = dgvCategorias.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void Limpar()
        {
            txtId.Clear();
            txtNome.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e){
        	Limpar();
        }
    }
}