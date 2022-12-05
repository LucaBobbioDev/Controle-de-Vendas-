using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.br.com.projeto.view
{
    public partial class Frmmenu : Form
    {
        public Frmmenu()
        {
            InitializeComponent();
        }

        private void trocarUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Frmmenu_Load(object sender, EventArgs e)
        {
            txtdata.Text = DateTime.Now.ToShortDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txthora.Text = DateTime.Now.ToShortTimeString();
        }

        private void menuCadastroDeClientes_Click(object sender, EventArgs e)
        {
            Frmclientes telaClientes = new Frmclientes();
            telaClientes.Show();
        }

        private void menuConsultaDeClientes_Click(object sender, EventArgs e)
        {
            Frmclientes telaClientes = new Frmclientes();
            telaClientes.tabClientes.SelectedTab = telaClientes.tabPage2;
            telaClientes.Show();
        }

        private void menuCadastroDeFuncionarios_Click(object sender, EventArgs e)
        {
            Frmfuncionarios telaFuncionarios = new Frmfuncionarios();
            telaFuncionarios.Show();
        }

        private void menuConsultaDeFuncionarios_Click(object sender, EventArgs e)
        {
            Frmfuncionarios telaFuncionarios = new Frmfuncionarios();
            telaFuncionarios.tabFuncionario.SelectedTab = telaFuncionarios.tabPage2;
            telaFuncionarios.Show();
        }

        private void menuCadastroDeFornecedores_Click(object sender, EventArgs e)
        {
            Frmfornecedores telaFornecedores = new Frmfornecedores();
            telaFornecedores.Show();
        }

        private void menuConsultaDeFornecedores_Click(object sender, EventArgs e)
        {
            Frmfornecedores telaFornecedores = new Frmfornecedores();
            telaFornecedores.tabFornecedor.SelectedTab = telaFornecedores.tabPage2;
            telaFornecedores.Show();
        }

        private void menuCadastroDeProdutos_Click(object sender, EventArgs e)
        {
            Frmprodutos telaProdutos = new Frmprodutos();
            telaProdutos.Show();
        }

        private void menuConsultaDeProdutos_Click(object sender, EventArgs e)
        {
            Frmprodutos telaProdutos = new Frmprodutos();
            telaProdutos.tabProdutos.SelectedTab = telaProdutos.tabPage2;
            telaProdutos.Show();
        }

        private void menuNovaVenda_Click(object sender, EventArgs e)
        {
            Frmvendas telaVendas = new Frmvendas();
            telaVendas.Show();
        }

        private void menuHistorico_Click(object sender, EventArgs e)
        {
            Frmhistorico telaHistorico = new Frmhistorico();
            telaHistorico.Show();
        }

        private void menuSair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show( "Você realmente deseja sair?", "ATENÇÃO!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
