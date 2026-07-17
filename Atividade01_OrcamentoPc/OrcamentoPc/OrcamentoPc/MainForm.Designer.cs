/*
 * Created by SharpDevelop.
 * User: Guilherme
 * Date: 13/07/2026
 * Time: 19:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace OrcamentoPc
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNomeCliente;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbPerfil;
		private System.Windows.Forms.ComboBox cmbProcessador;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cmbMemoria;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox cmbArmazenamento;
		private System.Windows.Forms.ComboBox cmbPlacaVideo;
		private System.Windows.Forms.ComboBox cmbPlacaMae;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox cmbFonte;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox cmbGabinete;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.NumericUpDown nudDesconto;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.Button btnLimpar;
		
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
			this.txtNomeCliente = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cmbPerfil = new System.Windows.Forms.ComboBox();
			this.cmbProcessador = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbMemoria = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.cmbArmazenamento = new System.Windows.Forms.ComboBox();
			this.cmbPlacaVideo = new System.Windows.Forms.ComboBox();
			this.cmbPlacaMae = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.cmbFonte = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.cmbGabinete = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.nudDesconto = new System.Windows.Forms.NumericUpDown();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.btnSair = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nudDesconto)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 25);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(618, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Orçamento de computadores";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(140, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nome do cliente:";
			// 
			// txtNomeCliente
			// 
			this.txtNomeCliente.Location = new System.Drawing.Point(137, 54);
			this.txtNomeCliente.Name = "txtNomeCliente";
			this.txtNomeCliente.Size = new System.Drawing.Size(419, 26);
			this.txtNomeCliente.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 109);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(121, 44);
			this.label3.TabIndex = 3;
			this.label3.Text = "Escolha seu perfil de uso:";
			// 
			// cmbPerfil
			// 
			this.cmbPerfil.FormattingEnabled = true;
			this.cmbPerfil.Items.AddRange(new object[] {
			"Administrativo",
			"Professor de tecnologia",
			"Desenvolvedor de Software",
			"Desenvolvedor de Jogos"});
			this.cmbPerfil.Location = new System.Drawing.Point(137, 118);
			this.cmbPerfil.Name = "cmbPerfil";
			this.cmbPerfil.Size = new System.Drawing.Size(419, 26);
			this.cmbPerfil.TabIndex = 4;
			this.cmbPerfil.SelectedIndexChanged += new System.EventHandler(this.CmbPerfilSelectedIndexChanged);
			// 
			// cmbProcessador
			// 
			this.cmbProcessador.FormattingEnabled = true;
			this.cmbProcessador.Items.AddRange(new object[] {
			"Intel Core i5-8500 8a Geração 4.1GHz ~ R$ 449",
			"Intel Core i5 12400F, 2.5GHz (4.4GHz Turbo) ~ R$ 790",
			"Intel Core i5-14600KF, 3.5 GHz (5.3 GHz Turbo) ~ R$ 1.479,99"});
			this.cmbProcessador.Location = new System.Drawing.Point(137, 178);
			this.cmbProcessador.Name = "cmbProcessador";
			this.cmbProcessador.Size = new System.Drawing.Size(419, 26);
			this.cmbProcessador.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(13, 181);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(109, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Processador:";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(13, 226);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 7;
			this.label5.Text = "Memória:";
			// 
			// cmbMemoria
			// 
			this.cmbMemoria.FormattingEnabled = true;
			this.cmbMemoria.Items.AddRange(new object[] {
			"Rise Mode RAM Z 8 GB (1x8 GB) DDR4-3200 ~ R$ 450",
			"Memória Kingston Fury Beast 16 GB (1x16 GB) DDR4-3200 ~ R$ 800",
			"Corsair VENGEANCE LPX 32 GB (2x16 GB) DDR4-3200 ~ R$ 1600"});
			this.cmbMemoria.Location = new System.Drawing.Point(138, 223);
			this.cmbMemoria.Name = "cmbMemoria";
			this.cmbMemoria.Size = new System.Drawing.Size(418, 26);
			this.cmbMemoria.TabIndex = 8;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(12, 370);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(134, 23);
			this.label6.TabIndex = 9;
			this.label6.Text = "Armazenamento:";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(12, 416);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(134, 23);
			this.label7.TabIndex = 10;
			this.label7.Text = "Placa de vídeo:";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(13, 274);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 11;
			this.label8.Text = "Placa Mãe:";
			// 
			// cmbArmazenamento
			// 
			this.cmbArmazenamento.FormattingEnabled = true;
			this.cmbArmazenamento.Items.AddRange(new object[] {
			"Alltek SSD SSD 256 GB 2.5\" ~ R$ 273",
			"Kingston SSD A400 480 GB 2.5\" ~ R$ 497",
			"Patriot SSD Burst 480 GB 2.5\" ~ R$ 564,00",
			"Kingston NV3 SSD NVMe M.2 1 TB ~ R$ 999,89"});
			this.cmbArmazenamento.Location = new System.Drawing.Point(137, 367);
			this.cmbArmazenamento.Name = "cmbArmazenamento";
			this.cmbArmazenamento.Size = new System.Drawing.Size(419, 26);
			this.cmbArmazenamento.TabIndex = 12;
			// 
			// cmbPlacaVideo
			// 
			this.cmbPlacaVideo.FormattingEnabled = true;
			this.cmbPlacaVideo.Items.AddRange(new object[] {
			"Integrada",
			"Mancer Radeon RX 580 8 GB ~ R$ 865,72",
			"MSI GeForce RTX 5060 Shadow 2X 8 GB ~ R$ 2.158,99"});
			this.cmbPlacaVideo.Location = new System.Drawing.Point(137, 413);
			this.cmbPlacaVideo.Name = "cmbPlacaVideo";
			this.cmbPlacaVideo.Size = new System.Drawing.Size(419, 26);
			this.cmbPlacaVideo.TabIndex = 13;
			// 
			// cmbPlacaMae
			// 
			this.cmbPlacaMae.FormattingEnabled = true;
			this.cmbPlacaMae.Items.AddRange(new object[] {
			"MSI A520M-A PRO Micro ATX AM4 ~ R$ 411",
			"Gigabyte B550M Aorus Elite Micro ATX AM4 ~ R$ 750",
			"Gigabyte H610M K DDR4 Micro ATX LGA 1700 ~ R$ 439"});
			this.cmbPlacaMae.Location = new System.Drawing.Point(137, 271);
			this.cmbPlacaMae.Name = "cmbPlacaMae";
			this.cmbPlacaMae.Size = new System.Drawing.Size(419, 26);
			this.cmbPlacaMae.TabIndex = 14;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(12, 460);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 15;
			this.label9.Text = "Fonte:";
			// 
			// cmbFonte
			// 
			this.cmbFonte.FormattingEnabled = true;
			this.cmbFonte.Items.AddRange(new object[] {
			"Rise Mode Zeus 550W 550 W 80+ Bronze Full-Modular ATX ~ R$ 348",
			"Corsair CX650 650 W  80+ Bronze ATX ~ R$ 358",
			"Corsair CX750 750 W 80+ Bronze ATX ~ R$ 460"});
			this.cmbFonte.Location = new System.Drawing.Point(137, 457);
			this.cmbFonte.Name = "cmbFonte";
			this.cmbFonte.Size = new System.Drawing.Size(419, 26);
			this.cmbFonte.TabIndex = 16;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(13, 323);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 23);
			this.label10.TabIndex = 17;
			this.label10.Text = "Gabinete:";
			// 
			// cmbGabinete
			// 
			this.cmbGabinete.FormattingEnabled = true;
			this.cmbGabinete.Items.AddRange(new object[] {
			"Mancer CV100 (Preto) MicroATX Mid Tower ~ R$ 117"});
			this.cmbGabinete.Location = new System.Drawing.Point(137, 320);
			this.cmbGabinete.Name = "cmbGabinete";
			this.cmbGabinete.Size = new System.Drawing.Size(419, 26);
			this.cmbGabinete.TabIndex = 18;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(138, 508);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(205, 23);
			this.label11.TabIndex = 19;
			this.label11.Text = "Informe o desconto (em %):";
			// 
			// nudDesconto
			// 
			this.nudDesconto.Location = new System.Drawing.Point(349, 505);
			this.nudDesconto.Name = "nudDesconto";
			this.nudDesconto.Size = new System.Drawing.Size(51, 26);
			this.nudDesconto.TabIndex = 20;
			this.nudDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalcular.Location = new System.Drawing.Point(285, 548);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(115, 37);
			this.btnCalcular.TabIndex = 21;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// btnSair
			// 
			this.btnSair.Location = new System.Drawing.Point(503, 548);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(53, 37);
			this.btnSair.TabIndex = 22;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = true;
			this.btnSair.Click += new System.EventHandler(this.BtnSairClick);
			// 
			// btnLimpar
			// 
			this.btnLimpar.Location = new System.Drawing.Point(416, 548);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(75, 37);
			this.btnLimpar.TabIndex = 23;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = true;
			this.btnLimpar.Click += new System.EventHandler(this.BtnLimparClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(644, 610);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.nudDesconto);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.cmbGabinete);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.cmbFonte);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.cmbPlacaMae);
			this.Controls.Add(this.cmbPlacaVideo);
			this.Controls.Add(this.cmbArmazenamento);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cmbMemoria);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cmbProcessador);
			this.Controls.Add(this.cmbPerfil);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtNomeCliente);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Orçamento de computadores";
			((System.ComponentModel.ISupportInitialize)(this.nudDesconto)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
