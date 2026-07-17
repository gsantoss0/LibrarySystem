namespace CadastroClientes.Forms
{
    partial class FrmClientes
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
        	this.groupBoxDados = new System.Windows.Forms.GroupBox();
        	this.chkAtivo = new System.Windows.Forms.CheckBox();
        	this.txtCidade = new System.Windows.Forms.TextBox();
        	this.lblCidade = new System.Windows.Forms.Label();
        	this.txtTelefone = new System.Windows.Forms.TextBox();
        	this.lblTelefone = new System.Windows.Forms.Label();
        	this.txtEmail = new System.Windows.Forms.TextBox();
        	this.lblEmail = new System.Windows.Forms.Label();
        	this.txtCPF = new System.Windows.Forms.TextBox();
        	this.lblCPF = new System.Windows.Forms.Label();
        	this.txtNome = new System.Windows.Forms.TextBox();
        	this.lblNome = new System.Windows.Forms.Label();
        	this.txtId = new System.Windows.Forms.TextBox();
        	this.lblId = new System.Windows.Forms.Label();
        	this.groupBoxPesquisa = new System.Windows.Forms.GroupBox();
        	this.btnMostrarTodos = new System.Windows.Forms.Button();
        	this.btnPesquisar = new System.Windows.Forms.Button();
        	this.txtPesquisa = new System.Windows.Forms.TextBox();
        	this.lblPesquisa = new System.Windows.Forms.Label();
        	this.dgvClientes = new System.Windows.Forms.DataGridView();
        	this.btnNovo = new System.Windows.Forms.Button();
        	this.btnSalvar = new System.Windows.Forms.Button();
        	this.btnExcluir = new System.Windows.Forms.Button();
        	this.btnAtivarDesativar = new System.Windows.Forms.Button();
        	this.btnCancelar = new System.Windows.Forms.Button();
        	this.groupBoxDados.SuspendLayout();
        	this.groupBoxPesquisa.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// groupBoxDados
        	// 
        	this.groupBoxDados.Controls.Add(this.chkAtivo);
        	this.groupBoxDados.Controls.Add(this.txtCidade);
        	this.groupBoxDados.Controls.Add(this.lblCidade);
        	this.groupBoxDados.Controls.Add(this.txtTelefone);
        	this.groupBoxDados.Controls.Add(this.lblTelefone);
        	this.groupBoxDados.Controls.Add(this.txtEmail);
        	this.groupBoxDados.Controls.Add(this.lblEmail);
        	this.groupBoxDados.Controls.Add(this.txtCPF);
        	this.groupBoxDados.Controls.Add(this.lblCPF);
        	this.groupBoxDados.Controls.Add(this.txtNome);
        	this.groupBoxDados.Controls.Add(this.lblNome);
        	this.groupBoxDados.Controls.Add(this.txtId);
        	this.groupBoxDados.Controls.Add(this.lblId);
        	this.groupBoxDados.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.groupBoxDados.Location = new System.Drawing.Point(12, 12);
        	this.groupBoxDados.Name = "groupBoxDados";
        	this.groupBoxDados.Size = new System.Drawing.Size(760, 150);
        	this.groupBoxDados.TabIndex = 0;
        	this.groupBoxDados.TabStop = false;
        	this.groupBoxDados.Text = " Dados do Cliente ";
        	// 
        	// chkAtivo
        	// 
        	this.chkAtivo.Checked = true;
        	this.chkAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
        	this.chkAtivo.Location = new System.Drawing.Point(620, 110);
        	this.chkAtivo.Name = "chkAtivo";
        	this.chkAtivo.Size = new System.Drawing.Size(104, 24);
        	this.chkAtivo.TabIndex = 12;
        	this.chkAtivo.Text = "Ativo";
        	this.chkAtivo.UseVisualStyleBackColor = true;
        	// 
        	// txtCidade
        	// 
        	this.txtCidade.Location = new System.Drawing.Point(320, 110);
        	this.txtCidade.Name = "txtCidade";
        	this.txtCidade.Size = new System.Drawing.Size(260, 22);
        	this.txtCidade.TabIndex = 11;
        	// 
        	// lblCidade
        	// 
        	this.lblCidade.Location = new System.Drawing.Point(320, 90);
        	this.lblCidade.Name = "lblCidade";
        	this.lblCidade.Size = new System.Drawing.Size(100, 20);
        	this.lblCidade.TabIndex = 10;
        	this.lblCidade.Text = "Cidade:";
        	// 
        	// txtTelefone
        	// 
        	this.txtTelefone.Location = new System.Drawing.Point(15, 110);
        	this.txtTelefone.Name = "txtTelefone";
        	this.txtTelefone.Size = new System.Drawing.Size(280, 22);
        	this.txtTelefone.TabIndex = 9;
        	// 
        	// lblTelefone
        	// 
        	this.lblTelefone.Location = new System.Drawing.Point(15, 90);
        	this.lblTelefone.Name = "lblTelefone";
        	this.lblTelefone.Size = new System.Drawing.Size(100, 20);
        	this.lblTelefone.TabIndex = 8;
        	this.lblTelefone.Text = "Telefone:";
        	// 
        	// txtEmail
        	// 
        	this.txtEmail.Location = new System.Drawing.Point(440, 50);
        	this.txtEmail.Name = "txtEmail";
        	this.txtEmail.Size = new System.Drawing.Size(300, 22);
        	this.txtEmail.TabIndex = 7;
        	// 
        	// lblEmail
        	// 
        	this.lblEmail.Location = new System.Drawing.Point(440, 30);
        	this.lblEmail.Name = "lblEmail";
        	this.lblEmail.Size = new System.Drawing.Size(100, 20);
        	this.lblEmail.TabIndex = 6;
        	this.lblEmail.Text = "E-mail:";
        	// 
        	// txtCPF
        	// 
        	this.txtCPF.Location = new System.Drawing.Point(280, 50);
        	this.txtCPF.Name = "txtCPF";
        	this.txtCPF.Size = new System.Drawing.Size(140, 22);
        	this.txtCPF.TabIndex = 5;
        	// 
        	// lblCPF
        	// 
        	this.lblCPF.Location = new System.Drawing.Point(280, 30);
        	this.lblCPF.Name = "lblCPF";
        	this.lblCPF.Size = new System.Drawing.Size(100, 20);
        	this.lblCPF.TabIndex = 4;
        	this.lblCPF.Text = "CPF:";
        	// 
        	// txtNome
        	// 
        	this.txtNome.Location = new System.Drawing.Point(90, 50);
        	this.txtNome.Name = "txtNome";
        	this.txtNome.Size = new System.Drawing.Size(170, 22);
        	this.txtNome.TabIndex = 3;
        	// 
        	// lblNome
        	// 
        	this.lblNome.Location = new System.Drawing.Point(90, 30);
        	this.lblNome.Name = "lblNome";
        	this.lblNome.Size = new System.Drawing.Size(100, 20);
        	this.lblNome.TabIndex = 2;
        	this.lblNome.Text = "Nome:";
        	// 
        	// txtId
        	// 
        	this.txtId.Location = new System.Drawing.Point(15, 50);
        	this.txtId.Name = "txtId";
        	this.txtId.ReadOnly = true;
        	this.txtId.Size = new System.Drawing.Size(60, 22);
        	this.txtId.TabIndex = 1;
        	// 
        	// lblId
        	// 
        	this.lblId.Location = new System.Drawing.Point(15, 30);
        	this.lblId.Name = "lblId";
        	this.lblId.Size = new System.Drawing.Size(50, 20);
        	this.lblId.TabIndex = 0;
        	this.lblId.Text = "ID:";
        	// 
        	// groupBoxPesquisa
        	// 
        	this.groupBoxPesquisa.Controls.Add(this.btnMostrarTodos);
        	this.groupBoxPesquisa.Controls.Add(this.btnPesquisar);
        	this.groupBoxPesquisa.Controls.Add(this.txtPesquisa);
        	this.groupBoxPesquisa.Controls.Add(this.lblPesquisa);
        	this.groupBoxPesquisa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.groupBoxPesquisa.Location = new System.Drawing.Point(12, 175);
        	this.groupBoxPesquisa.Name = "groupBoxPesquisa";
        	this.groupBoxPesquisa.Size = new System.Drawing.Size(760, 65);
        	this.groupBoxPesquisa.TabIndex = 1;
        	this.groupBoxPesquisa.TabStop = false;
        	this.groupBoxPesquisa.Text = " Pesquisar ";
        	// 
        	// btnMostrarTodos
        	// 
        	this.btnMostrarTodos.Location = new System.Drawing.Point(540, 25);
        	this.btnMostrarTodos.Name = "btnMostrarTodos";
        	this.btnMostrarTodos.Size = new System.Drawing.Size(120, 23);
        	this.btnMostrarTodos.TabIndex = 3;
        	this.btnMostrarTodos.Text = "Mostrar Todos";
        	this.btnMostrarTodos.UseVisualStyleBackColor = true;
        	this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodosClick);
        	// 
        	// btnPesquisar
        	// 
        	this.btnPesquisar.Location = new System.Drawing.Point(430, 25);
        	this.btnPesquisar.Name = "btnPesquisar";
        	this.btnPesquisar.Size = new System.Drawing.Size(100, 23);
        	this.btnPesquisar.TabIndex = 2;
        	this.btnPesquisar.Text = "Buscar";
        	this.btnPesquisar.UseVisualStyleBackColor = true;
        	this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisarClick);
        	// 
        	// txtPesquisa
        	// 
        	this.txtPesquisa.Location = new System.Drawing.Point(130, 27);
        	this.txtPesquisa.Name = "txtPesquisa";
        	this.txtPesquisa.Size = new System.Drawing.Size(280, 22);
        	this.txtPesquisa.TabIndex = 1;
        	// 
        	// lblPesquisa
        	// 
        	this.lblPesquisa.Location = new System.Drawing.Point(15, 30);
        	this.lblPesquisa.Name = "lblPesquisa";
        	this.lblPesquisa.Size = new System.Drawing.Size(110, 20);
        	this.lblPesquisa.TabIndex = 0;
        	this.lblPesquisa.Text = "Pesquisar por Nome:";
        	// 
        	// dgvClientes
        	// 
        	this.dgvClientes.AllowUserToAddRows = false;
        	this.dgvClientes.AllowUserToDeleteRows = false;
        	this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        	this.dgvClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
        	this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        	this.dgvClientes.Location = new System.Drawing.Point(12, 255);
        	this.dgvClientes.MultiSelect = false;
        	this.dgvClientes.Name = "dgvClientes";
        	this.dgvClientes.ReadOnly = true;
        	this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        	this.dgvClientes.Size = new System.Drawing.Size(760, 219);
        	this.dgvClientes.TabIndex = 2;
        	// 
        	// btnNovo
        	// 
        	this.btnNovo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnNovo.Location = new System.Drawing.Point(12, 500);
        	this.btnNovo.Name = "btnNovo";
        	this.btnNovo.Size = new System.Drawing.Size(100, 35);
        	this.btnNovo.TabIndex = 3;
        	this.btnNovo.Text = "Novo";
        	this.btnNovo.UseVisualStyleBackColor = true;
        	this.btnNovo.Click += new System.EventHandler(this.btnNovoClick);
        	// 
        	// btnSalvar
        	// 
        	this.btnSalvar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnSalvar.Location = new System.Drawing.Point(125, 500);
        	this.btnSalvar.Name = "btnSalvar";
        	this.btnSalvar.Size = new System.Drawing.Size(100, 35);
        	this.btnSalvar.TabIndex = 4;
        	this.btnSalvar.Text = "Salvar";
        	this.btnSalvar.UseVisualStyleBackColor = true;
        	this.btnSalvar.Click += new System.EventHandler(this.btnSalvarClick);
        	// 
        	// btnExcluir
        	// 
        	this.btnExcluir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnExcluir.Location = new System.Drawing.Point(238, 500);
        	this.btnExcluir.Name = "btnExcluir";
        	this.btnExcluir.Size = new System.Drawing.Size(100, 35);
        	this.btnExcluir.TabIndex = 5;
        	this.btnExcluir.Text = "Excluir";
        	this.btnExcluir.UseVisualStyleBackColor = true;
        	this.btnExcluir.Click += new System.EventHandler(this.btnExcluirClick);
        	// 
        	// btnAtivarDesativar
        	// 
        	this.btnAtivarDesativar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnAtivarDesativar.Location = new System.Drawing.Point(351, 500);
        	this.btnAtivarDesativar.Name = "btnAtivarDesativar";
        	this.btnAtivarDesativar.Size = new System.Drawing.Size(130, 35);
        	this.btnAtivarDesativar.TabIndex = 6;
        	this.btnAtivarDesativar.Text = "Ativar / Desativar";
        	this.btnAtivarDesativar.UseVisualStyleBackColor = true;
        	this.btnAtivarDesativar.Click += new System.EventHandler(this.btnAtivarDesativarClick);
        	// 
        	// btnCancelar
        	// 
        	this.btnCancelar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnCancelar.Location = new System.Drawing.Point(672, 500);
        	this.btnCancelar.Name = "btnCancelar";
        	this.btnCancelar.Size = new System.Drawing.Size(100, 35);
        	this.btnCancelar.TabIndex = 7;
        	this.btnCancelar.Text = "Cancelar";
        	this.btnCancelar.UseVisualStyleBackColor = true;
        	this.btnCancelar.Click += new System.EventHandler(this.btnCancelarClick);
        	// 
        	// FrmClientes
        	// 
        	this.ClientSize = new System.Drawing.Size(784, 551);
        	this.Controls.Add(this.btnCancelar);
        	this.Controls.Add(this.btnAtivarDesativar);
        	this.Controls.Add(this.btnExcluir);
        	this.Controls.Add(this.btnSalvar);
        	this.Controls.Add(this.btnNovo);
        	this.Controls.Add(this.dgvClientes);
        	this.Controls.Add(this.groupBoxPesquisa);
        	this.Controls.Add(this.groupBoxDados);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        	this.MaximizeBox = false;
        	this.Name = "FrmClientes";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "Cadastro de Clientes";
        	this.groupBoxDados.ResumeLayout(false);
        	this.groupBoxDados.PerformLayout();
        	this.groupBoxPesquisa.ResumeLayout(false);
        	this.groupBoxPesquisa.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
        	this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox groupBoxDados;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.GroupBox groupBoxPesquisa;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtivarDesativar;
        private System.Windows.Forms.Button btnCancelar;
    }
}