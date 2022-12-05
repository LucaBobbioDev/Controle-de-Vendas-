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
    public class ProdutoDAO
    {
        private MySqlConnection conexao;
        public ProdutoDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Método para CadastrarProduto
        public void cadastrarProduto(Produto obj)
        {
            try
            {
                string sql = @"insert into tb_produtos (descricao, preco, qtd_estoque, for_id) values (@descricao, @preco, @qtd_estoque, @for_id)";

                MySqlCommand executeCmd = new MySqlCommand(sql, conexao);

                executeCmd.Parameters.AddWithValue("@descricao", obj.descricao);
                executeCmd.Parameters.AddWithValue("@preco", obj.preco);
                executeCmd.Parameters.AddWithValue("@qtd_estoque", obj.qtdEstoque);
                executeCmd.Parameters.AddWithValue("@for_id", obj.for_id);


                conexao.Open();
                executeCmd.ExecuteNonQuery();

                MessageBox.Show("Produto cadastrado com sucesso");
                conexao.Close();
            } catch(Exception error)
            {
                MessageBox.Show("Ocorreu o erro:" + error);
            }
        }
        #endregion

        #region Método para AlterarProduto
        public void alterarProduto(Produto obj)
        {
            try
            {
                string sql = @"update tb_produtos set descricao=@descricao, preco=@preco, qtd_estoque=@qtd_estoque, for_id=@for_id where id=@id";

                MySqlCommand executeCmd = new MySqlCommand(sql, conexao);

                executeCmd.Parameters.AddWithValue("@descricao", obj.descricao);
                executeCmd.Parameters.AddWithValue("@preco", obj.preco);
                executeCmd.Parameters.AddWithValue("@qtd_estoque", obj.qtdEstoque);
                executeCmd.Parameters.AddWithValue("@for_id", obj.for_id);

                executeCmd.Parameters.AddWithValue("@id", obj.id);

                conexao.Open();
                executeCmd.ExecuteNonQuery();

                MessageBox.Show("Produto alterado com sucesso!");
                conexao.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Ocorreu o erro:" + error);
            }
        }
        #endregion

        #region Método para DeletarProduto
        public void deletarProduto(Produto obj)
        {
            try
            {
                string sql = @"delete from tb_produtos where id=@id";

                MySqlCommand executeCmd = new MySqlCommand(sql, conexao);

                executeCmd.Parameters.AddWithValue("@id", obj.id);

                conexao.Open();
                executeCmd.ExecuteNonQuery();

                MessageBox.Show("Produto excluido com sucesso!");
                conexao.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Ocorreu o erro:" + error);
            }
        }
        #endregion

        #region Método para ListarProdutos
        public DataTable listarProdutos()
        {
            try
            {
                //1 passo - Criar o DataTable e o comando sql
                DataTable tabelaProduto = new DataTable();
                string sql = @"select
                                p.id as 'codigo',
                                p.descricao as 'Descrição',
                                p.preco as 'Preço',
                                p.qtd_estoque as 'Qtd Estoque',
	                            f.nome as 'Fornecedor' from tb_produtos as p
                           join tb_fornecedores as f on (p.for_id = f.id); ";

                //2 passo - Organizar o comando sql e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //3 passo - Criar o MySQLDataApter para preencher os dados no DataTable;
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaProduto);

                //Fechar a conexao
                conexao.Close();

                return tabelaProduto;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }

        }
        #endregion

        #region Método para ListarProdutosPorNome
        public DataTable listarProdutosNome(string nome)
        {
            try
            {
                //1 passo - Criar o DataTable e o comando sql
                DataTable tabelaProduto = new DataTable();
                string sql = @"select
                                p.id as 'codigo',
                                p.descricao as 'Descrição',
                                p.preco as 'Preço',
                                p.qtd_estoque as 'Qtd Estoque',
	                            f.nome as 'Fornecedor' from tb_produtos as p
                           join tb_fornecedores as f on (p.for_id = f.id) where p.descricao like @nome";

                //2 passo - Organizar o comando sql e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //3 passo - Criar o MySQLDataApter para preencher os dados no DataTable;
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaProduto);

                //Fechar a conexao
                conexao.Close();

                return tabelaProduto;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }

        }
        #endregion

        #region Método para BuscarProdutoPorNome
        public DataTable buscarProdutosNome(string nome)
        {
            try
            {
                //1 passo - Criar o DataTable e o comando sql
                DataTable tabelaProduto = new DataTable();
                string sql = @"select
                                p.id as 'codigo',
                                p.descricao as 'Descrição',
                                p.preco as 'Preço',
                                p.qtd_estoque as 'Qtd Estoque',
	                            f.nome as 'Fornecedor' from tb_produtos as p
                           join tb_fornecedores as f on (p.for_id = f.id) where p.descricao like @nome";

                //2 passo - Organizar o comando sql e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //3 passo - Criar o MySQLDataApter para preencher os dados no DataTable;
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaProduto);

                //Fechar a conexao
                conexao.Close();

                return tabelaProduto;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }

        }
        #endregion

        #region Método para retornar produto por código
        public Produto retornarProdutoPorCodigo(int id)
        {
            try
            {
                string sql = @"select * from tb_produtos where id = @id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", id);
                conexao.Open();

                MySqlDataReader rs = executacmd.ExecuteReader();

                if (rs.Read())
                {
                    Produto p = new Produto();
                    p.id = rs.GetInt32("id");
                    p.descricao = rs.GetString("descricao");
                    p.preco = rs.GetDecimal("preco");
                    conexao.Close();
                    return p;
                }
                else
                {
                    MessageBox.Show("Nenhum produto com esse código foi encontrado!");
                    conexao.Close();
                    return null;
                }
            } catch (Exception error)
            {
                MessageBox.Show("Ocorreu um erro:" + error);
                conexao.Close();
                return null;

            }
        }
        #endregion

        #region Método para dar Baixa de Estoque
        public void baixaEstoque(int idProduto, int qtdEstoque)
        {
            try
            {
                string sql = @"update tb_produtos set qtd_estoque=@qtd_estoque, where id=@id";

                MySqlCommand executeCmd = new MySqlCommand(sql, conexao);

                executeCmd.Parameters.AddWithValue("@qtd_estoque", qtdEstoque);
                executeCmd.Parameters.AddWithValue("@id", idProduto);

                conexao.Open();
                executeCmd.ExecuteNonQuery();

                conexao.Close();

            } catch(Exception error)
            {
                MessageBox.Show("Ocorreu o seguinte erro:" + error);
            }
        }
        #endregion

        #region Método que retorna o Estoque atual
        public int retornaEstoqueAtual( int idProduto) 
        {
            try
            {
                int qtdEstoque = 0;
                string sql = @"select qtd_estoque from tb_produtos where id=@id";

                MySqlCommand executeCmd = new MySqlCommand(sql, conexao);
                executeCmd.Parameters.AddWithValue("@id", idProduto);

                conexao.Open();

                MySqlDataReader rs = executeCmd.ExecuteReader();

                if (rs.Read())
                {
                    qtdEstoque = rs.GetInt32("qtd_estoque");
                    conexao.Close();
                }

                return qtdEstoque;
            }
            catch (Exception error)
            {
                MessageBox.Show("Ocorreu o seguinte erro:" + error);
                return 0;
            }
        }
        #endregion
    }
}
