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
    public class VendaDAO
    {
        private MySqlConnection conexao;
        public VendaDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Método para Cadastrar Venda
        public void CadastrarVenda(Venda obj)
        {
            try
            {
                string sql = @"insert into tb_vendas (cliente_id, data_venda, total_venda, observacoes) values (@(cliente_id, @data_venda, @total_venda, @obs)";

                MySqlCommand executeCmd = new MySqlCommand(sql, conexao);

                executeCmd.Parameters.AddWithValue("@cliente_id", obj.cliente_id);
                executeCmd.Parameters.AddWithValue("@data_venda", obj.data_venda);
                executeCmd.Parameters.AddWithValue("@total_venda", obj.total_venda);
                executeCmd.Parameters.AddWithValue("@obs", obj.obs);

                conexao.Open();
                executeCmd.ExecuteNonQuery();

                MessageBox.Show("Venda registrada com sucesso!");
                conexao.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show("Ocorreu o erro:" + error);
            }
        }
        #endregion

        #region Método que retorna ID da Venda
        public int retornaId()
        {
            try
            {
                int idvenda = 0;
                string sql = @"select max(id) from vendas";
                MySqlCommand executeCmd = new MySqlCommand(sql, conexao);

                conexao.Open();
                executeCmd.ExecuteNonQuery();

                MySqlDataReader rs = executeCmd.ExecuteReader();

                if (rs.Read())
                {
                    Venda obj = new Venda();
                    obj.id = rs.GetInt32("id");

                    idvenda = obj.id;   
                }

                return idvenda;

            } catch(Exception error)
            {
                MessageBox.Show("Ocorreu o seguinte erro:" + error);
                conexao.Close();
                return 0;
            }
        }
        #endregion

        #region Método que exibe histórico de vendas
        public DataTable listarVendasPorPeriodo(DateTime datainicio, DateTime datafim)
        {
            try
            {
                DataTable tabelaHistorico = new DataTable();

                string sql = @"select v.id as 'Código',
                                      v.data_venda as 'Data da Venda',
                                      c.nome as 'Cliente',
                                      v.total_venda as 'Total',
                                      v.observacoes as 'Obs'
                               from tb_vendas as v join tb_clientes as c on (v.cliente_id = c.id)

                               where v.data_venda between @datainicio and @datafim";

                MySqlCommand executeCmd = new MySqlCommand(sql, conexao);

                executeCmd.Parameters.AddWithValue("@datainicio", datainicio);
                executeCmd.Parameters.AddWithValue("@datafim", datafim);

                conexao.Open();
                executeCmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter();
                da.Fill(tabelaHistorico);

                conexao.Close();
                return tabelaHistorico;
            }
            catch (Exception error)
            {
                MessageBox.Show("Ocorreu o seguinte erro:" + error);
                return null;
            }
        }
        #endregion

        #region Método que lista todas as vendas
        public DataTable listarVendas()
        {
            try
            {
                DataTable tabelaHistorico = new DataTable();
                
                string sql = @"select v.id as 'Código',
                                      v.data_venda as 'Data da Venda',
                                      c.nome as 'Cliente',
                                      v.total_venda as 'Total',
                                      v.observacoes as 'Obs'
                               from tb_vendas as v join tb_clientes as c on (v.cliente_id = c.id";

                MySqlCommand executeCmd = new MySqlCommand(sql, conexao);

                conexao.Open();

                executeCmd.ExecuteNonQuery();
                
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.Fill(tabelaHistorico);

                conexao.Close();
                return tabelaHistorico;
            }
            catch (Exception error)
            {
                MessageBox.Show("Ocorreu o seguinte erro:" + error);
                throw;
            }
        }
        #endregion
    }
}
