namespace Atividade06_ControleEstoque.Forms
{
    partial class FrmProdutos
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
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.lblPrecoCompra = new System.Windows.Forms.Label();
            this.txtPrecoCompra = new System.Windows.Forms.TextBox();
            this.lblPrecoVenda = new System.Windows.Forms.Label();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            this.lblEstoqueAtual = new System.Windows.Forms.Label();
            this.txtEstoqueAtual = new System.Windows.Forms.TextBox();
            this.lblEstoqueMinimo = new System.Windows.Forms.Label();
            this.nudEstoqueMinimo = new System.Windows.Forms.NumericUpDown();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAtivarDesativar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstoqueMinimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(12, 15);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(60, 18);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 35);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(60, 20);
            this.txtId.TabIndex = 1;
            this.txtId.TabStop = false;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(85, 15);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(120, 18);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(85, 35);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(120, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.Location = new System.Drawing.Point(220, 15);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(320, 18);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome do Produto:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(220, 35);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(320, 20);
            this.txtNome.TabIndex = 5;
            // 
            // lblCategoria
            // 
            this.lblCategoria.Location = new System.Drawing.Point(550, 15);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(200, 18);
            this.lblCategoria.TabIndex = 6;
            this.lblCategoria.Text = "Categoria:";
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(550, 35);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(200, 21);
            this.cboCategoria.TabIndex = 7;
            // 
            // lblPrecoCompra
            // 
            this.lblPrecoCompra.Location = new System.Drawing.Point(12, 75);
            this.lblPrecoCompra.Name = "lblPrecoCompra";
            this.lblPrecoCompra.Size = new System.Drawing.Size(110, 18);
            this.lblPrecoCompra.TabIndex = 8;
            this.lblPrecoCompra.Text = "Preço de Compra:";
            // 
            // txtPrecoCompra
            // 
            this.txtPrecoCompra.Location = new System.Drawing.Point(12, 95);
            this.txtPrecoCompra.Name = "txtPrecoCompra";
            this.txtPrecoCompra.Size = new System.Drawing.Size(110, 20);
            this.txtPrecoCompra.TabIndex = 9;
            // 
            // lblPrecoVenda
            // 
            this.lblPrecoVenda.Location = new System.Drawing.Point(140, 75);
            this.lblPrecoVenda.Name = "lblPrecoVenda";
            this.lblPrecoVenda.Size = new System.Drawing.Size(110, 18);
            this.lblPrecoVenda.TabIndex = 10;
            this.lblPrecoVenda.Text = "Preço de Venda:";
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Location = new System.Drawing.Point(140, 95);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(110, 20);
            this.txtPrecoVenda.TabIndex = 11;
            // 
            // lblEstoqueAtual
            // 
            this.lblEstoqueAtual.Location = new System.Drawing.Point(270, 75);
            this.lblEstoqueAtual.Name = "lblEstoqueAtual";
            this.lblEstoqueAtual.Size = new System.Drawing.Size(110, 18);
            this.lblEstoqueAtual.TabIndex = 12;
            this.lblEstoqueAtual.Text = "Estoque Atual:";
            // 
            // txtEstoqueAtual
            // 
            this.txtEstoqueAtual.Location = new System.Drawing.Point(270, 95);
            this.txtEstoqueAtual.Name = "txtEstoqueAtual";
            this.txtEstoqueAtual.ReadOnly = true;
            this.txtEstoqueAtual.Size = new System.Drawing.Size(110, 20);
            this.txtEstoqueAtual.TabIndex = 13;
            this.txtEstoqueAtual.TabStop = false;
            this.txtEstoqueAtual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEstoqueMinimo
            // 
            this.lblEstoqueMinimo.Location = new System.Drawing.Point(400, 75);
            this.lblEstoqueMinimo.Name = "lblEstoqueMinimo";
            this.lblEstoqueMinimo.Size = new System.Drawing.Size(110, 18);
            this.lblEstoqueMinimo.TabIndex = 14;
            this.lblEstoqueMinimo.Text = "Estoque Mínimo:";
            // 
            // nudEstoqueMinimo
            // 
            this.nudEstoqueMinimo.Location = new System.Drawing.Point(400, 95);
            this.nudEstoqueMinimo.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudEstoqueMinimo.Name = "nudEstoqueMinimo";
            this.nudEstoqueMinimo.Size = new System.Drawing.Size(110, 20);
            this.nudEstoqueMinimo.TabIndex = 15;
            // 
            // chkAtivo
            // 
            this.chkAtivo.Checked = true;
            this.chkAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAtivo.Location = new System.Drawing.Point(530, 95);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(100, 24);
            this.chkAtivo.TabIndex = 16;
            this.chkAtivo.Text = "Produto Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 140);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(120, 30);
            this.btnSalvar.TabIndex = 17;
            this.btnSalvar.Text = "Salvar Produto";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAtivarDesativar
            // 
            this.btnAtivarDesativar.Location = new System.Drawing.Point(140, 140);
            this.btnAtivarDesativar.Name = "btnAtivarDesativar";
            this.btnAtivarDesativar.Size = new System.Drawing.Size(150, 30);
            this.btnAtivarDesativar.TabIndex = 18;
            this.btnAtivarDesativar.Text = "Alterar Situação (Ativo)";
            this.btnAtivarDesativar.UseVisualStyleBackColor = true;
            this.btnAtivarDesativar.Click += new System.EventHandler(this.btnAtivarDesativar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(298, 140);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(120, 30);
            this.btnLimpar.TabIndex = 19;
            this.btnLimpar.Text = "Limpar Campos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(12, 190);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(740, 260);
            this.dgvProdutos.TabIndex = 20;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            // 
            // FrmProdutos
            // 
            this.ClientSize = new System.Drawing.Size(764, 462);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAtivarDesativar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.chkAtivo);
            this.Controls.Add(this.nudEstoqueMinimo);
            this.Controls.Add(this.lblEstoqueMinimo);
            this.Controls.Add(this.txtEstoqueAtual);
            this.Controls.Add(this.lblEstoqueAtual);
            this.Controls.Add(this.txtPrecoVenda);
            this.Controls.Add(this.lblPrecoVenda);
            this.Controls.Add(this.txtPrecoCompra);
            this.Controls.Add(this.lblPrecoCompra);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.MaximizeBox = false;
            this.Name = "FrmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.FrmProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudEstoqueMinimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label lblPrecoCompra;
        private System.Windows.Forms.TextBox txtPrecoCompra;
        private System.Windows.Forms.Label lblPrecoVenda;
        private System.Windows.Forms.TextBox txtPrecoVenda;
        private System.Windows.Forms.Label lblEstoqueAtual;
        private System.Windows.Forms.TextBox txtEstoqueAtual;
        private System.Windows.Forms.Label lblEstoqueMinimo;
        private System.Windows.Forms.NumericUpDown nudEstoqueMinimo;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAtivarDesativar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridView dgvProdutos;
    }
}