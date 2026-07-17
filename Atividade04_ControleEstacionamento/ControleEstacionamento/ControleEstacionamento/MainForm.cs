using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ControleEstacionamento
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
		}
		
		private void MainFormLoad(object sender, EventArgs e)
		{
			cboTipoVeiculo.Items.Clear();
			cboTipoVeiculo.Items.Add("Moto");
			cboTipoVeiculo.Items.Add("Carro");
			cboTipoVeiculo.Items.Add("Utilitário");
			cboTipoVeiculo.SelectedIndex = -1;
			
			dtpEntrada.Value = DateTime.Now;
			dtpSaida.Value = DateTime.Now;
		}
		
		private bool ValidarEntrada()
		{
		if (txtPlaca.Text.Trim() == "")
		{
			MessageBox.Show("Informe a placa do veículo.");
			txtPlaca.Focus();
			return false;
		}
		if (txtModelo.Text.Trim() == "")
		{
			MessageBox.Show("Informe o modelo do veículo.");
			txtModelo.Focus();
			return false;
		}
		if (cboTipoVeiculo.SelectedIndex == -1)
		{
			MessageBox.Show("Selecione o tipo do veículo.");
			return false;
		}
			return true;
		}
		
		private bool PlacaJaEstacionada(string placa)
		{
		foreach (DataGridViewRow linha in dgvVeiculos.Rows)
		{
			string placaTabela = Convert.ToString(linha.Cells["colPlaca"].Value);
			string situacao = Convert.ToString(linha.Cells["colSituacao"].Value);
		if (placaTabela.Equals(placa, StringComparison.OrdinalIgnoreCase)&& situacao == "Estacionado")
		{
			return true;
		}
		}
			return false;
		}
		
		void BtnRegistrarEntradaClick(object sender, EventArgs e)
		{
			if (!ValidarEntrada())
			return;
			string placa = txtPlaca.Text.Trim().ToUpper();
			if (PlacaJaEstacionada(placa))
			{
				MessageBox.Show("Esta placa já possui uma entrada em aberto.");
				return;
			}
			dgvVeiculos.Rows.Add(
			placa,
			txtModelo.Text.Trim(),
			cboTipoVeiculo.Text,
			dtpEntrada.Value,
			null,
			0,
			0m,
			"Estacionado"
		);
			AtualizarIndicadores();
			LimparCampos();
		}
		
		private DataGridViewRow ObterLinhaSelecionada()
		{
			if (dgvVeiculos.SelectedRows.Count == 0)
			{
				MessageBox.Show("Selecione uma linha na tabela.");
				return null;
			}
			return dgvVeiculos.SelectedRows[0];
		}
		
		private decimal ObterValorHora(string tipo)
		{
			if (tipo == "Moto")
			return 4m;
			else if (tipo == "Carro")
			return 7m;
			else
			return 10m;
		}

		private int CalcularHoras(DateTime entrada, DateTime saida)
		{
			TimeSpan permanencia = saida - entrada;
			return (int)Math.Ceiling(permanencia.TotalHours);
		}
		
		private void BtnRegistrarSaidaClick(object sender, EventArgs e)
		{
		DataGridViewRow linha = ObterLinhaSelecionada();
		if (linha == null)
			return;
		string situacao = Convert.ToString(linha.Cells["colSituacao"].Value);
		if (situacao == "Finalizado")
		{
			MessageBox.Show("A saída deste veículo já foi registrada.");
			return;
		}
		
		DateTime entrada = Convert.ToDateTime(linha.Cells["colEntrada"].Value);
		DateTime saida = dtpSaida.Value;
		
		if (saida < entrada)
		{
			MessageBox.Show("A saída não pode ser anterior à entrada.");
			return;
		}
		string tipo = Convert.ToString(linha.Cells["colTipo"].Value);
		int horas = CalcularHoras(entrada, saida);
		decimal valor = horas * ObterValorHora(tipo);
		linha.Cells["colSaida"].Value = saida;
		linha.Cells["colHoras"].Value = horas;
		linha.Cells["colValor"].Value = valor;
		linha.Cells["colSituacao"].Value = "Finalizado";
		AtualizarIndicadores();
		}
		
		private void BtnPesquisarClick(object sender, EventArgs e)
{
    string pesquisa = txtPesquisarPlaca.Text.Trim().ToUpper();
    
    // 1. Remove a seleção e o foco da célula atual para evitar erros ao ocultar as linhas
    dgvVeiculos.CurrentCell = null;
    dgvVeiculos.ClearSelection();
    
    // 2. Percorre as linhas aplicando o filtro
    foreach (DataGridViewRow linha in dgvVeiculos.Rows)
    {
        // Ignora a linha em branco de inserção automática, se houver
        if (linha.IsNewRow) continue; 
        
        if (linha.Cells["colPlaca"].Value != null)
        {
            string placa = Convert.ToString(linha.Cells["colPlaca"].Value).ToUpper();
            
            // Define se a linha fica visível ou oculta com base na pesquisa
            linha.Visible = string.IsNullOrEmpty(pesquisa) || placa.Contains(pesquisa);
        }
    }
}
		
		private void BtnRemoverClick(object sender, EventArgs e)
		{
		DataGridViewRow linha = ObterLinhaSelecionada();
		if (linha == null)
			return;
		DialogResult resposta = MessageBox.Show(
		"Deseja remover o registro selecionado?",
		"Confirmação",
		MessageBoxButtons.YesNo,
		MessageBoxIcon.Question
		);
		if (resposta == DialogResult.Yes)
		{
			dgvVeiculos.Rows.Remove(linha);
			AtualizarIndicadores();
		}
		
		}
		
		private void AtualizarIndicadores()
		{
		int estacionados = 0;
		int finalizados = 0;
		decimal totalRecebido = 0m;
		
		foreach (DataGridViewRow linha in dgvVeiculos.Rows)
		{
			string situacao = Convert.ToString(linha.Cells["colSituacao"].Value);
			if (situacao == "Estacionado")
			estacionados++;
			else if (situacao == "Finalizado")
			{
				finalizados++;
				totalRecebido += Convert.ToDecimal(linha.Cells["colValor"].Value);
			}
		}
		lblEstacionados.Text = estacionados.ToString();
		lblFinalizados.Text = finalizados.ToString();
		lblTotalRecebido.Text = totalRecebido.ToString("C2");
		}
		
		private void LimparCampos()
		{
		txtPlaca.Clear();
		txtModelo.Clear();
		cboTipoVeiculo.SelectedIndex = -1;
		dtpEntrada.Value = DateTime.Now;
		dtpSaida.Value = DateTime.Now;
		txtPlaca.Focus();
		}
		
		void DgvVeiculosCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (dgvVeiculos.Columns[e.ColumnIndex].Name == "colSituacao"
			&& e.Value != null)
			{
				if (e.Value.ToString() == "Estacionado")
				e.CellStyle.BackColor = Color.LightYellow;
				else
				e.CellStyle.BackColor = Color.LightGreen;
			}
		}
		void BtnEncerrarClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void BtnMostrarTodosClick(object sender, EventArgs e)
		{
			txtPesquisarPlaca.Clear();
            foreach (DataGridViewRow linha in dgvVeiculos.Rows)
            {
                linha.Visible = true;
            }
		}
		void BtnLimparClick(object sender, EventArgs e)
		{
			LimparCampos();
		}
		
		
	}
}
