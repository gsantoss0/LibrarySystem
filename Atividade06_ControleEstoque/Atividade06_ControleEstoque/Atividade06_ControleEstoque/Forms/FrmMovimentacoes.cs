using System;
using System.Windows.Forms;
using Atividade06_ControleEstoque.Models;
using Atividade06_ControleEstoque.Data;

namespace Atividade06_ControleEstoque.Forms
{
    public partial class FrmMovimentacoes : Form
    {
        private readonly MovimentacaoDAO movDAO = new MovimentacaoDAO();
        private readonly ProdutoDAO prodDAO = new ProdutoDAO();

        public FrmMovimentacoes()
        {
            InitializeComponent();
        }

        private void FrmMovimentacoes_Load(object sender, EventArgs e)
        {
            CarregarProdutos();
            AtualizarGrid();
        }

        private void CarregarProdutos()
        {
            cboProduto.DataSource = prodDAO.Listar();
            cboProduto.DisplayMember = "Nome";
            cboProduto.ValueMember = "Id";
            cboProduto.SelectedIndex = -1;
        }

        private void AtualizarGrid()
        {
            dgvMovimentacoes.DataSource = movDAO.ListarTodos();
        }

        private void cboProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProduto.SelectedValue != null && cboProduto.SelectedValue is int)
            {
                Produto p = prodDAO.BuscarPorId((int)cboProduto.SelectedValue);
                if (p != null)
                {
                    txtEstoqueAtual.Text = p.Estoque.ToString();
                    if (!p.Ativo)
                    {
                        MessageBox.Show("Produto inativo! Ative-o antes de movimentar.");
                        btnRegistrar.Enabled = false;
                    }
                    else
                    {
                        btnRegistrar.Enabled = true;
                    }
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboProduto.SelectedIndex == -1 || cboTipo.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecione o produto e o tipo de movimentação.");
                    return;
                }

                int qtd = Convert.ToInt32(nudQuantidade.Value);
                int estoqueAtual = Convert.ToInt32(txtEstoqueAtual.Text);
                string tipo = cboTipo.Text;

                if (qtd <= 0)
                {
                    MessageBox.Show("A quantidade deve ser maior que zero.");
                    return;
                }

                if (tipo == "SAIDA" && qtd > estoqueAtual)
                {
                    MessageBox.Show("Saldo insuficiente para saída.");
                    return;
                }

                Movimentacao m = new Movimentacao {
                    IdProduto = (int)cboProduto.SelectedValue,
                    Tipo = tipo,
                    Quantidade = qtd,
                    Observacao = txtObservacao.Text.Trim()
                };

                movDAO.Registrar(m);
                MessageBox.Show("Movimentação registrada com sucesso!");
                
                nudQuantidade.Value = 1;
                txtObservacao.Clear();
                
                // Atualiza tela
                Produto p = prodDAO.BuscarPorId(m.IdProduto);
                txtEstoqueAtual.Text = p.Estoque.ToString();
                
                AtualizarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao movimentar: " + ex.Message);
            }
        }
    }
}