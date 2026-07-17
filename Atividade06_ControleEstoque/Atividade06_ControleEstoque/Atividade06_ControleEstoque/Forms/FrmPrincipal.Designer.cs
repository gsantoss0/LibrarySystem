/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 16/07/2026
 * Time: 09:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Atividade06_ControleEstoque.Forms
{
	partial class FrmPrincipal
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnMovimentacoes;
		private System.Windows.Forms.Button btnProdutos;
		private System.Windows.Forms.Button btnAbrirCategorias;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblValorEstimado;
		private System.Windows.Forms.Label lblEstoqueBaixo;
		private System.Windows.Forms.Label lblTotalItens;
		private System.Windows.Forms.Label lblProdutosAtivos;
		private System.Windows.Forms.Label lblTotalProdutos;
		private System.Windows.Forms.DataGridView dgvUltimasMovimentacoes;
		private System.Windows.Forms.GroupBox groupBox3;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnMovimentacoes = new System.Windows.Forms.Button();
			this.btnProdutos = new System.Windows.Forms.Button();
			this.btnAbrirCategorias = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lblValorEstimado = new System.Windows.Forms.Label();
			this.lblEstoqueBaixo = new System.Windows.Forms.Label();
			this.lblTotalItens = new System.Windows.Forms.Label();
			this.lblProdutosAtivos = new System.Windows.Forms.Label();
			this.lblTotalProdutos = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dgvUltimasMovimentacoes = new System.Windows.Forms.DataGridView();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvUltimasMovimentacoes)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(806, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Painel de controle";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnMovimentacoes);
			this.groupBox1.Controls.Add(this.btnProdutos);
			this.groupBox1.Controls.Add(this.btnAbrirCategorias);
			this.groupBox1.Location = new System.Drawing.Point(121, 71);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(585, 107);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Menu";
			// 
			// btnMovimentacoes
			// 
			this.btnMovimentacoes.Location = new System.Drawing.Point(391, 37);
			this.btnMovimentacoes.Name = "btnMovimentacoes";
			this.btnMovimentacoes.Size = new System.Drawing.Size(172, 43);
			this.btnMovimentacoes.TabIndex = 2;
			this.btnMovimentacoes.Text = "Movimentações";
			this.btnMovimentacoes.UseVisualStyleBackColor = true;
			this.btnMovimentacoes.Click += new System.EventHandler(this.btnMovimentacoesClick);
			// 
			// btnProdutos
			// 
			this.btnProdutos.Location = new System.Drawing.Point(205, 37);
			this.btnProdutos.Name = "btnProdutos";
			this.btnProdutos.Size = new System.Drawing.Size(172, 43);
			this.btnProdutos.TabIndex = 1;
			this.btnProdutos.Text = "Produtos";
			this.btnProdutos.UseVisualStyleBackColor = true;
			this.btnProdutos.Click += new System.EventHandler(this.btnProdutosClick);
			// 
			// btnAbrirCategorias
			// 
			this.btnAbrirCategorias.Location = new System.Drawing.Point(20, 37);
			this.btnAbrirCategorias.Name = "btnAbrirCategorias";
			this.btnAbrirCategorias.Size = new System.Drawing.Size(172, 43);
			this.btnAbrirCategorias.TabIndex = 0;
			this.btnAbrirCategorias.Text = "Categorias";
			this.btnAbrirCategorias.UseVisualStyleBackColor = true;
			this.btnAbrirCategorias.Click += new System.EventHandler(this.btnCategoriasClick);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lblValorEstimado);
			this.groupBox2.Controls.Add(this.lblEstoqueBaixo);
			this.groupBox2.Controls.Add(this.lblTotalItens);
			this.groupBox2.Controls.Add(this.lblProdutosAtivos);
			this.groupBox2.Controls.Add(this.lblTotalProdutos);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Location = new System.Drawing.Point(23, 184);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(290, 265);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Indicadores";
			// 
			// lblValorEstimado
			// 
			this.lblValorEstimado.Location = new System.Drawing.Point(131, 188);
			this.lblValorEstimado.Name = "lblValorEstimado";
			this.lblValorEstimado.Size = new System.Drawing.Size(159, 23);
			this.lblValorEstimado.TabIndex = 9;
			this.lblValorEstimado.Text = "-";
			// 
			// lblEstoqueBaixo
			// 
			this.lblEstoqueBaixo.Location = new System.Drawing.Point(159, 152);
			this.lblEstoqueBaixo.Name = "lblEstoqueBaixo";
			this.lblEstoqueBaixo.Size = new System.Drawing.Size(100, 23);
			this.lblEstoqueBaixo.TabIndex = 8;
			this.lblEstoqueBaixo.Text = "-";
			// 
			// lblTotalItens
			// 
			this.lblTotalItens.Location = new System.Drawing.Point(159, 97);
			this.lblTotalItens.Name = "lblTotalItens";
			this.lblTotalItens.Size = new System.Drawing.Size(100, 23);
			this.lblTotalItens.TabIndex = 7;
			this.lblTotalItens.Text = "-";
			// 
			// lblProdutosAtivos
			// 
			this.lblProdutosAtivos.Location = new System.Drawing.Point(159, 62);
			this.lblProdutosAtivos.Name = "lblProdutosAtivos";
			this.lblProdutosAtivos.Size = new System.Drawing.Size(100, 23);
			this.lblProdutosAtivos.TabIndex = 6;
			this.lblProdutosAtivos.Text = "-";
			// 
			// lblTotalProdutos
			// 
			this.lblTotalProdutos.Location = new System.Drawing.Point(159, 39);
			this.lblTotalProdutos.Name = "lblTotalProdutos";
			this.lblTotalProdutos.Size = new System.Drawing.Size(114, 23);
			this.lblTotalProdutos.TabIndex = 5;
			this.lblTotalProdutos.Text = "-";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(6, 175);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(129, 47);
			this.label6.TabIndex = 4;
			this.label6.Text = "Valor estimado do estoque:";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(6, 132);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(129, 43);
			this.label5.TabIndex = 3;
			this.label5.Text = "Produtos com estoque baixo:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(6, 85);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(109, 47);
			this.label4.TabIndex = 2;
			this.label4.Text = "Total de itens no estoque:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(6, 62);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(129, 23);
			this.label3.TabIndex = 1;
			this.label3.Text = "Produtos ativos:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(6, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(147, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "Total de produtos:";
			// 
			// dgvUltimasMovimentacoes
			// 
			this.dgvUltimasMovimentacoes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dgvUltimasMovimentacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUltimasMovimentacoes.Location = new System.Drawing.Point(19, 25);
			this.dgvUltimasMovimentacoes.Name = "dgvUltimasMovimentacoes";
			this.dgvUltimasMovimentacoes.Size = new System.Drawing.Size(435, 223);
			this.dgvUltimasMovimentacoes.TabIndex = 3;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.dgvUltimasMovimentacoes);
			this.groupBox3.Location = new System.Drawing.Point(326, 184);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(471, 265);
			this.groupBox3.TabIndex = 4;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Últimas movimentações";
			// 
			// FrmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(830, 461);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "FrmPrincipal";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Controle de estoque";
			this.Load += new System.EventHandler(this.FrmPrincipalLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvUltimasMovimentacoes)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
