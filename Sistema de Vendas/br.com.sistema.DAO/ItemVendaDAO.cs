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
    public class ItemVendaDAO
    {
        private MySqlConnection conexao;

        public ItemVendaDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Cadastrar Item de Venda

        public void cadastrarItem(ItemVenda obj)
        {
            try
            {
                //1 Passo - definir o cmd sql - Insert into
                string sql = @"insert into tb_itensvendas (venda_id, produto_id, qtd , subtotal)
                                values (@venda_id, @produto_id, @qtd , @subtotal)";

                //2 Passo - Organizar o cmd SQL
                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);

                executaCmd.Parameters.AddWithValue("@venda_id", obj.vendaId);
                executaCmd.Parameters.AddWithValue("@produto_id", obj.produtoId);
                executaCmd.Parameters.AddWithValue("@qtd", obj.qtd);
                executaCmd.Parameters.AddWithValue("@subtotal", obj.subTotal);

                //3 Passo - Abrir a Conexão e Executar o comando SQL

                conexao.Open();
                executaCmd.ExecuteNonQuery();

                //Fechar a conexao com o Banco
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o Erro:" + erro);
            }
        }

        #endregion

        #region Listar Itens Por venda

        public DataTable listarItensPorVenda(int vendaId)
        {
            try
            {
                //1 Passo - Criar o DataTable e o comando MySql
                DataTable tabelaItens = new DataTable();

                string sql = @"SELECT i.id as 'Código',
	                           p.descricao as 'Descrição',
                               i.qtd as 'Quantidade',
                               p.preco as 'Preço',
                               i.subtotal as 'SubTotal'
                               from tb_itensvendas as i join tb_produtos as p on (i.produto_id = p.id) where venda_id =@vendaId";

                //2 Passo - Organizar e executar o comando Mysql

                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);

                executaCmd.Parameters.AddWithValue("@vendaId", vendaId);
               

                conexao.Open();
                executaCmd.ExecuteNonQuery();

                //3 Passo - Criar o MySql DataAdapter para preencher os dados do DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executaCmd);
                da.Fill(tabelaItens);

                return tabelaItens;

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
