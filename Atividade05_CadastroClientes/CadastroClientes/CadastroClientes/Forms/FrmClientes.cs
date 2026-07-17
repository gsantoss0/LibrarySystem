using System;
using System.Windows.Forms;
using CadastroClientes.Models;
using CadastroClientes.Data;

namespace CadastroClientes.Forms
{
    public partial class FrmClientes : Form
    {
        private ClienteDAO _dao = new ClienteDAO();
        private bool _editando = false;

        public FrmClientes()
        {
            InitializeComponent();
        }

        void FrmClientesLoad(object sender, EventArgs e)
        {
            CarregarTabela();
            LimparCampos();
        }

        private void CarregarTabela()
        {
            try
            {
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = _dao.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }

        private void LimparCampos()
        {
            txtId.Clear();
            txtNome.Clear();
            txtCPF.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtCidade.Clear();
            chkAtivo.Checked = true;
            _editando = false;
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtNome.Text.Trim()))
            {
                MessageBox.Show("Nome é obrigatório.");
                txtNome.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtCPF.Text.Trim()))
            {
                MessageBox.Show("CPF é obrigatório.");
                txtCPF.Focus();
                return false;
            }
            if (!string.IsNullOrEmpty(txtEmail.Text.Trim()) && !txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("E-mail deve ser válido (conter @).");
                txtEmail.Focus();
                return false;
            }
            return true;
        }

        void btnNovoClick(object sender, EventArgs e)
        {
            LimparCampos();
            txtNome.Focus();
        }

        void btnSalvarClick(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                Cliente c = new Cliente
                {
                    Nome = txtNome.Text.Trim(),
                    CPF = txtCPF.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Telefone = txtTelefone.Text.Trim(),
                    Cidade = txtCidade.Text.Trim(),
                    Ativo = chkAtivo.Checked
                };

                if (_editando)
                {
                    c.Id = Convert.ToInt32(txtId.Text);
                    _dao.Atualizar(c);
                    MessageBox.Show("Cliente atualizado com sucesso.");
                }
                else
                {
                    _dao.Inserir(c);
                    MessageBox.Show("Cliente cadastrado com sucesso.");
                }

                CarregarTabela();
                LimparCampos();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Duplicate entry") || ex.Message.Contains("uk_clientes_cpf"))
                    MessageBox.Show("CPF já cadastrado.");
                else
                    MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
        }

        void dgvClientesCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                DataGridViewRow linha = dgvClientes.SelectedRows[0];
                txtId.Text = linha.Cells["Id"].Value.ToString();
                txtNome.Text = linha.Cells["Nome"].Value.ToString();
                txtCPF.Text = linha.Cells["CPF"].Value.ToString();
                txtEmail.Text = linha.Cells["Email"].Value.ToString();
                txtTelefone.Text = linha.Cells["Telefone"].Value.ToString();
                txtCidade.Text = linha.Cells["Cidade"].Value.ToString();
                chkAtivo.Checked = Convert.ToBoolean(linha.Cells["Ativo"].Value);
                _editando = true;
            }
        }

        void btnExcluirClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Selecione um cliente na tabela.");
                return;
            }

            var confirmacao = MessageBox.Show("Deseja realmente excluir este cliente?", "Confirmar Exclusão", MessageBoxButtons.YesNo);
            if (confirmacao == DialogResult.Yes)
            {
                try
                {
                    _dao.Excluir(Convert.ToInt32(txtId.Text));
                    MessageBox.Show("Cliente excluído com sucesso.");
                    CarregarTabela();
                    LimparCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir: " + ex.Message);
                }
            }
        }

        void btnAtivarDesativarClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Selecione um cliente na tabela.");
                return;
            }

            try
            {
                int id = Convert.ToInt32(txtId.Text);
                bool novoEstado = !chkAtivo.Checked;
                _dao.AlterarSituacao(id, novoEstado);
                
                string msg = novoEstado ? "Cliente ativado com sucesso." : "Cliente desativado com sucesso.";
                MessageBox.Show(msg);
                
                CarregarTabela();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar situação: " + ex.Message);
            }
        }

        void btnPesquisarClick(object sender, EventArgs e)
        {
            try
            {
                dgvClientes.DataSource = _dao.PesquisarPorNome(txtPesquisa.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar: " + ex.Message);
            }
        }

        void btnMostrarTodosClick(object sender, EventArgs e)
        {
            txtPesquisa.Clear();
            CarregarTabela();
        }

        void btnCancelarClick(object sender, EventArgs e)
        {
            LimparCampos();
        }
		
        void btnBuscarClick(object sender, EventArgs e)
		{
			
		}
		
		
    }
}