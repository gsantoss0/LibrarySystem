using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaVendas
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        void BtnCalcularClick(object sender, EventArgs e)
{
    
    if (string.IsNullOrWhiteSpace(txtCliente.Text))
    {
        MessageBox.Show("Por favor, insira o nome do cliente antes de calcular.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        txtCliente.Focus();
        return; 
    }

    double valorProduto;
    if (!double.TryParse(txtValorUnit.Text, out valorProduto) || valorProduto <= 0)
    {
        MessageBox.Show("Por favor, insira um valor unitário válido (somente números positivos).", "Valor Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        txtValorUnit.Focus();
        txtValorUnit.SelectAll(); // Seleciona o texto errado para facilitar a correção
        return; 
    }

    
    string cliente = txtCliente.Text;
    string produto = txtProduto.Text;
    
    
    int quantidade = (int)nudQuantidade.Value; 
    
    double subtotal = valorProduto * quantidade;
    double desconto = 0;
    string formaPagamento = "";

    
    if (rdbDinheiro.Checked)
    {
        formaPagamento = "Dinheiro";
        desconto = subtotal * 0.10;
    } 
    else if (rdbPix.Checked)
    {
        formaPagamento = "Pix";
        desconto = subtotal * 0.08;
    } 
    else if (rdbCartaoDebito.Checked)
    {
        formaPagamento = "Cartão de débito";
        desconto = subtotal * 0.03;
    } 
    else if (rdbCartaoCredito.Checked)
    {
        formaPagamento = "Cartão de crédito";
        desconto = 0;
    }

    if (valorProduto > 1000)
    {
        desconto += subtotal * 0.02; 
    }

    double taxaEntrega = 0;
    double taxaGarantia = 0;
    string entregaS = "Não";
    string garantiaS = "Não";

    if (chkEntrega.Checked)
    {
        taxaEntrega = 25.00;
        entregaS = "Sim";
    }
    if (chkGarantia.Checked)
    {
        taxaGarantia = subtotal * 0.05;
        garantiaS = "Sim";
    }

    double valorFinal = (subtotal - desconto) + taxaEntrega + taxaGarantia;

    txtResultadoVenda.Text = "Cliente: " + cliente + "\r\n" +
                             "Produto: " + produto + "\r\n" +
                             "Valor unitário: " + valorProduto.ToString("C") + "\r\n" +
                             "Quantidade: " + quantidade.ToString() + "\r\n" +
                             "Pagamento: " + formaPagamento + "\r\n" +
                             "Entrega: " + entregaS + " (" + taxaEntrega.ToString("C") + ")\r\n" +
                             "Garantia: " + garantiaS + " (" + taxaGarantia.ToString("C") + ")\r\n" +
                             "Subtotal: " + subtotal.ToString("C") + "\r\n" +
                             "Desconto Total: " + desconto.ToString("C") + "\r\n" +
                             "--------------------------------------------" + "\r\n" +
                             "Valor Final: " + valorFinal.ToString("C") + "\r\n";
}
		void BtnSairClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void BtnNovaVendaClick(object sender, EventArgs e)
		{
			
    	txtCliente.Clear();
    	txtProduto.Clear();
    	txtValorUnit.Clear();
    
    	
    	nudQuantidade.Value = 1; 

    	
    	rdbDinheiro.Checked = false;
    	rdbPix.Checked = false;
    	rdbCartaoDebito.Checked = false;
    	rdbCartaoCredito.Checked = false;

    	
    	chkEntrega.Checked = false;
    	chkGarantia.Checked = false;

    	
    	txtResultadoVenda.Clear();

    	
    	txtCliente.Focus();

		}
    }
}