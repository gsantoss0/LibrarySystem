/*
 * Created by SharpDevelop.
 * User: Guilherme
 * Date: 14/07/2026
 * Time: 19:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace BoletimEscolar
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtAluno;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtTurma;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtNota1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtNota2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtNota3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtNota4;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.NumericUpDown nudFrequencia;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Button btnGerarResumo;
		private System.Windows.Forms.ListBox lstAlunos;
		private System.Windows.Forms.Button btnRemover;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtResumo;
		private System.Windows.Forms.Button btnAdicionar;
		private System.Windows.Forms.Label lblMedia;
		private System.Windows.Forms.Label lblSituacao;
		
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
			this.txtAluno = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtTurma = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtNota1 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtNota2 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtNota3 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtNota4 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.nudFrequencia = new System.Windows.Forms.NumericUpDown();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.btnGerarResumo = new System.Windows.Forms.Button();
			this.lstAlunos = new System.Windows.Forms.ListBox();
			this.btnRemover = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txtResumo = new System.Windows.Forms.TextBox();
			this.btnAdicionar = new System.Windows.Forms.Button();
			this.lblMedia = new System.Windows.Forms.Label();
			this.lblSituacao = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.nudFrequencia)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(442, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Boletim escolar digital";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(41, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Aluno:";
			// 
			// txtAluno
			// 
			this.txtAluno.Location = new System.Drawing.Point(96, 56);
			this.txtAluno.Name = "txtAluno";
			this.txtAluno.Size = new System.Drawing.Size(325, 26);
			this.txtAluno.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(41, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Turma:";
			// 
			// txtTurma
			// 
			this.txtTurma.Location = new System.Drawing.Point(96, 93);
			this.txtTurma.Name = "txtTurma";
			this.txtTurma.Size = new System.Drawing.Size(325, 26);
			this.txtTurma.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(41, 164);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 5;
			this.label4.Text = "Nota 1:";
			// 
			// txtNota1
			// 
			this.txtNota1.Location = new System.Drawing.Point(96, 161);
			this.txtNota1.Name = "txtNota1";
			this.txtNota1.Size = new System.Drawing.Size(100, 26);
			this.txtNota1.TabIndex = 6;
			this.txtNota1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtNota1.TextChanged += new System.EventHandler(this.TxtNota1TextChanged);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(41, 205);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 7;
			this.label5.Text = "Nota 2:";
			// 
			// txtNota2
			// 
			this.txtNota2.Location = new System.Drawing.Point(96, 202);
			this.txtNota2.Name = "txtNota2";
			this.txtNota2.Size = new System.Drawing.Size(100, 26);
			this.txtNota2.TabIndex = 8;
			this.txtNota2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtNota2.TextChanged += new System.EventHandler(this.TxtNota2TextChanged);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(254, 164);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 9;
			this.label6.Text = "Nota 3:";
			// 
			// txtNota3
			// 
			this.txtNota3.Location = new System.Drawing.Point(321, 161);
			this.txtNota3.Name = "txtNota3";
			this.txtNota3.Size = new System.Drawing.Size(100, 26);
			this.txtNota3.TabIndex = 10;
			this.txtNota3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtNota3.TextChanged += new System.EventHandler(this.TxtNota3TextChanged);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(254, 205);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 11;
			this.label7.Text = "Nota 4:";
			// 
			// txtNota4
			// 
			this.txtNota4.Location = new System.Drawing.Point(321, 202);
			this.txtNota4.Name = "txtNota4";
			this.txtNota4.Size = new System.Drawing.Size(100, 26);
			this.txtNota4.TabIndex = 12;
			this.txtNota4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtNota4.TextChanged += new System.EventHandler(this.TxtNota4TextChanged);
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(133, 264);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(125, 23);
			this.label8.TabIndex = 13;
			this.label8.Text = "Frequência (%):";
			// 
			// nudFrequencia
			// 
			this.nudFrequencia.Location = new System.Drawing.Point(264, 262);
			this.nudFrequencia.Name = "nudFrequencia";
			this.nudFrequencia.Size = new System.Drawing.Size(58, 26);
			this.nudFrequencia.TabIndex = 14;
			this.nudFrequencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalcular.Location = new System.Drawing.Point(133, 302);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(189, 33);
			this.btnCalcular.TabIndex = 15;
			this.btnCalcular.Text = "Calcular média";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// btnGerarResumo
			// 
			this.btnGerarResumo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGerarResumo.Location = new System.Drawing.Point(133, 466);
			this.btnGerarResumo.Name = "btnGerarResumo";
			this.btnGerarResumo.Size = new System.Drawing.Size(189, 36);
			this.btnGerarResumo.TabIndex = 16;
			this.btnGerarResumo.Text = "Gerar resumo";
			this.btnGerarResumo.UseVisualStyleBackColor = true;
			this.btnGerarResumo.Click += new System.EventHandler(this.BtnGerarResumoClick);
			// 
			// lstAlunos
			// 
			this.lstAlunos.FormattingEnabled = true;
			this.lstAlunos.ItemHeight = 18;
			this.lstAlunos.Location = new System.Drawing.Point(464, 93);
			this.lstAlunos.Name = "lstAlunos";
			this.lstAlunos.Size = new System.Drawing.Size(597, 526);
			this.lstAlunos.TabIndex = 17;
			// 
			// btnRemover
			// 
			this.btnRemover.Location = new System.Drawing.Point(464, 637);
			this.btnRemover.Name = "btnRemover";
			this.btnRemover.Size = new System.Drawing.Size(142, 30);
			this.btnRemover.TabIndex = 18;
			this.btnRemover.Text = "Remover";
			this.btnRemover.UseVisualStyleBackColor = true;
			this.btnRemover.Click += new System.EventHandler(this.BtnRemoverClick);
			// 
			// btnLimpar
			// 
			this.btnLimpar.Location = new System.Drawing.Point(916, 637);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(145, 30);
			this.btnLimpar.TabIndex = 19;
			this.btnLimpar.Text = "Limpar lista";
			this.btnLimpar.UseVisualStyleBackColor = true;
			this.btnLimpar.Click += new System.EventHandler(this.BtnLimparClick);
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(464, 59);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(164, 23);
			this.label9.TabIndex = 20;
			this.label9.Text = "Alunos cadastrados";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(24, 503);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 23);
			this.label10.TabIndex = 21;
			this.label10.Text = "Resumo";
			// 
			// txtResumo
			// 
			this.txtResumo.Location = new System.Drawing.Point(24, 522);
			this.txtResumo.Multiline = true;
			this.txtResumo.Name = "txtResumo";
			this.txtResumo.Size = new System.Drawing.Size(397, 154);
			this.txtResumo.TabIndex = 22;
			// 
			// btnAdicionar
			// 
			this.btnAdicionar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdicionar.Location = new System.Drawing.Point(133, 424);
			this.btnAdicionar.Name = "btnAdicionar";
			this.btnAdicionar.Size = new System.Drawing.Size(189, 36);
			this.btnAdicionar.TabIndex = 23;
			this.btnAdicionar.Text = "Adicionar à lista";
			this.btnAdicionar.UseVisualStyleBackColor = true;
			this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionarClick);
			// 
			// lblMedia
			// 
			this.lblMedia.Location = new System.Drawing.Point(41, 355);
			this.lblMedia.Name = "lblMedia";
			this.lblMedia.Size = new System.Drawing.Size(380, 23);
			this.lblMedia.TabIndex = 24;
			this.lblMedia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblSituacao
			// 
			this.lblSituacao.Location = new System.Drawing.Point(41, 382);
			this.lblSituacao.Name = "lblSituacao";
			this.lblSituacao.Size = new System.Drawing.Size(380, 23);
			this.lblSituacao.TabIndex = 25;
			this.lblSituacao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1104, 688);
			this.Controls.Add(this.lblSituacao);
			this.Controls.Add(this.lblMedia);
			this.Controls.Add(this.btnAdicionar);
			this.Controls.Add(this.txtResumo);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.btnRemover);
			this.Controls.Add(this.lstAlunos);
			this.Controls.Add(this.btnGerarResumo);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.nudFrequencia);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtNota4);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtNota3);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtNota2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtNota1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtTurma);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtAluno);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Boletim escolar";
			((System.ComponentModel.ISupportInitialize)(this.nudFrequencia)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
