/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 15/07/2026
 * Time: 08:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ControleEstacionamento
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cboTipoVeiculo;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtModelo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPlaca;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DateTimePicker dtpEntrada;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dtpSaida;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btnMostrarTodos;
		private System.Windows.Forms.Button btnPesquisar;
		private System.Windows.Forms.TextBox txtPesquisarPlaca;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DataGridView dgvVeiculos;
		private System.Windows.Forms.DataGridViewTextBoxColumn colModelo;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPlaca;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn colEntrada;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSaida;
		private System.Windows.Forms.DataGridViewTextBoxColumn colHoras;
		private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSituacao;
		private System.Windows.Forms.Button btnRegistrarEntrada;
		private System.Windows.Forms.Button btnRegistrarSaida;
		private System.Windows.Forms.Button btnRemover;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Button btnEncerrar;
		private System.Windows.Forms.Label lblEstacionados;
		private System.Windows.Forms.Label lblFinalizados;
		private System.Windows.Forms.Label lblTotalRecebido;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cboTipoVeiculo = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtModelo = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPlaca = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.dtpSaida = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnMostrarTodos = new System.Windows.Forms.Button();
			this.btnPesquisar = new System.Windows.Forms.Button();
			this.txtPesquisarPlaca = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.dgvVeiculos = new System.Windows.Forms.DataGridView();
			this.colModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colHoras = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSituacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnRegistrarEntrada = new System.Windows.Forms.Button();
			this.btnRegistrarSaida = new System.Windows.Forms.Button();
			this.btnRemover = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnEncerrar = new System.Windows.Forms.Button();
			this.lblEstacionados = new System.Windows.Forms.Label();
			this.lblFinalizados = new System.Windows.Forms.Label();
			this.lblTotalRecebido = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVeiculos)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(935, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Controle de estacionamento";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cboTipoVeiculo);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtModelo);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtPlaca);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 58);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(232, 173);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Veículo";
			// 
			// cboTipoVeiculo
			// 
			this.cboTipoVeiculo.FormattingEnabled = true;
			this.cboTipoVeiculo.Location = new System.Drawing.Point(79, 121);
			this.cboTipoVeiculo.Name = "cboTipoVeiculo";
			this.cboTipoVeiculo.Size = new System.Drawing.Size(117, 26);
			this.cboTipoVeiculo.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(15, 104);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 43);
			this.label4.TabIndex = 5;
			this.label4.Text = "Tipo do veículo:";
			// 
			// txtModelo
			// 
			this.txtModelo.Location = new System.Drawing.Point(79, 75);
			this.txtModelo.Name = "txtModelo";
			this.txtModelo.Size = new System.Drawing.Size(117, 26);
			this.txtModelo.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(15, 78);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Placa:";
			// 
			// txtPlaca
			// 
			this.txtPlaca.Location = new System.Drawing.Point(79, 38);
			this.txtPlaca.Name = "txtPlaca";
			this.txtPlaca.Size = new System.Drawing.Size(117, 26);
			this.txtPlaca.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(15, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "Modelo:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.dtpSaida);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.dtpEntrada);
			this.groupBox2.Location = new System.Drawing.Point(12, 248);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(232, 177);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Horários";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(15, 101);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 3;
			this.label6.Text = "Saída:";
			// 
			// dtpSaida
			// 
			this.dtpSaida.CustomFormat = "dd/MM/yyyy HH:mm";
			this.dtpSaida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpSaida.Location = new System.Drawing.Point(15, 127);
			this.dtpSaida.Name = "dtpSaida";
			this.dtpSaida.Size = new System.Drawing.Size(181, 26);
			this.dtpSaida.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(15, 35);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 1;
			this.label5.Text = "Entrada:";
			// 
			// dtpEntrada
			// 
			this.dtpEntrada.CustomFormat = "dd/MM/yyyy HH:mm";
			this.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpEntrada.Location = new System.Drawing.Point(15, 61);
			this.dtpEntrada.Name = "dtpEntrada";
			this.dtpEntrada.Size = new System.Drawing.Size(181, 26);
			this.dtpEntrada.TabIndex = 0;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnMostrarTodos);
			this.groupBox3.Controls.Add(this.btnPesquisar);
			this.groupBox3.Controls.Add(this.txtPesquisarPlaca);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Location = new System.Drawing.Point(12, 431);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(232, 182);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Pesquisa";
			// 
			// btnMostrarTodos
			// 
			this.btnMostrarTodos.Location = new System.Drawing.Point(15, 115);
			this.btnMostrarTodos.Name = "btnMostrarTodos";
			this.btnMostrarTodos.Size = new System.Drawing.Size(181, 30);
			this.btnMostrarTodos.TabIndex = 3;
			this.btnMostrarTodos.Text = "Mostrar todos";
			this.btnMostrarTodos.UseVisualStyleBackColor = true;
			this.btnMostrarTodos.Click += new System.EventHandler(this.BtnMostrarTodosClick);
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.Location = new System.Drawing.Point(15, 79);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Size = new System.Drawing.Size(181, 30);
			this.btnPesquisar.TabIndex = 2;
			this.btnPesquisar.Text = "Pesquisar";
			this.btnPesquisar.UseVisualStyleBackColor = true;
			this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisarClick);
			// 
			// txtPesquisarPlaca
			// 
			this.txtPesquisarPlaca.Location = new System.Drawing.Point(15, 47);
			this.txtPesquisarPlaca.Name = "txtPesquisarPlaca";
			this.txtPesquisarPlaca.Size = new System.Drawing.Size(181, 26);
			this.txtPesquisarPlaca.TabIndex = 1;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(15, 22);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(181, 22);
			this.label7.TabIndex = 0;
			this.label7.Text = "Placa a ser pesquisada:";
			// 
			// dgvVeiculos
			// 
			this.dgvVeiculos.AllowUserToAddRows = false;
			this.dgvVeiculos.AllowUserToDeleteRows = false;
			this.dgvVeiculos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.dgvVeiculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvVeiculos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dgvVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVeiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.colModelo,
			this.colPlaca,
			this.colTipo,
			this.colEntrada,
			this.colSaida,
			this.colHoras,
			this.colValor,
			this.colSituacao});
			this.dgvVeiculos.Location = new System.Drawing.Point(291, 58);
			this.dgvVeiculos.MultiSelect = false;
			this.dgvVeiculos.Name = "dgvVeiculos";
			this.dgvVeiculos.ReadOnly = true;
			this.dgvVeiculos.RowHeadersVisible = false;
			this.dgvVeiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvVeiculos.Size = new System.Drawing.Size(656, 398);
			this.dgvVeiculos.TabIndex = 4;
			this.dgvVeiculos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvVeiculosCellFormatting);
			// 
			// colModelo
			// 
			this.colModelo.HeaderText = "Placa";
			this.colModelo.Name = "colModelo";
			this.colModelo.ReadOnly = true;
			// 
			// colPlaca
			// 
			this.colPlaca.HeaderText = "Modelo";
			this.colPlaca.Name = "colPlaca";
			this.colPlaca.ReadOnly = true;
			// 
			// colTipo
			// 
			this.colTipo.HeaderText = "Tipo";
			this.colTipo.Name = "colTipo";
			this.colTipo.ReadOnly = true;
			// 
			// colEntrada
			// 
			dataGridViewCellStyle1.Format = "dd/MM/yyyy HH:mm";
			this.colEntrada.DefaultCellStyle = dataGridViewCellStyle1;
			this.colEntrada.HeaderText = "Entrada";
			this.colEntrada.Name = "colEntrada";
			this.colEntrada.ReadOnly = true;
			// 
			// colSaida
			// 
			dataGridViewCellStyle2.Format = "dd/MM/yyyy HH:mm";
			this.colSaida.DefaultCellStyle = dataGridViewCellStyle2;
			this.colSaida.HeaderText = "Saída";
			this.colSaida.Name = "colSaida";
			this.colSaida.ReadOnly = true;
			// 
			// colHoras
			// 
			this.colHoras.HeaderText = "Horas";
			this.colHoras.Name = "colHoras";
			this.colHoras.ReadOnly = true;
			// 
			// colValor
			// 
			dataGridViewCellStyle3.Format = "C2";
			this.colValor.DefaultCellStyle = dataGridViewCellStyle3;
			this.colValor.HeaderText = "Valor";
			this.colValor.Name = "colValor";
			this.colValor.ReadOnly = true;
			// 
			// colSituacao
			// 
			this.colSituacao.HeaderText = "Situação";
			this.colSituacao.Name = "colSituacao";
			this.colSituacao.ReadOnly = true;
			// 
			// btnRegistrarEntrada
			// 
			this.btnRegistrarEntrada.Location = new System.Drawing.Point(291, 462);
			this.btnRegistrarEntrada.Name = "btnRegistrarEntrada";
			this.btnRegistrarEntrada.Size = new System.Drawing.Size(140, 35);
			this.btnRegistrarEntrada.TabIndex = 5;
			this.btnRegistrarEntrada.Text = "Registrar entrada";
			this.btnRegistrarEntrada.UseVisualStyleBackColor = true;
			this.btnRegistrarEntrada.Click += new System.EventHandler(this.BtnRegistrarEntradaClick);
			// 
			// btnRegistrarSaida
			// 
			this.btnRegistrarSaida.Location = new System.Drawing.Point(437, 462);
			this.btnRegistrarSaida.Name = "btnRegistrarSaida";
			this.btnRegistrarSaida.Size = new System.Drawing.Size(140, 35);
			this.btnRegistrarSaida.TabIndex = 6;
			this.btnRegistrarSaida.Text = "Registrar saída";
			this.btnRegistrarSaida.UseVisualStyleBackColor = true;
			this.btnRegistrarSaida.Click += new System.EventHandler(this.BtnRegistrarSaidaClick);
			// 
			// btnRemover
			// 
			this.btnRemover.Location = new System.Drawing.Point(644, 462);
			this.btnRemover.Name = "btnRemover";
			this.btnRemover.Size = new System.Drawing.Size(97, 35);
			this.btnRemover.TabIndex = 7;
			this.btnRemover.Text = "Remover";
			this.btnRemover.UseVisualStyleBackColor = true;
			this.btnRemover.Click += new System.EventHandler(this.BtnRemoverClick);
			// 
			// btnLimpar
			// 
			this.btnLimpar.Location = new System.Drawing.Point(747, 462);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(97, 35);
			this.btnLimpar.TabIndex = 8;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = true;
			this.btnLimpar.Click += new System.EventHandler(this.BtnLimparClick);
			// 
			// btnEncerrar
			// 
			this.btnEncerrar.Location = new System.Drawing.Point(850, 462);
			this.btnEncerrar.Name = "btnEncerrar";
			this.btnEncerrar.Size = new System.Drawing.Size(97, 35);
			this.btnEncerrar.TabIndex = 9;
			this.btnEncerrar.Text = "Encerrar";
			this.btnEncerrar.UseVisualStyleBackColor = true;
			this.btnEncerrar.Click += new System.EventHandler(this.BtnEncerrarClick);
			// 
			// lblEstacionados
			// 
			this.lblEstacionados.Location = new System.Drawing.Point(437, 510);
			this.lblEstacionados.Name = "lblEstacionados";
			this.lblEstacionados.Size = new System.Drawing.Size(286, 23);
			this.lblEstacionados.TabIndex = 10;
			// 
			// lblFinalizados
			// 
			this.lblFinalizados.Location = new System.Drawing.Point(437, 546);
			this.lblFinalizados.Name = "lblFinalizados";
			this.lblFinalizados.Size = new System.Drawing.Size(286, 23);
			this.lblFinalizados.TabIndex = 11;
			// 
			// lblTotalRecebido
			// 
			this.lblTotalRecebido.Location = new System.Drawing.Point(437, 579);
			this.lblTotalRecebido.Name = "lblTotalRecebido";
			this.lblTotalRecebido.Size = new System.Drawing.Size(286, 23);
			this.lblTotalRecebido.TabIndex = 12;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(291, 510);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(118, 23);
			this.label8.TabIndex = 13;
			this.label8.Text = "Estacionados:";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(291, 546);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(118, 23);
			this.label9.TabIndex = 14;
			this.label9.Text = "Finalizados:";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(291, 579);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(118, 23);
			this.label10.TabIndex = 15;
			this.label10.Text = "Total recebido:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(959, 625);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.lblTotalRecebido);
			this.Controls.Add(this.lblFinalizados);
			this.Controls.Add(this.lblEstacionados);
			this.Controls.Add(this.btnEncerrar);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.btnRemover);
			this.Controls.Add(this.btnRegistrarSaida);
			this.Controls.Add(this.btnRegistrarEntrada);
			this.Controls.Add(this.dgvVeiculos);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Controle do estacionamento";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVeiculos)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
