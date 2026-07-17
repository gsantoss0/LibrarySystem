using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Atividade06_ControleEstoque.Data;

namespace Atividade06_ControleEstoque.Forms
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        void FrmPrincipalLoad(object sender, EventArgs e)
        {
            AtualizarDashboard();
        }

        void FrmPrincipalActivated(object sender, EventArgs e)
        {
            AtualizarDashboard();
        }

        void AtualizarDashboard()
        {
            try
            {
                using (MySqlConnection conn = new Conexao().CriarConexao())
                {
                    conn.Open();
                    
                    // Total de produtos
                    using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM produtos", conn))
                        lblTotalProdutos.Text = cmd.ExecuteScalar().ToString();

                    // Ativos
                    using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM produtos WHERE ativo = 1", conn))
                        lblProdutosAtivos.Text = cmd.ExecuteScalar().ToString();

                    // Total de itens
                    using (MySqlCommand cmd = new MySqlCommand("SELECT IFNULL(SUM(estoque), 0) FROM produtos", conn))
                        lblTotalItens.Text = cmd.ExecuteScalar().ToString();

                    // Valor estimado
                    using (MySqlCommand cmd = new MySqlCommand("SELECT IFNULL(SUM(preco_compra * estoque), 0) FROM produtos", conn))
                        lblValorEstimado.Text = Convert.ToDecimal(cmd.ExecuteScalar()).ToString("C2");

                    // Estoque baixo
                    using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM produtos WHERE estoque <= estoque_minimo AND ativo = 1", conn))
                        lblEstoqueBaixo.Text = cmd.ExecuteScalar().ToString();
                }

                // Carrega últimas movimentações
                dgvUltimasMovimentacoes.DataSource = new MovimentacaoDAO().ListarTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar painel: " + ex.Message);
            }
        }

        void btnCategoriasClick(object sender, EventArgs e)
        {
            new FrmCategorias().ShowDialog();
        }

        void btnProdutosClick(object sender, EventArgs e)
        {
            new FrmProdutos().ShowDialog();
        }

        void btnMovimentacoesClick(object sender, EventArgs e)
        {
            new FrmMovimentacoes().ShowDialog();
        }
    }
}