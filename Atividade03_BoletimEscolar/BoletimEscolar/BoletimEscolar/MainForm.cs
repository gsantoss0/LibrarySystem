using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BoletimEscolar
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
            lstAlunos.HorizontalScrollbar = true;
            lstAlunos.HorizontalExtent = 1000;
			
		}
		void BtnCalcularClick(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtNota1.Text))
    		{
        		MessageBox.Show("Preencha o campo com valores válidos.", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        		txtNota1.Focus();
        		return; 
    		}
			
			if (string.IsNullOrWhiteSpace(txtNota2.Text))
    		{
        		MessageBox.Show("Preencha o campo com valores válidos.", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        		txtNota2.Focus();
        		return; 
    		}
			
			if (string.IsNullOrWhiteSpace(txtNota3.Text))
    		{
        		MessageBox.Show("Preencha o campo com valores válidos.", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        		txtNota3.Focus();
        		return; 
    		}
			
			if (string.IsNullOrWhiteSpace(txtNota4.Text))
    		{
        		MessageBox.Show("Preencha o campo com valores válidos.", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        		txtNota4.Focus();
        		return; 
    		}
			
			
			double nota1 = double.Parse(txtNota1.Text);
			double nota2 = double.Parse(txtNota2.Text);
			double nota3 = double.Parse(txtNota3.Text);
			double nota4 = double.Parse(txtNota4.Text);
			//calculo de media
			double media = (nota1 + nota2 + nota3 + nota4) / 4;
			
			//checando frequencia
			int frequencia = int.Parse(nudFrequencia.Text);
			
			//verficando situacao do aluno
			if (frequencia < 75){
				lblMedia.Text = "Média: "+ media.ToString();
				lblSituacao.Text = "Situação: Reprovado por frequência";
			} else if(media >= 7 && frequencia >= 75){
				lblMedia.Text = "Média: "+ media.ToString();
				lblSituacao.Text = "Situação: Aprovado";
			} else if(media >= 5 && media < 7 && frequencia >= 75){
				lblMedia.Text = "Média: "+ media.ToString();
				lblSituacao.Text = "Situação: Recuperação";
			} else if(media < 5 && frequencia >= 75){
				lblMedia.Text = "Média: "+ media.ToString();
				lblSituacao.Text = "Situação: Reprovado por nota";
			}
			
		}
		
		void BtnAdicionarClick(object sender, EventArgs e)
		{
			string aluno = txtAluno.Text;
			string turma = txtTurma.Text;
			
			string alunoAdicionado = "Aluno: "+ aluno + " | Turma: "+ turma + " | " + lblMedia.Text + " | " + lblSituacao.Text;
			lstAlunos.Items.Add(alunoAdicionado);
			
		}
		
		void TxtNota1TextChanged(object sender, EventArgs e)
		{

    		// Remove tudo o que NÃO for número usando Expressão Regular (Regex)
    		string apenasNumeros = Regex.Replace(txtNota1.Text, "[^0-9]", "");
    
    		if (txtNota1.Text != apenasNumeros)
    		{
        		txtNota1.Text = apenasNumeros;
        
        		txtNota1.SelectionStart = txtNota1.Text.Length;
    		}

		}
		void TxtNota2TextChanged(object sender, EventArgs e)
		{

    		string apenasNumeros = Regex.Replace(txtNota2.Text, "[^0-9]", "");
    
    		if (txtNota2.Text != apenasNumeros)
    		{
        		txtNota2.Text = apenasNumeros;
        
        		txtNota2.SelectionStart = txtNota2.Text.Length;
    		}
		}
		void TxtNota3TextChanged(object sender, EventArgs e)
		{

    		string apenasNumeros = Regex.Replace(txtNota3.Text, "[^0-9]", "");
    
    		if (txtNota3.Text != apenasNumeros)
    		{
        		txtNota3.Text = apenasNumeros;
        
        		txtNota3.SelectionStart = txtNota3.Text.Length;
    		}
		}
		void TxtNota4TextChanged(object sender, EventArgs e)
		{

    		string apenasNumeros = Regex.Replace(txtNota4.Text, "[^0-9]", "");
    
    		if (txtNota4.Text != apenasNumeros)
    		{
        		txtNota4.Text = apenasNumeros;
        
        		txtNota4.SelectionStart = txtNota4.Text.Length;
    		}
		}
		void BtnRemoverClick(object sender, EventArgs e)
		{
			if (lstAlunos.SelectedIndex != -1)
		{
    		lstAlunos.Items.RemoveAt(lstAlunos.SelectedIndex);
		}
		else
		{
    		MessageBox.Show("Selecione um item da lista para remover.", "Aviso");
		}
		}
		void BtnLimparClick(object sender, EventArgs e)
		{
			lstAlunos.Items.Clear();
		}
		
		void BtnGerarResumoClick(object sender, EventArgs e)
		{
    		int quantidadeAlunos = lstAlunos.Items.Count;
    		int aprovados = 0;
   			int recuperacao = 0;
    		int reprovadoNota = 0;
    		int reprovadoFrequencia = 0;

    		// percorre cada item que está na ListBox
    		foreach (object item in lstAlunos.Items)
    		{
        		string linhaAluno = item.ToString();

        		// verifica qual situação está contida no texto do item da lista
        		if (linhaAluno.Contains("Situação: Aprovado"))
        		{
            		aprovados = aprovados + 1;
        		}
        		else if (linhaAluno.Contains("Situação: Recuperação"))
        		{
            		recuperacao = recuperacao + 1;
        		}
        		else if (linhaAluno.Contains("Situação: Reprovado por nota"))
        		{
            		reprovadoNota = reprovadoNota + 1;
        		}
        		else if (linhaAluno.Contains("Situação: Reprovado por frequência"))
        		{
            		reprovadoFrequencia = reprovadoFrequencia + 1;
        		}
    		}

    		// Exibe o resultado
    		txtResumo.Text = "Total de estudantes: " + quantidadeAlunos.ToString() + "\r\n" +
                     		 "Aprovados: " + aprovados.ToString() + "\r\n" +
                     		 "Recuperação: " + recuperacao.ToString() + "\r\n" +
                     		 "Reprovados por nota: " + reprovadoNota.ToString() + "\r\n" +
                     		 "Reprovados por frequência: " + reprovadoFrequencia.ToString() + "\r\n";
}
	}
}
