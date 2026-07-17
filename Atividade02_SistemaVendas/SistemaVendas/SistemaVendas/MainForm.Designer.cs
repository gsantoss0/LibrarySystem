/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 14/07/2026
 * Time: 10:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SistemaVendas
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCliente;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtProduto;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtValorUnit;
		private System.Windows.Forms.NumericUpDown nudQuantidade;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdbCartaoDebito;
		private System.Windows.Forms.RadioButton rdbCartaoCredito;
		private System.Windows.Forms.RadioButton rdbPix;
		private System.Windows.Forms.RadioButton rdbDinheiro;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.CheckBox chkEntrega;
		private System.Windows.Forms.CheckBox chkGarantia;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Button btnNovaVenda;
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.TextBox txtResultadoVenda;
		private System.Windows.Forms.Label label8;
		
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
			this.label2 = new System.Windows.Forms.Label();
			this.txtCliente = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtProduto = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtValorUnit = new System.Windows.Forms.TextBox();
			this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdbCartaoDebito = new System.Windows.Forms.RadioButton();
			this.rdbCartaoCredito = new System.Windows.Forms.RadioButton();
			this.rdbPix = new System.Windows.Forms.RadioButton();
			this.rdbDinheiro = new System.Windows.Forms.RadioButton();
			this.label7 = new System.Windows.Forms.Label();
			this.chkEntrega = new System.Windows.Forms.CheckBox();
			this.chkGarantia = new System.Windows.Forms.CheckBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.btnNovaVenda = new System.Windows.Forms.Button();
			this.btnSair = new System.Windows.Forms.Button();
			this.txtResultadoVenda = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(484, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Sistema de vendas e descontos";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(31, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Cliente:";
			// 
			// txtCliente
			// 
			this.txtCliente.Location = new System.Drawing.Point(102, 46);
			this.txtCliente.Name = "txtCliente";
			this.txtCliente.Size = new System.Drawing.Size(362, 26);
			this.txtCliente.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(31, 87);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Produto:";
			// 
			// txtProduto
			// 
			this.txtProduto.Location = new System.Drawing.Point(102, 84);
			this.txtProduto.Name = "txtProduto";
			this.txtProduto.Size = new System.Drawing.Size(362, 26);
			this.txtProduto.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(31, 128);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(115, 23);
			this.label4.TabIndex = 5;
			this.label4.Text = "Valor unitário:";
			// 
			// txtValorUnit
			// 
			this.txtValorUnit.Location = new System.Drawing.Point(142, 125);
			this.txtValorUnit.Name = "txtValorUnit";
			this.txtValorUnit.Size = new System.Drawing.Size(136, 26);
			this.txtValorUnit.TabIndex = 6;
			this.txtValorUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// nudQuantidade
			// 
			this.nudQuantidade.Location = new System.Drawing.Point(399, 126);
			this.nudQuantidade.Name = "nudQuantidade";
			this.nudQuantidade.Size = new System.Drawing.Size(65, 26);
			this.nudQuantidade.TabIndex = 7;
			this.nudQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nudQuantidade.Value = new decimal(new int[] {
			1,
			0,
			0,
			0});
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(293, 129);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Quantidade:";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(31, 177);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(433, 23);
			this.label6.TabIndex = 9;
			this.label6.Text = "Forma de pagamento";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdbCartaoDebito);
			this.groupBox1.Controls.Add(this.rdbCartaoCredito);
			this.groupBox1.Controls.Add(this.rdbPix);
			this.groupBox1.Controls.Add(this.rdbDinheiro);
			this.groupBox1.Location = new System.Drawing.Point(121, 203);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(288, 89);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			// 
			// rdbCartaoDebito
			// 
			this.rdbCartaoDebito.Location = new System.Drawing.Point(121, 55);
			this.rdbCartaoDebito.Name = "rdbCartaoDebito";
			this.rdbCartaoDebito.Size = new System.Drawing.Size(164, 24);
			this.rdbCartaoDebito.TabIndex = 3;
			this.rdbCartaoDebito.TabStop = true;
			this.rdbCartaoDebito.Text = "Cartão de débito";
			this.rdbCartaoDebito.UseVisualStyleBackColor = true;
			// 
			// rdbCartaoCredito
			// 
			this.rdbCartaoCredito.Location = new System.Drawing.Point(121, 25);
			this.rdbCartaoCredito.Name = "rdbCartaoCredito";
			this.rdbCartaoCredito.Size = new System.Drawing.Size(164, 24);
			this.rdbCartaoCredito.TabIndex = 2;
			this.rdbCartaoCredito.TabStop = true;
			this.rdbCartaoCredito.Text = "Cartão de crédito";
			this.rdbCartaoCredito.UseVisualStyleBackColor = true;
			// 
			// rdbPix
			// 
			this.rdbPix.Location = new System.Drawing.Point(11, 55);
			this.rdbPix.Name = "rdbPix";
			this.rdbPix.Size = new System.Drawing.Size(104, 24);
			this.rdbPix.TabIndex = 1;
			this.rdbPix.TabStop = true;
			this.rdbPix.Text = "Pix";
			this.rdbPix.UseVisualStyleBackColor = true;
			// 
			// rdbDinheiro
			// 
			this.rdbDinheiro.Location = new System.Drawing.Point(11, 25);
			this.rdbDinheiro.Name = "rdbDinheiro";
			this.rdbDinheiro.Size = new System.Drawing.Size(104, 24);
			this.rdbDinheiro.TabIndex = 0;
			this.rdbDinheiro.TabStop = true;
			this.rdbDinheiro.Text = "Dinheiro";
			this.rdbDinheiro.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(31, 310);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(176, 23);
			this.label7.TabIndex = 11;
			this.label7.Text = "Serviços";
			// 
			// chkEntrega
			// 
			this.chkEntrega.Location = new System.Drawing.Point(121, 336);
			this.chkEntrega.Name = "chkEntrega";
			this.chkEntrega.Size = new System.Drawing.Size(104, 24);
			this.chkEntrega.TabIndex = 12;
			this.chkEntrega.Text = "Entrega";
			this.chkEntrega.UseVisualStyleBackColor = true;
			// 
			// chkGarantia
			// 
			this.chkGarantia.Location = new System.Drawing.Point(242, 336);
			this.chkGarantia.Name = "chkGarantia";
			this.chkGarantia.Size = new System.Drawing.Size(169, 24);
			this.chkGarantia.TabIndex = 13;
			this.chkGarantia.Text = "Garantia estendida";
			this.chkGarantia.UseVisualStyleBackColor = true;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalcular.Location = new System.Drawing.Point(121, 378);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(84, 34);
			this.btnCalcular.TabIndex = 14;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// btnNovaVenda
			// 
			this.btnNovaVenda.Location = new System.Drawing.Point(211, 378);
			this.btnNovaVenda.Name = "btnNovaVenda";
			this.btnNovaVenda.Size = new System.Drawing.Size(103, 34);
			this.btnNovaVenda.TabIndex = 15;
			this.btnNovaVenda.Text = "Nova venda";
			this.btnNovaVenda.UseVisualStyleBackColor = true;
			this.btnNovaVenda.Click += new System.EventHandler(this.BtnNovaVendaClick);
			// 
			// btnSair
			// 
			this.btnSair.Location = new System.Drawing.Point(325, 378);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(86, 34);
			this.btnSair.TabIndex = 16;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = true;
			this.btnSair.Click += new System.EventHandler(this.BtnSairClick);
			// 
			// txtResultadoVenda
			// 
			this.txtResultadoVenda.Location = new System.Drawing.Point(526, 87);
			this.txtResultadoVenda.Multiline = true;
			this.txtResultadoVenda.Name = "txtResultadoVenda";
			this.txtResultadoVenda.Size = new System.Drawing.Size(305, 261);
			this.txtResultadoVenda.TabIndex = 17;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(526, 61);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(162, 23);
			this.label8.TabIndex = 18;
			this.label8.Text = "Resultado da venda";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(866, 461);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtResultadoVenda);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnNovaVenda);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.chkGarantia);
			this.Controls.Add(this.chkEntrega);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.nudQuantidade);
			this.Controls.Add(this.txtValorUnit);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtProduto);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtCliente);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sistema de Vendas";
			((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
