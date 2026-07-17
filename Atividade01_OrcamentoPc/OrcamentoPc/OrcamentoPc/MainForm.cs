
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OrcamentoPc
{

	public partial class MainForm : Form
	{
		public MainForm()
		{

			InitializeComponent();
		}
		void BtnSairClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void CmbPerfilSelectedIndexChanged(object sender, EventArgs e)
		{
			
    		string perfil = cmbPerfil.SelectedItem.ToString();
    		
    		if (perfil == null) return;

   
    		switch (perfil)
    		{
        		case "Administrativo":
            	cmbProcessador.Text = "Intel Core i5-8500 8a Geração 4.1GHz ~ R$ 449";
            	cmbPlacaVideo.Text = "Integrada";
            	cmbMemoria.Text = "Rise Mode RAM Z 8 GB (1x8 GB) DDR4-3200 ~ R$ 450";
            	cmbPlacaMae.Text = "MSI A520M-A PRO Micro ATX AM4 ~ R$ 411";
            	cmbGabinete.Text = "Mancer CV100 (Preto) MicroATX Mid Tower ~ R$ 117";
            	cmbArmazenamento.Text = "Alltek SSD SSD 256 GB 2.5 ~ R$ 273";
            	cmbFonte.Text = "Rise Mode Zeus 550W 550 W 80+ Bronze Full-Modular ATX ~ R$ 348";
            	break;

        		case "Professor de tecnologia":
            	cmbProcessador.Text = "Intel Core i5 12400F, 2.5GHz (4.4GHz Turbo) ~ R$ 790";
            	cmbPlacaVideo.Text = "Integrada";
            	cmbMemoria.Text = "Memória Kingston Fury Beast 16 GB (1x16 GB) DDR4-3200 ~ R$ 800";
            	cmbPlacaMae.Text = "Gigabyte H610M K DDR4 Micro ATX LGA 1700 ~ R$ 439";
            	cmbGabinete.Text = "Mancer CV100 (Preto) MicroATX Mid Tower ~ R$ 117";
            	cmbArmazenamento.Text = "Kingston SSD A400 480 GB 2.5 ~ R$ 497";
            	cmbFonte.Text = "Corsair CX650 650 W  80+ Bronze ATX ~ R$ 358";
            	break;

        		case "Desenvolvedor de Software":
            	cmbProcessador.Text = "Intel Core i5 12400F, 2.5GHz (4.4GHz Turbo) ~ R$ 790";
            	cmbPlacaVideo.Text = "Mancer Radeon RX 580 8 GB ~ R$ 865,72";
            	cmbMemoria.Text = "Memória Kingston Fury Beast 16 GB (1x16 GB) DDR4-3200 ~ R$ 800";
            	cmbPlacaMae.Text = "Gigabyte B550M Aorus Elite Micro ATX AM4 ~ R$ 750";
            	cmbGabinete.Text = "Mancer CV100 (Preto) MicroATX Mid Tower ~ R$ 117";
            	cmbArmazenamento.Text = "Patriot SSD Burst 480 GB 2.5 ~ R$ 564,00";
            	cmbFonte.Text = "Corsair CX650 650 W  80+ Bronze ATX ~ R$ 358";
            	break;

        		case "Desenvolvedor de Jogos":
            	cmbProcessador.Text = "Intel Core i5-14600KF, 3.5 GHz (5.3 GHz Turbo) ~ R$ 1.479,99";
            	cmbPlacaVideo.Text = "MSI GeForce RTX 5060 Shadow 2X 8 GB ~ R$ 2.158,99";
            	cmbMemoria.Text = "Corsair VENGEANCE LPX 32 GB (2x16 GB) DDR4-3200 ~ R$ 1600";
            	cmbPlacaMae.Text = "Gigabyte B550M Aorus Elite Micro ATX AM4 ~ R$ 750";
            	cmbGabinete.Text = "Mancer CV100 (Preto) MicroATX Mid Tower ~ R$ 117";
            	cmbArmazenamento.Text = "Kingston NV3 SSD NVMe M.2 1 TB ~ R$ 999,89";
            	cmbFonte.Text = "Corsair CX750 750 W 80+ Bronze ATX ~ R$ 460";
            	break;
    }
}
				private decimal ObterPrecoDoTexto(string texto)
				{
    				if (string.IsNullOrEmpty(texto) || !texto.Contains("R$"))
        			return 0m;

    				try
    					{
        				int posicaoCifrão = texto.IndexOf("R$");
        				string apenasValor = texto.Substring(posicaoCifrão + 2).Trim();
        
        
        				return decimal.Parse(apenasValor);
    					}
    				catch
    					{
       					return 0m;
    					}
				}
		
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			//checar campo do nome do cliente vazio
			if (string.IsNullOrWhiteSpace(txtNomeCliente.Text))
    	{
        	MessageBox.Show("Por favor, informe o nome do cliente.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        	return;
    	}

    	if (cmbPerfil.SelectedIndex == -1)
    	{
    		//checar perfil vazio
        	MessageBox.Show("Por favor, selecione um perfil de uso.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        	return;
    	}
    	
    	//adicionar os preços ao subtotal
    	decimal subtotal = 0;
    	subtotal += ObterPrecoDoTexto(cmbProcessador.Text);
    	subtotal += ObterPrecoDoTexto(cmbPlacaMae.Text);
    	subtotal += ObterPrecoDoTexto(cmbMemoria.Text);
    	subtotal += ObterPrecoDoTexto(cmbArmazenamento.Text);
    	subtotal += ObterPrecoDoTexto(cmbPlacaVideo.Text);
    	subtotal += ObterPrecoDoTexto(cmbFonte.Text);
    	subtotal += ObterPrecoDoTexto(cmbGabinete.Text);
    	
    	decimal valorMontagem = 250;
    	
    	decimal desconto = int.Parse(nudDesconto.Text);
    	
    	if (desconto > 30 || desconto < 0){
    		MessageBox.Show("O desconto não pode ser negativo e não pode ser maior que 30%.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
    		return;
    	}
    	
    	decimal valorDesconto = subtotal * (desconto / 100);
    	decimal totalFinal = subtotal + valorMontagem - valorDesconto;
    	
    	//texto que retorna o orçamento
    	string resumoOrcamento = "Orçamento gerado com sucesso!\n\n" +
                                 "Cliente: " + txtNomeCliente.Text + "\n" +
                                 "Perfil: " + cmbPerfil.Text + "\n" +
                                 "----------------------------------------\n" +
                                 "Subtotal: " + subtotal.ToString("C2") + "\n" +
                                 "Taxa de Montagem: " + valorMontagem.ToString("C2") + "\n" +
                                 "Desconto (" + desconto.ToString() + "%): " + valorDesconto.ToString("C2") + "\n" +
                                 "----------------------------------------\n" +
                                 "Total Final: " + totalFinal.ToString("C2") + "\n\n";

    	
    	//exibir resultados
    	MessageBox.Show(resumoOrcamento, "Resumo do Orçamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
    	
		}
		void BtnLimparClick(object sender, EventArgs e)
		{
    	
    	txtNomeCliente.Text = "";
		cmbPerfil.Text = "";
    	cmbProcessador.Text = "";
    	cmbPlacaMae.Text = "";
    	cmbMemoria.Text = "";
    	cmbArmazenamento.Text = "";
    	cmbPlacaVideo.Text = "";
    	cmbFonte.Text = "";
    	cmbGabinete.Text = "";
    	nudDesconto.Value = 0;
    	txtNomeCliente.Focus();
	
		}
	}
		
}

