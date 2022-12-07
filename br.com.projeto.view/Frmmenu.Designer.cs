namespace Projeto_Controle_Vendas.br.com.projeto.view
{
    partial class Frmmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmmenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroDeClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultaDeClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroDeFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultaDeFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroDeFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultaDeFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroDeProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultaDeProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNovaVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHistorico = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTrocarUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtdata = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txthora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtusuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuClientes,
            this.menuFuncionarios,
            this.menuFornecedores,
            this.menuProdutos,
            this.menuVendas,
            this.menuConfig});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuClientes
            // 
            this.menuClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroDeClientes,
            this.menuConsultaDeClientes});
            this.menuClientes.Image = global::Projeto_Controle_Vendas.Properties.Resources.clientes;
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(98, 25);
            this.menuClientes.Text = "Clientes";
            // 
            // menuCadastroDeClientes
            // 
            this.menuCadastroDeClientes.Name = "menuCadastroDeClientes";
            this.menuCadastroDeClientes.Size = new System.Drawing.Size(237, 26);
            this.menuCadastroDeClientes.Text = "Cadastro de Clientes";
            this.menuCadastroDeClientes.Click += new System.EventHandler(this.menuCadastroDeClientes_Click);
            // 
            // menuConsultaDeClientes
            // 
            this.menuConsultaDeClientes.Name = "menuConsultaDeClientes";
            this.menuConsultaDeClientes.Size = new System.Drawing.Size(237, 26);
            this.menuConsultaDeClientes.Text = "Consulta de Clientes";
            this.menuConsultaDeClientes.Click += new System.EventHandler(this.menuConsultaDeClientes_Click);
            // 
            // menuFuncionarios
            // 
            this.menuFuncionarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroDeFuncionarios,
            this.menuConsultaDeFuncionarios});
            this.menuFuncionarios.Image = global::Projeto_Controle_Vendas.Properties.Resources.funcionarios;
            this.menuFuncionarios.Name = "menuFuncionarios";
            this.menuFuncionarios.Size = new System.Drawing.Size(135, 25);
            this.menuFuncionarios.Text = "Funcionários";
            // 
            // menuCadastroDeFuncionarios
            // 
            this.menuCadastroDeFuncionarios.Name = "menuCadastroDeFuncionarios";
            this.menuCadastroDeFuncionarios.Size = new System.Drawing.Size(274, 26);
            this.menuCadastroDeFuncionarios.Text = "Cadastro de Funcionários";
            this.menuCadastroDeFuncionarios.Click += new System.EventHandler(this.menuCadastroDeFuncionarios_Click);
            // 
            // menuConsultaDeFuncionarios
            // 
            this.menuConsultaDeFuncionarios.Name = "menuConsultaDeFuncionarios";
            this.menuConsultaDeFuncionarios.Size = new System.Drawing.Size(274, 26);
            this.menuConsultaDeFuncionarios.Text = "Consulta de Funcionários";
            this.menuConsultaDeFuncionarios.Click += new System.EventHandler(this.menuConsultaDeFuncionarios_Click);
            // 
            // menuFornecedores
            // 
            this.menuFornecedores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroDeFornecedores,
            this.menuConsultaDeFornecedores});
            this.menuFornecedores.Image = global::Projeto_Controle_Vendas.Properties.Resources.fornecedores;
            this.menuFornecedores.Name = "menuFornecedores";
            this.menuFornecedores.Size = new System.Drawing.Size(141, 25);
            this.menuFornecedores.Text = "Fornecedores";
            // 
            // menuCadastroDeFornecedores
            // 
            this.menuCadastroDeFornecedores.Name = "menuCadastroDeFornecedores";
            this.menuCadastroDeFornecedores.Size = new System.Drawing.Size(280, 26);
            this.menuCadastroDeFornecedores.Text = "Cadastro de Fornecedores";
            this.menuCadastroDeFornecedores.Click += new System.EventHandler(this.menuCadastroDeFornecedores_Click);
            // 
            // menuConsultaDeFornecedores
            // 
            this.menuConsultaDeFornecedores.Name = "menuConsultaDeFornecedores";
            this.menuConsultaDeFornecedores.Size = new System.Drawing.Size(280, 26);
            this.menuConsultaDeFornecedores.Text = "Consulta de Fornecedores";
            this.menuConsultaDeFornecedores.Click += new System.EventHandler(this.menuConsultaDeFornecedores_Click);
            // 
            // menuProdutos
            // 
            this.menuProdutos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroDeProdutos,
            this.menuConsultaDeProdutos});
            this.menuProdutos.Image = global::Projeto_Controle_Vendas.Properties.Resources.produtos;
            this.menuProdutos.Name = "menuProdutos";
            this.menuProdutos.Size = new System.Drawing.Size(107, 25);
            this.menuProdutos.Text = "Produtos";
            // 
            // menuCadastroDeProdutos
            // 
            this.menuCadastroDeProdutos.Name = "menuCadastroDeProdutos";
            this.menuCadastroDeProdutos.Size = new System.Drawing.Size(246, 26);
            this.menuCadastroDeProdutos.Text = "Cadastro de Produtos";
            this.menuCadastroDeProdutos.Click += new System.EventHandler(this.menuCadastroDeProdutos_Click);
            // 
            // menuConsultaDeProdutos
            // 
            this.menuConsultaDeProdutos.Name = "menuConsultaDeProdutos";
            this.menuConsultaDeProdutos.Size = new System.Drawing.Size(246, 26);
            this.menuConsultaDeProdutos.Text = "Consulta de Produtos";
            this.menuConsultaDeProdutos.Click += new System.EventHandler(this.menuConsultaDeProdutos_Click);
            // 
            // menuVendas
            // 
            this.menuVendas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNovaVenda,
            this.menuHistorico});
            this.menuVendas.Image = global::Projeto_Controle_Vendas.Properties.Resources.vendas;
            this.menuVendas.Name = "menuVendas";
            this.menuVendas.Size = new System.Drawing.Size(94, 25);
            this.menuVendas.Text = "Vendas";
            // 
            // menuNovaVenda
            // 
            this.menuNovaVenda.Name = "menuNovaVenda";
            this.menuNovaVenda.Size = new System.Drawing.Size(180, 26);
            this.menuNovaVenda.Text = "Nova Venda";
            this.menuNovaVenda.Click += new System.EventHandler(this.menuNovaVenda_Click);
            // 
            // menuHistorico
            // 
            this.menuHistorico.Name = "menuHistorico";
            this.menuHistorico.Size = new System.Drawing.Size(180, 26);
            this.menuHistorico.Text = "Histórico";
            this.menuHistorico.Click += new System.EventHandler(this.menuHistorico_Click);
            // 
            // menuConfig
            // 
            this.menuConfig.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTrocarUsuarios,
            this.menuSair});
            this.menuConfig.Image = global::Projeto_Controle_Vendas.Properties.Resources.configuracao;
            this.menuConfig.Name = "menuConfig";
            this.menuConfig.Size = new System.Drawing.Size(148, 25);
            this.menuConfig.Text = "Configurações";
            // 
            // menuTrocarUsuarios
            // 
            this.menuTrocarUsuarios.Name = "menuTrocarUsuarios";
            this.menuTrocarUsuarios.Size = new System.Drawing.Size(198, 26);
            this.menuTrocarUsuarios.Text = "Trocar Usuários";
            this.menuTrocarUsuarios.Click += new System.EventHandler(this.trocarUsuáriosToolStripMenuItem_Click);
            // 
            // menuSair
            // 
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(198, 26);
            this.menuSair.Text = "Sair ";
            this.menuSair.Click += new System.EventHandler(this.menuSair_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.txtdata,
            this.toolStripStatusLabel3,
            this.txthora,
            this.toolStripStatusLabel5,
            this.txtusuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 423);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 27);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(95, 22);
            this.toolStripStatusLabel1.Text = "Data Atual:";
            // 
            // txtdata
            // 
            this.txtdata.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(106, 22);
            this.txtdata.Text = "05/12/2022";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(96, 22);
            this.toolStripStatusLabel3.Text = "Hora Atual:";
            // 
            // txthora
            // 
            this.txthora.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthora.Name = "txthora";
            this.txthora.Size = new System.Drawing.Size(55, 22);
            this.txthora.Text = "15:00";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(134, 22);
            this.toolStripStatusLabel5.Text = "Usuário Logado:";
            // 
            // txtusuario
            // 
            this.txtusuario.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(111, 22);
            this.txtusuario.Text = "Luca Bobbio";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Controle_Vendas.Properties.Resources.menu_fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frmmenu";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frmmenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroDeClientes;
        private System.Windows.Forms.ToolStripMenuItem menuConsultaDeClientes;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroDeFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem menuConsultaDeFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem menuFornecedores;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroDeFornecedores;
        private System.Windows.Forms.ToolStripMenuItem menuConsultaDeFornecedores;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroDeProdutos;
        private System.Windows.Forms.ToolStripMenuItem menuConsultaDeProdutos;
        private System.Windows.Forms.ToolStripMenuItem menuVendas;
        private System.Windows.Forms.ToolStripMenuItem menuNovaVenda;
        private System.Windows.Forms.ToolStripMenuItem menuHistorico;
        private System.Windows.Forms.ToolStripMenuItem menuConfig;
        private System.Windows.Forms.ToolStripMenuItem menuTrocarUsuarios;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel txtdata;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel txthora;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        public System.Windows.Forms.ToolStripMenuItem menuProdutos;
        public System.Windows.Forms.ToolStripStatusLabel txtusuario;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
        public System.Windows.Forms.ToolStripMenuItem menuClientes;
        public System.Windows.Forms.ToolStripMenuItem menuFuncionarios;
    }
}