namespace Sistema_de_Vendas.br.com.sistema.VIEWS
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultaClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultaFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultaFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultaProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVendaNova = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVendasHistorico = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTrocaUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.data = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtData = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuClientes,
            this.menuFuncionarios,
            this.menuFornecedores,
            this.menuProdutos,
            this.menuVendas,
            this.menuConfig});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(783, 85);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuClientes
            // 
            this.menuClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroClientes,
            this.menuConsultaClientes});
            this.menuClientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuClientes.Image = global::Sistema_de_Vendas.Properties.Resources.cliente;
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(102, 81);
            this.menuClientes.Text = "Clientes";
            // 
            // menuCadastroClientes
            // 
            this.menuCadastroClientes.Name = "menuCadastroClientes";
            this.menuCadastroClientes.Size = new System.Drawing.Size(180, 26);
            this.menuCadastroClientes.Text = "Cadastro";
            this.menuCadastroClientes.Click += new System.EventHandler(this.menuCadastroClientes_Click);
            // 
            // menuConsultaClientes
            // 
            this.menuConsultaClientes.Name = "menuConsultaClientes";
            this.menuConsultaClientes.Size = new System.Drawing.Size(180, 26);
            this.menuConsultaClientes.Text = "Consulta";
            this.menuConsultaClientes.Click += new System.EventHandler(this.menuConsultaClientes_Click);
            // 
            // menuFuncionarios
            // 
            this.menuFuncionarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroFuncionarios,
            this.menuConsultaFuncionarios});
            this.menuFuncionarios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuFuncionarios.Image = global::Sistema_de_Vendas.Properties.Resources.participantes;
            this.menuFuncionarios.Name = "menuFuncionarios";
            this.menuFuncionarios.Size = new System.Drawing.Size(136, 81);
            this.menuFuncionarios.Text = "Funcionarios";
            // 
            // menuCadastroFuncionarios
            // 
            this.menuCadastroFuncionarios.Name = "menuCadastroFuncionarios";
            this.menuCadastroFuncionarios.Size = new System.Drawing.Size(180, 26);
            this.menuCadastroFuncionarios.Text = "Cadastro";
            this.menuCadastroFuncionarios.Click += new System.EventHandler(this.menuCadastroFuncionarios_Click);
            // 
            // menuConsultaFuncionarios
            // 
            this.menuConsultaFuncionarios.Name = "menuConsultaFuncionarios";
            this.menuConsultaFuncionarios.Size = new System.Drawing.Size(180, 26);
            this.menuConsultaFuncionarios.Text = "Consulta";
            this.menuConsultaFuncionarios.Click += new System.EventHandler(this.menuConsultaFuncionarios_Click);
            // 
            // menuFornecedores
            // 
            this.menuFornecedores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroFornecedores,
            this.menuConsultaFornecedores});
            this.menuFornecedores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuFornecedores.Image = global::Sistema_de_Vendas.Properties.Resources.fornecedor;
            this.menuFornecedores.Name = "menuFornecedores";
            this.menuFornecedores.Size = new System.Drawing.Size(141, 81);
            this.menuFornecedores.Text = "Fornecedores";
            this.menuFornecedores.Click += new System.EventHandler(this.vendasToolStripMenuItem_Click);
            // 
            // menuCadastroFornecedores
            // 
            this.menuCadastroFornecedores.Name = "menuCadastroFornecedores";
            this.menuCadastroFornecedores.Size = new System.Drawing.Size(180, 26);
            this.menuCadastroFornecedores.Text = "Cadastro";
            this.menuCadastroFornecedores.Click += new System.EventHandler(this.menuCadastroFornecedores_Click);
            // 
            // menuConsultaFornecedores
            // 
            this.menuConsultaFornecedores.Name = "menuConsultaFornecedores";
            this.menuConsultaFornecedores.Size = new System.Drawing.Size(180, 26);
            this.menuConsultaFornecedores.Text = "Consulta";
            this.menuConsultaFornecedores.Click += new System.EventHandler(this.menuConsultaFornecedores_Click);
            // 
            // menuProdutos
            // 
            this.menuProdutos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroProdutos,
            this.menuConsultaProdutos});
            this.menuProdutos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuProdutos.Image = global::Sistema_de_Vendas.Properties.Resources.produtos_de_higiene;
            this.menuProdutos.Name = "menuProdutos";
            this.menuProdutos.Size = new System.Drawing.Size(110, 81);
            this.menuProdutos.Text = "Produtos";
            // 
            // menuCadastroProdutos
            // 
            this.menuCadastroProdutos.Name = "menuCadastroProdutos";
            this.menuCadastroProdutos.Size = new System.Drawing.Size(180, 26);
            this.menuCadastroProdutos.Text = "Cadastro";
            this.menuCadastroProdutos.Click += new System.EventHandler(this.menuCadastroProdutos_Click);
            // 
            // menuConsultaProdutos
            // 
            this.menuConsultaProdutos.Name = "menuConsultaProdutos";
            this.menuConsultaProdutos.Size = new System.Drawing.Size(180, 26);
            this.menuConsultaProdutos.Text = "Consulta";
            this.menuConsultaProdutos.Click += new System.EventHandler(this.menuConsultaProdutos_Click);
            // 
            // menuVendas
            // 
            this.menuVendas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuVendaNova,
            this.menuVendasHistorico});
            this.menuVendas.Image = global::Sistema_de_Vendas.Properties.Resources.forma_de_pagamento;
            this.menuVendas.Name = "menuVendas";
            this.menuVendas.Size = new System.Drawing.Size(97, 81);
            this.menuVendas.Text = "Vendas";
            // 
            // menuVendaNova
            // 
            this.menuVendaNova.Name = "menuVendaNova";
            this.menuVendaNova.Size = new System.Drawing.Size(217, 26);
            this.menuVendaNova.Text = "Nova venda";
            this.menuVendaNova.Click += new System.EventHandler(this.menuVendaNova_Click);
            // 
            // menuVendasHistorico
            // 
            this.menuVendasHistorico.Name = "menuVendasHistorico";
            this.menuVendasHistorico.Size = new System.Drawing.Size(217, 26);
            this.menuVendasHistorico.Text = "Histórico de Vendas";
            this.menuVendasHistorico.Click += new System.EventHandler(this.menuVendasHistorico_Click);
            // 
            // menuConfig
            // 
            this.menuConfig.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTrocaUsuario,
            this.menuSair});
            this.menuConfig.Image = global::Sistema_de_Vendas.Properties.Resources.configuracao;
            this.menuConfig.Name = "menuConfig";
            this.menuConfig.Size = new System.Drawing.Size(147, 81);
            this.menuConfig.Text = "Configurações";
            // 
            // menuTrocaUsuario
            // 
            this.menuTrocaUsuario.Name = "menuTrocaUsuario";
            this.menuTrocaUsuario.Size = new System.Drawing.Size(202, 26);
            this.menuTrocaUsuario.Text = "Trocar de Usuário";
            this.menuTrocaUsuario.Click += new System.EventHandler(this.menuTrocaUsuario_Click);
            // 
            // menuSair
            // 
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(202, 26);
            this.menuSair.Text = "Sair";
            this.menuSair.Click += new System.EventHandler(this.menuSair_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.data,
            this.txtData,
            this.toolStripStatusLabel5,
            this.txtHora,
            this.toolStripStatusLabel6,
            this.txtUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 425);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(783, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // data
            // 
            this.data.BackColor = System.Drawing.Color.White;
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(44, 20);
            this.data.Text = "Data:";
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.Color.White;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(85, 20);
            this.txtData.Text = "01/11/2022";
            this.txtData.Click += new System.EventHandler(this.txtData_Click);
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.BackColor = System.Drawing.Color.White;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(45, 20);
            this.toolStripStatusLabel5.Text = "Hora:";
            // 
            // txtHora
            // 
            this.txtHora.BackColor = System.Drawing.Color.White;
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(44, 20);
            this.txtHora.Text = "10:00";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.BackColor = System.Drawing.Color.White;
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(66, 20);
            this.toolStripStatusLabel6.Text = "Usuário: ";
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.White;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(111, 20);
            this.txtUser.Text = "Henrique Vilela";
            this.txtUser.Click += new System.EventHandler(this.txtUser_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::Sistema_de_Vendas.Properties.Resources.digital_increasing_bar_graph_with_businessman_hand_overlay;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(783, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuClientes;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroClientes;
        private System.Windows.Forms.ToolStripMenuItem menuConsultaClientes;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem menuConsultaFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroFornecedores;
        private System.Windows.Forms.ToolStripMenuItem menuConsultaFornecedores;
        private System.Windows.Forms.ToolStripMenuItem menuProdutos;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroProdutos;
        private System.Windows.Forms.ToolStripMenuItem menuConsultaProdutos;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel txtData;
        private System.Windows.Forms.ToolStripStatusLabel txtHora;
        private System.Windows.Forms.ToolStripStatusLabel data;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripMenuItem menuVendas;
        private System.Windows.Forms.ToolStripMenuItem menuVendaNova;
        private System.Windows.Forms.ToolStripMenuItem menuVendasHistorico;
        private System.Windows.Forms.ToolStripMenuItem menuConfig;
        private System.Windows.Forms.ToolStripMenuItem menuTrocaUsuario;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
        public System.Windows.Forms.ToolStripMenuItem menuFuncionarios;
        public System.Windows.Forms.ToolStripMenuItem menuFornecedores;
        public System.Windows.Forms.ToolStripStatusLabel txtUser;
        private System.Windows.Forms.Timer timer1;
    }
}