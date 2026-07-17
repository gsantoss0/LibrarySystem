using System;
using System.Windows.Forms;
using Atividade06_ControleEstoque.Models;
using Atividade06_ControleEstoque.Data;

namespace Atividade06_ControleEstoque.Forms
{
    public partial class FrmProdutos : Form
    {
        private readonly ProdutoDAO prodDAO = new ProdutoDAO();
        private readonly CategoriaDAO catDAO = new CategoriaDAO();

        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            CarregarCategorias();
            AtualizarGrid();
        }

        private void CarregarCategorias()
        {
            cboCategoria.DataSource = catDAO.Listar();
            cboCategoria.DisplayMember = "Nome";
            cboCategoria.ValueMember = "Id";
            cboCategoria.SelectedIndex = -1;
        }

        private void AtualizarGrid()
        {
            dgvProdutos.DataSource = prodDAO.Listar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtNome.Text) || cboCategoria.SelectedIndex == -1)
                {
                    MessageBox.Show("Código, Nome e Categoria são obrigatórios.");
                    return;
                }

                decimal precoCompra = Convert.ToDecimal(txtPrecoCompra.Text);
                decimal precoVenda = Convert.ToDecimal(txtPrecoVenda.Text);

                if (precoCompra < 0 || precoVenda <= 0)
                {
                    MessageBox.Show("Preços inválidos!");
                    return;
                }

                Produto p = new Produto {
                    Codigo = txtCodigo.Text.Trim(),
                    Nome = txtNome.Text.Trim(),
                    IdCategoria = (int)cboCategoria.SelectedValue,
                    PrecoCompra = precoCompra,
                    PrecoVenda = precoVenda,
                    EstoqueMinimo = Convert.ToInt32(nudEstoqueMinimo.Value)
                };

                if (string.IsNullOrEmpty(txtId.Text))
                {
                    prodDAO.Inserir(p);
                    MessageBox.Show("Produto cadastrado.");
                }
                else
                {
                    p.Id = Convert.ToInt32(txtId.Text);
                    prodDAO.Atualizar(p);
                    MessageBox.Show("Produto atualizado.");
                }

                Limpar();
                AtualizarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
        }

        private void btnAtivarDesativar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text)) return;
            prodDAO.AlterarSituacao(Convert.ToInt32(txtId.Text), chkAtivo.Checked);
            MessageBox.Show("Situação atualizada!");
            Limpar();
            AtualizarGrid();
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dgvProdutos.Rows[e.RowIndex].Cells["Id"].Value);
                Produto p = prodDAO.BuscarPorId(id);
                if (p != null)
                {
                    txtId.Text = p.Id.ToString();
                    txtCodigo.Text = p.Codigo;
                    txtNome.Text = p.Nome;
                    cboCategoria.SelectedValue = p.IdCategoria;
                    txtPrecoCompra.Text = p.PrecoCompra.ToString();
                    txtPrecoVenda.Text = p.PrecoVenda.ToString();
                    txtEstoqueAtual.Text = p.Estoque.ToString(); // Apenas leitura
                    nudEstoqueMinimo.Value = p.EstoqueMinimo;
                    chkAtivo.Checked = p.Ativo;
                }
            }
        }

        private void Limpar()
        {
            txtId.Clear();
            txtCodigo.Clear();
            txtNome.Clear();
            cboCategoria.SelectedIndex = -1;
            txtPrecoCompra.Clear();
            txtPrecoVenda.Clear();
            txtEstoqueAtual.Clear();
            nudEstoqueMinimo.Value = 0;
            chkAtivo.Checked = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e) {
        	Limpar();
        }
    }
}