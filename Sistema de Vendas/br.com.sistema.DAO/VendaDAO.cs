using MySql.Data.MySqlClient;
using Sistema_de_Vendas.br.com.sistema.CONEXAO;
using Sistema_de_Vendas.br.com.sistema.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Vendas.br.com.sistema.DAO
{
    public class VendaDAO
    {
        private MySqlConnection conexao;

        public VendaDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Metodo Cadastrar Venda

        public void cadastrarVenda(Venda obj)
        {
            try
            {
                //1 Passo - definir o cmd sql - Insert into
                string sql = @"insert into tb_vendas (cliente_id, data_venda, total_venda, observacoes)
                               values(@cliente_id, @data_venda, @total_venda, @obs)";

                //2 Passo - Organizar o cmd SQL
                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);

                executaCmd.Parameters.AddWithValue("@cliente_id", obj.clienteId);
                executaCmd.Parameters.AddWithValue("@data_venda", obj.dataVenda);
                executaCmd.Parameters.AddWithValue("@total_venda", obj.totalVenda);
                executaCmd.Parameters.AddWithValue("@obs", obj.obs);

                //3 Passo - Abrir a Conexão e Executar o comando SQL

                conexao.Open();
                executaCmd.ExecuteNonQuery();

                //Fechar a conexao com o Banco
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao Realizar Venda: " + erro);
            }
        }

        #endregion

        #region Retornar Ultima Venda

        public int retornaIdUltimaVenda()
        {
            try
            {
                int idVenda = 0;

                //1 Passo - definir o cmd sql - Insert into
                string sql = @"select max(id) id from tb_vendas";

                //2 Passo - Organizar o cmd SQL
                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);

                //3 Passo - Abrir a Conexão e Executar o comando SQL
                conexao.Open();

                MySqlDataReader rs = executaCmd.ExecuteReader();

                if (rs.Read())
                {
                    idVenda = rs.GetInt32("id");                              
                }

                //Fechar a conexao com o Banco
                conexao.Close();

                return idVenda;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
                conexao.Close();
                return 0;
            }
        }

        #endregion

        #region Exibe Historico de Venda

        public DataTable listarVendasPorPeriodo(DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                //1 Passo - Criar o DataTable e o comando MySql
                DataTable tabelaHistorico = new DataTable();

                string sql = @"SELECT v.id as 'Código',
		                    v.data_venda as 'Data da Venda',
                            c.nome as 'Cliente',
                            v.total_venda as 'Total',
                            v.observacoes as 'Observações'
	                        FROM tb_vendas as v join tb_clientes as c on (v.cliente_id = c.id) 
                            where v.data_venda between @dataInicio and @dataFim";

                //2 Passo - Organizar e executar o comando Mysql

                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);

                executaCmd.Parameters.AddWithValue("@dataInicio", dataInicio);
                executaCmd.Parameters.AddWithValue("@dataFim", dataFim);
    
                conexao.Open();
                executaCmd.ExecuteNonQuery();

                //3 Passo - Criar o MySql DataAdapter para preencher os dados do DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executaCmd);
                da.Fill(tabelaHistorico);

                return tabelaHistorico;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Realizar Consulta: " + erro);
                return null;
            }
        }
        #endregion

        #region Exibe Historico de Venda

        public DataTable listarVendas()
        {
            try
            {
                //1 Passo - Criar o DataTable e o comando MySql
                DataTable tabelaHistorico = new DataTable();

                string sql = @"SELECT v.id as 'Código',
		                    v.data_venda as 'Data da Venda',
                            c.nome as 'Cliente',
                            v.total_venda as 'Total',
                            v.observacoes as 'Observações'
	                        FROM tb_vendas as v join tb_clientes as c on (v.cliente_id = c.id)";

                //2 Passo - Organizar e executar o comando Mysql

                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);


                conexao.Open();
                executaCmd.ExecuteNonQuery();

                //3 Passo - Criar o MySql DataAdapter para preencher os dados do DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executaCmd);
                da.Fill(tabelaHistorico);

                return tabelaHistorico;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Realizar Consulta: " + erro);
                return null;
            }
        }
        #endregion
    
    }
}
