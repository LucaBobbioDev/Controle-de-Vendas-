using MySql.Data.MySqlClient;
using Projeto_Controle_Vendas.br.com.projeto.conexao;
using Projeto_Controle_Vendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.br.com.projeto.dao
{
    public class ItemVendaDAO
    {
        private MySqlConnection conexao;
        public ItemVendaDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Método para cadastrar um item de venda
        public void cadastratItem(ItemVenda obj)
        {
            try 
            {
                string sql = @"insert into tb_itensvendas (venda_id, produto_id, qtd, subtotal) values (@venda_id, @produto_id, @qtd, @subtotal)";

                MySqlCommand executeCmd = new MySqlCommand(sql, conexao);

                executeCmd.Parameters.AddWithValue("@venda_id", obj.venda_id);
                executeCmd.Parameters.AddWithValue("@produto_id", obj.produto_id);
                executeCmd.Parameters.AddWithValue("@qtd", obj.qtd);
                executeCmd.Parameters.AddWithValue("@subtotal", obj.subtotal);

                conexao.Open();
                executeCmd.ExecuteNonQuery();

                MessageBox.Show("Item de Venda registrado com sucesso!");
                conexao.Close();
            } 
            catch (Exception error)
            { 
                MessageBox.Show("Ocorreu o seguinte erro:" + error); 
            }
        }
        #endregion

        #region Método que lista itens por venda
        public DataTable listarItensPorVenda(int venda_id)
        {
            try
            {
                DataTable tabelaItens = new DataTable();

                string sql = @"select i.id as 'Código',
                                      p.descricao as 'Descrição',
                                      i.qtd as 'Quantidade',
                                      p.preco as 'Preço',
                                      i.subtotal as 'Subtotal'
                               from tb_itensvendas as i join tb_produtos as p on (i.produto_id = p.id)

                               where venda_id = @venda_id";

                MySqlCommand executeCmd = new MySqlCommand(sql, conexao);

                executeCmd.Parameters.AddWithValue("@venda_id", venda_id);

                conexao.Open();
                executeCmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter();
                da.Fill(tabelaItens);

                conexao.Close();
                return tabelaItens;
            }
            catch (Exception error)
            {
                MessageBox.Show("Ocorreu o seguinte erro:" + error);
                return null;
            }
        }
        #endregion  
    }
}
