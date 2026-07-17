namespace Atividade06_ControleEstoque.Forms
{
    partial class FrmMovimentacoes
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpNovaMov = new System.Windows.Forms.GroupBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.cboProduto = new System.Windows.Forms.ComboBox();
            this.lblEstoqueAtual = new System.Windows.Forms.Label();
            this.txtEstoqueAtual = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblHistorico = new System.Windows.Forms.Label();
            this.dgvMovimentacoes = new System.Windows.Forms.DataGridView();
            this.grpNovaMov.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimentacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // grpNovaMov
            // 
            this.grpNovaMov.Controls.Add(this.lblProduto);
            this.grpNovaMov.Controls.Add(this.cboProduto);
            this.grpNovaMov.Controls.Add(this.lblEstoqueAtual);
            this.grpNovaMov.Controls.Add(this.txtEstoqueAtual);
            this.grpNovaMov.Controls.Add(this.lblTipo);
            this.grpNovaMov.Controls.Add(this.cboTipo);
            this.grpNovaMov.Controls.Add(this.lblQuantidade);
            this.grpNovaMov.Controls.Add(this.nudQuantidade);
            this.grpNovaMov.Controls.Add(this.lblObservacao);
            this.grpNovaMov.Controls.Add(this.txtObservacao);
            this.grpNovaMov.Controls.Add(this.btnRegistrar);
            this.grpNovaMov.Location = new System.Drawing.Point(12, 12);
            this.grpNovaMov.Name = "grpNovaMov";
            this.grpNovaMov.Size = new System.Drawing.Size(560, 185);
            this.grpNovaMov.TabIndex = 0;
            this.grpNovaMov.TabStop = false;
            this.grpNovaMov.Text = "Registrar Nova Movimentação";
            // 
            // lblProduto
            // 
            this.lblProduto.Location = new System.Drawing.Point(15, 25);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(100, 18);
            this.lblProduto.TabIndex = 0;
            this.lblProduto.Text = "Produto:";
            // 
            // cboProduto
            // 
            this.cboProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProduto.FormattingEnabled = true;
            this.cboProduto.Location = new System.Drawing.Point(15, 45);
            this.cboProduto.Name = "cboProduto";
            this.cboProduto.Size = new System.Drawing.Size(250, 21);
            this.cboProduto.TabIndex = 1;
            this.cboProduto.SelectedIndexChanged += new System.EventHandler(this.cboProduto_SelectedIndexChanged);
            // 
            // lblEstoqueAtual
            // 
            this.lblEstoqueAtual.Location = new System.Drawing.Point(280, 25);
            this.lblEstoqueAtual.Name = "lblEstoqueAtual";
            this.lblEstoqueAtual.Size = new System.Drawing.Size(100, 18);
            this.lblEstoqueAtual.TabIndex = 2;
            this.lblEstoqueAtual.Text = "Estoque Atual:";
            // 
            // txtEstoqueAtual
            // 
            this.txtEstoqueAtual.Location = new System.Drawing.Point(280, 45);
            this.txtEstoqueAtual.Name = "txtEstoqueAtual";
            this.txtEstoqueAtual.ReadOnly = true;
            this.txtEstoqueAtual.Size = new System.Drawing.Size(100, 20);
            this.txtEstoqueAtual.TabIndex = 3;
            this.txtEstoqueAtual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTipo
            // 
            this.lblTipo.Location = new System.Drawing.Point(15, 80);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(100, 18);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "Tipo:";
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "ENTRADA",
            "SAIDA"});
            this.cboTipo.Location = new System.Drawing.Point(15, 100);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(120, 21);
            this.cboTipo.TabIndex = 5;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.Location = new System.Drawing.Point(150, 80);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(100, 18);
            this.lblQuantidade.TabIndex = 6;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Location = new System.Drawing.Point(150, 100);
            this.nudQuantidade.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(115, 20);
            this.nudQuantidade.TabIndex = 7;
            this.nudQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblObservacao
            // 
            this.lblObservacao.Location = new System.Drawing.Point(280, 80);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(100, 18);
            this.lblObservacao.TabIndex = 8;
            this.lblObservacao.Text = "Observação:";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(280, 100);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(265, 20);
            this.txtObservacao.TabIndex = 9;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(15, 140);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(150, 30);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar Movimentação";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblHistorico
            // 
            this.lblHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorico.Location = new System.Drawing.Point(12, 210);
            this.lblHistorico.Name = "lblHistorico";
            this.lblHistorico.Size = new System.Drawing.Size(200, 18);
            this.lblHistorico.TabIndex = 1;
            this.lblHistorico.Text = "Histórico de Movimentações:";
            // 
            // dgvMovimentacoes
            // 
            this.dgvMovimentacoes.AllowUserToAddRows = false;
            this.dgvMovimentacoes.AllowUserToDeleteRows = false;
            this.dgvMovimentacoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMovimentacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimentacoes.Location = new System.Drawing.Point(12, 230);
            this.dgvMovimentacoes.Name = "dgvMovimentacoes";
            this.dgvMovimentacoes.ReadOnly = true;
            this.dgvMovimentacoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovimentacoes.Size = new System.Drawing.Size(560, 200);
            this.dgvMovimentacoes.TabIndex = 2;
            // 
            // FrmMovimentacoes
            // 
            this.ClientSize = new System.Drawing.Size(584, 442);
            this.Controls.Add(this.dgvMovimentacoes);
            this.Controls.Add(this.lblHistorico);
            this.Controls.Add(this.grpNovaMov);
            this.MaximizeBox = false;
            this.Name = "FrmMovimentacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimentação de Estoque";
            this.Load += new System.EventHandler(this.FrmMovimentacoes_Load);
            this.grpNovaMov.ResumeLayout(false);
            this.grpNovaMov.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimentacoes)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox grpNovaMov;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.ComboBox cboProduto;
        private System.Windows.Forms.Label lblEstoqueAtual;
        private System.Windows.Forms.TextBox txtEstoqueAtual;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblHistorico;
        private System.Windows.Forms.DataGridView dgvMovimentacoes;
    }
}