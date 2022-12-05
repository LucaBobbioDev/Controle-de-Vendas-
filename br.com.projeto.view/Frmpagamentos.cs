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
    public partial class Frmpagamentos : Form
    {
        Cliente cliente = new Cliente();
        DataTable carrinho = new DataTable();
        DateTime dataatual = new DateTime();

        public Frmpagamentos(Cliente cliente, DataTable carrinho, DateTime dataatual)
        {
            this.cliente = cliente;
            this.carrinho = carrinho; 
            this.dataatual = dataatual;


            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Frmpagamentos_Load(object sender, EventArgs e)
        {
            txttroco.Text = "0,00";
            txtdinheiro.Text = "0,00";
            txtcartao.Text = "0,00";
        }

        private void btnfinalizar_Click(object sender, EventArgs e)
        {
            //Botão Finalizar
            try
            {
                decimal v_dinheiro, v_cartao, troco, total, totalpago;
                int qtd_estoque, qtd_comprada, estoque_atualizado;

                ProdutoDAO produtoDAO = new ProdutoDAO();

                v_dinheiro =  decimal.Parse(txtdinheiro.Text);
                v_cartao = decimal.Parse(txtcartao.Text);
                total = decimal.Parse(txttotal.Text);

                //Calculo Total Pago
                totalpago = v_dinheiro + v_cartao;


                if (totalpago < total)
                {
                    MessageBox.Show("O total pago é menor que o valor total da venda");
                }
                else
                {
                    //Calculo Troco
                    troco = totalpago - total;

                    Venda vendas = new Venda();

                    vendas.cliente_id = cliente.codigo;
                    vendas.data_venda = dataatual;
                    vendas.total_venda = total;
                    vendas.obs = txtobs.Text;

                    VendaDAO vdao = new VendaDAO();

                    txttroco.Text = troco.ToString();

                    vdao.CadastrarVenda(vendas);

                    

                    //Cadastrar os Itens da Venda
                    foreach (DataRow linha in carrinho.Rows)
                    {
                        ItemVenda itemVenda = new ItemVenda();


                        itemVenda.venda_id = vdao.retornaId();
                        itemVenda.produto_id = int.Parse(linha["Código"].ToString());
                        itemVenda.qtd = int.Parse(linha["Qtd"].ToString());
                        itemVenda.subtotal = decimal.Parse(linha["Subtotal"].ToString());

                        //Baixa em Estoque
                        qtd_estoque = produtoDAO.retornaEstoqueAtual(itemVenda.produto_id);
                        qtd_comprada = itemVenda.qtd;

                        estoque_atualizado = qtd_estoque - qtd_comprada;

                        produtoDAO.baixaEstoque(itemVenda.produto_id, estoque_atualizado);


                       ItemVendaDAO itemVendaDAO = new ItemVendaDAO();

                        itemVendaDAO.cadastratItem(itemVenda);
                    }

                    MessageBox.Show("Venda finalizada com sucesso!");


                    this.Dispose();
                }
               

            } catch(Exception error)
            {
                MessageBox.Show("Ocorreu o seguinte erro:" + error);
            }
        }
    }
}
