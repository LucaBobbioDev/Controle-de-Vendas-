using Projeto_Controle_Vendas.br.com.projeto.dao;
using Projeto_Controle_Vendas.br.com.projeto.model;
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
    public partial class Frmprodutos : Form
    {
        public Frmprodutos()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Frmprodutos_Load(object sender, EventArgs e)
        {
            //Instancinado Objeto da classe FornecedorDAO
            FornecedorDAO f_dao = new FornecedorDAO();

            cbfornecedor.DataSource = f_dao.listarFornecedores();
            cbfornecedor.DisplayMember = "nome";
            cbfornecedor.ValueMember = "id";

            ProdutoDAO dao = new ProdutoDAO();
            tabelaProdutos.DataSource = dao.listarProdutos();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto();

            obj.descricao = txtdescricao.Text;
            obj.preco = decimal.Parse(txtpreco.Text);
            obj.qtdEstoque = int.Parse(txtqtdestoque.Text);
            obj.for_id = int.Parse(cbfornecedor.SelectedValue.ToString());

            ProdutoDAO dao = new ProdutoDAO();

            dao.cadastrarProduto(obj);

            new Helpers().LimparTela(this);
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

        #region Evento de Click na celula da Tabela
        private void tabelaProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegando os dados de um produto selecionado
            txtcodigo.Text = tabelaProdutos.CurrentRow.Cells[0].Value.ToString();
            txtdescricao.Text = tabelaProdutos.CurrentRow.Cells[1].Value.ToString();
            txtpreco.Text = tabelaProdutos.CurrentRow.Cells[2].Value.ToString();
            txtqtdestoque.Text = tabelaProdutos.CurrentRow.Cells[3].Value.ToString();

            cbfornecedor.Text = tabelaProdutos.CurrentRow.Cells[4].Value.ToString();

            //Alterar para guia de dados pessoais
            tabProdutos.SelectedTab = tabPage1;
        }
        #endregion

        private void btneditar_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto();

            obj.descricao = txtdescricao.Text;
            obj.preco = decimal.Parse(txtpreco.Text);
            obj.qtdEstoque = int.Parse(txtqtdestoque.Text);
            obj.for_id = int.Parse(cbfornecedor.SelectedValue.ToString());

            ProdutoDAO dao = new ProdutoDAO();

            dao.alterarProduto(obj);

            new Helpers().LimparTela(this);

            //Recarregar o datagridview
            tabelaProdutos.DataSource = dao.listarProdutos();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto();

            obj.id = int.Parse(txtcodigo.Text);

            ProdutoDAO dao = new ProdutoDAO();
            dao.deletarProduto(obj);

            new Helpers().LimparTela(this);

        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txtpesquisa.Text + "%";
            ProdutoDAO dao = new ProdutoDAO();

            tabelaProdutos.DataSource = dao.listarProdutosNome(nome);
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtpesquisa.Text;

            ProdutoDAO dao = new ProdutoDAO();

            tabelaProdutos.DataSource = dao.buscarProdutosNome(nome);

            if(tabelaProdutos.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum Produto encontrado com esse nome");

                //Recarregar o datagridview
                tabelaProdutos.DataSource = dao.listarProdutos();
            }
        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
