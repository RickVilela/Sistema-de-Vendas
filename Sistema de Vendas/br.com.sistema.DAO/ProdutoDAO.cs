using MySql.Data.MySqlClient;
using Sistema_de_Vendas.br.com.sistema.CONEXAO;
using Sistema_de_Vendas.br.com.sistema.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Vendas.br.com.sistema.DAO
{
    public class ProdutoDAO
    {
        private MySqlConnection conexao;

        public ProdutoDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region CadastrarProduto
        //Metodo Cadastrar Produto

        public void cadastrarProduto(Produto obj)
        {
            try
            {
                //1 Passo - definir o cmd sql - Insert into
                string sql = @"insert into tb_produtos (descricao, preco, qtd_estoque, for_id)
                                values(@descricao, @preco, @qtd_estoque, @for_id)";

                //2 Passo - Organizar o cmd SQL
                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);

                executaCmd.Parameters.AddWithValue("@descricao", obj.descricao);
                executaCmd.Parameters.AddWithValue("@preco", obj.preco);
                executaCmd.Parameters.AddWithValue("@qtd_estoque", obj.qtdEstoque);
                executaCmd.Parameters.AddWithValue("@for_id", obj.for_id);

                //3 Passo - Abrir a Conexão e Executar o comando SQL

                conexao.Open();
                executaCmd.ExecuteNonQuery();

                MessageBox.Show("Produto Cadastrado com Sucesso!");

                //Fechar a conexao com o Banco
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Cadastrar: " + erro);
            }
        }

        #endregion

        #region Alterar Produtos
        public void alterarProduto(Produto obj)
        {
            try
            {
                //1 Passo - definir o cmd sql - Insert into
                string sql = @"update tb_produtos set descricao=@descricao, preco=@preco, qtd_estoque=@qtd_estoque, for_id=@for_id where id=@id";

                //2 Passo - Organizar o cmd SQL
                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);

                executaCmd.Parameters.AddWithValue("@descricao", obj.descricao);
                executaCmd.Parameters.AddWithValue("@preco", obj.preco);
                executaCmd.Parameters.AddWithValue("@qtd_estoque", obj.qtdEstoque);
                executaCmd.Parameters.AddWithValue("@for_id", obj.for_id);
                executaCmd.Parameters.AddWithValue("@id", obj.id);

                //3 Passo - Abrir a Conexão e Executar o comando SQL

                conexao.Open();
                executaCmd.ExecuteNonQuery();

                MessageBox.Show("Produto Alterado com Sucesso!");

                //Fechar a conexao com o Banco
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Alterar: " + erro);
            }
        }
        #endregion

        #region Excluir Produto
        public void excluirProduto(Produto obj)
        {
            try
            {
                //1 Passo - definir o cmd sql - Insert into
                string sql = @"delete from tb_produtos where id=@id";

                //2 Passo - Organizar o cmd SQL
                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);

                executaCmd.Parameters.AddWithValue("@id", obj.id);

                //3 Passo - Abrir a Conexão e Executar o comando SQL

                conexao.Open();
                executaCmd.ExecuteNonQuery();

                MessageBox.Show("Produto Excluído com Sucesso!");

                //Fechar a conexao com o Banco
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Excluir: " + erro);
            }
        }
        #endregion

        #region Listar Produtos
        public DataTable listarProdutos()
        {
            try
            {
                //1 Passo - Criar DataTable e o comanod MySql

                DataTable tabelaProdutos = new DataTable();
                string sql = "SELECT tb_produtos.id as 'Código', tb_produtos.descricao as 'Descrição', tb_produtos.preco as 'Preço',tb_produtos.qtd_estoque as 'Qtd Estoque', tb_fornecedores.nome as 'Fornecedor' FROM tb_produtos join tb_fornecedores on (tb_produtos.for_id = tb_fornecedores.id);";
    
                //2 Passo - Organizar o comando e executar

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
             
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //3 Passo - Criar o MySqlDataAdapter para preencher os dados no DataTable

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaProdutos);

                //Fechar a conexao com o Banco
                conexao.Close();

                return tabelaProdutos;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Realizar a Consulta" + erro);
                return null;
            }
        }

        #endregion

        #region Listar Produtos por Descricao
        public DataTable listarProdutosPorDescricao(string descricao)
        {
            try
            {
                //1 Passo - Criar DataTable e o comanod MySql

                DataTable tabelaProduto = new DataTable();
                string sql = "SELECT tb_produtos.id as 'Código', tb_produtos.descricao as 'Descrição', tb_produtos.preco as 'Preço',tb_produtos.qtd_estoque as 'Qtd Estoque', tb_fornecedores.nome as 'Fornecedor' FROM tb_produtos join tb_fornecedores on (tb_produtos.for_id = tb_fornecedores.id) where tb_produtos.descricao like @descricao;";

                //2 Passo - Organizar o comando e executar

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@descricao", descricao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //3 Passo - Criar o MySqlDataAdapter para preencher os dados no DataTable

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaProduto);

                //Fechar a conexao com o Banco
                conexao.Close();

                return tabelaProduto;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Realizar a Consulta" + erro);
                return null;
            }
        }
        #endregion

        #region Buscar Produtos Por Descricao

        public DataTable buscaProdutosPorDescricao(string descricao)
        {
            try
            {
                //1 Passo - Criar DataTable e o comanod MySql

                DataTable tabelaProduto = new DataTable();
                string sql = "SELECT tb_produtos.id as 'Código', tb_produtos.descricao as 'Descrição', tb_produtos.preco as 'Preço',tb_produtos.qtd_estoque as 'Qtd Estoque', tb_fornecedores.nome as 'Fornecedor' FROM tb_produtos join tb_fornecedores on (tb_produtos.for_id = tb_fornecedores.id) where tb_produtos.descricao = @descricao;";

                //2 Passo - Organizar o comando e executar

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@descricao", descricao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //3 Passo - Criar o MySqlDataAdapter para preencher os dados no DataTable

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaProduto);

                //Fechar a conexao com o Banco
                conexao.Close();

                return tabelaProduto;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Realizar a Consulta" + erro);
                return null;
            }
        }
        #endregion

        #region Metodo Retorna Produto por Codigo

        public Produto retornaProdutoPorCodigo(int id)
        {
            try
            {
                //1 passo - Criar Comando Mysql
                string sql = @"select * from tb_produtos where id=@id";

                //2 passo - Organizar e Executar o Comando
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", id);
                conexao.Open();

                //3 passo - Criar o Mysql DataReader
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
                    conexao.Close();

                    return null ;
                  
                }
              
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Realizar a Consulta" + erro);
                return null;
            }
        }

        #endregion

        #region Metodo Baixar Estoque

        public void baixaEstoque(int idProduto, int qtdEstoque)
        {
            try
            {
                //1 Passo - Criar comando Sql
                string sql = @"update tb_produtos set qtd_estoque=@qtd_estoque where id=@id";

                //2 Passo - Organizar o cmd SQL
                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);

                executaCmd.Parameters.AddWithValue("@qtd_estoque", qtdEstoque);
                executaCmd.Parameters.AddWithValue("@id", idProduto);

                //3 Passo - Abrir a Conexão e Executar o comando SQL

                conexao.Open();
                executaCmd.ExecuteNonQuery();

                //Fechar a conexao com o Banco
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
                conexao.Close();
            }
        }
        #endregion

        #region Retorna Estoque Atual
            
           public int retornaEstoqueAtual(int idProduto)
        {
            try
            {
                string sql = "select qtd_estoque from tb_produtos where id=@id";

                int qtdEstoque = 0;

                //2 Passo - Organizar o cmd SQL
                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);
                executaCmd.Parameters.AddWithValue("@id", idProduto);

                //3 Passo - Abrir a Conexão e Executar o comando SQL

                conexao.Open();

                MySqlDataReader rs = executaCmd.ExecuteReader();

                if (rs.Read())
                {
                    qtdEstoque = rs.GetInt32("qtd_estoque");

                    conexao.Close();
                }

                return qtdEstoque;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
                return 0;
            }
        }

        #endregion
    }
}
