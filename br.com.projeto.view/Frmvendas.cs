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
    public partial class Frmvendas : Form
    {
        //Objetos Cliente
        Cliente cliente = new Cliente();
        ClienteDAO cdao = new ClienteDAO();

        //Objetos Produto
        Produto produto = new Produto();
        ProdutoDAO pdao = new ProdutoDAO();

        //Varíaveis
        int qtd;
        decimal preco;
        decimal subtotal, total;

        //Carrinho
        DataTable carrinho = new DataTable();


        public Frmvendas()
        {
            InitializeComponent();
        }

        #region Miss Click
        private void txtcpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion


        private void btnnovo_Click(object sender, EventArgs e)
        {
            try
            {
                qtd = int.Parse(txtqtdestoque.Text);
                preco = decimal.Parse(txtpreco.Text);

                subtotal = qtd * preco;

                total += subtotal;

                carrinho.Rows.Add(int.Parse(txtcodigo.Text), txtdescricao.Text, qtd, preco, subtotal);

                txttotal.Text = total.ToString();

                //Limpar Tela
                txtcodigo.Clear();
                txtdescricao.Clear();
                txtqtdestoque.Clear();
                txtpreco.Clear();

                txtcodigo.Focus();
            }
            catch (Exception error)
            { 
                MessageBox.Show(error.Message); 
            }
        }
    

        private void txtnome_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtcpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                cliente = cdao.retornaClientePorCpf(txtcpf.Text);

                if (cliente != null)
                {
                    txtnome.Text = cliente.nome;
                }
                else
                {
                    txtcpf.Clear();
                    txtcpf.Focus();
                }

            } 
            
        }

        private void Frmvendas_Load(object sender, EventArgs e)
        {
            txtdata.Text = DateTime.Now.ToShortDateString();


            carrinho.Columns.Add("Código", typeof(int));
            carrinho.Columns.Add("Produto", typeof(string));
            carrinho.Columns.Add("Qtd", typeof(int));
            carrinho.Columns.Add("Preço", typeof(decimal));
            carrinho.Columns.Add("Subtotal", typeof(decimal));

            tabelaProdutos.DataSource = carrinho;
        }

        private void tabelaProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            decimal subproduto = decimal.Parse(tabelaProdutos.CurrentRow.Cells[4].Value.ToString());
            int indice = tabelaProdutos.CurrentRow.Index;

            DataRow linha = carrinho.Rows[indice];

            carrinho.Rows.Remove(linha);
            carrinho.AcceptChanges();

            total -= subproduto;
            txttotal.Text = total.ToString();

            MessageBox.Show("Item Removido do carrinho!");
        }

        private void btnpagamento_Click(object sender, EventArgs e)
        {
            //Botão de Pagamento
            DateTime dataatual = DateTime.Parse(txtdata.Text);
            Frmpagamentos tela = new Frmpagamentos(cliente, carrinho, dataatual);

            tela.txttotal.Text = total.ToString();

            tela.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                produto = pdao.retornarProdutoPorCodigo(int.Parse(txtcodigo.Text));

                if (produto != null)
                {
                    txtdescricao.Text = produto.descricao;
                    txtpreco.Text = produto.preco.ToString();
                }
                else
                {
                    txtcodigo.Clear();
                    txtcodigo.Focus();
                }
            }
        }
    }
}
