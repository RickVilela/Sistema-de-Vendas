using MySql.Data.MySqlClient;
using Sistema_de_Vendas.br.com.sistema.CONEXAO;
using Sistema_de_Vendas.br.com.sistema.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Vendas.br.com.sistema.DAO
{
    public class ClienteDAO
    {
        private MySqlConnection conexao;

        public ClienteDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region CadastrarCliente
        //Metodo Cadastrar Cliente

        public void cadastrarCliente(Cliente obj)
        {
            try
            {
                //1 Passo - definir o cmd sql - Insert into
                string sql = @"insert into tb_clientes (nome, rg, cpf, email, telefone, celular,cep, endereco, numero, complemento, bairro, cidade, estado)
                                values(@nome, @rg, @cpf, @email, @telefone, @celular,@cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado)";

                //2 Passo - Organizar o cmd SQL
                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);

                executaCmd.Parameters.AddWithValue("@nome",obj.nome);
                executaCmd.Parameters.AddWithValue("@rg", obj.rg);
                executaCmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executaCmd.Parameters.AddWithValue("@email", obj.email);
                executaCmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executaCmd.Parameters.AddWithValue("@celular", obj.celular);
                executaCmd.Parameters.AddWithValue("@cep", obj.cep);
                executaCmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executaCmd.Parameters.AddWithValue("@numero", obj.numero);
                executaCmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executaCmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executaCmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executaCmd.Parameters.AddWithValue("@estado", obj.estado);

                //3 Passo - Abrir a Conexão e Executar o comando SQL

                conexao.Open();
                executaCmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Cadastrado com Sucesso!");

                //Fechar a conexao com o Banco
                conexao.Close();
            }
            catch (Exception erro)
            { 
                MessageBox.Show("Erro ao Cadastrar: " + erro);
            }
        }

        #endregion

        #region ListarCLientes

        public DataTable listarClientes()
        {
            try
            {
                //1 Passo - Criar DataTable e o comanod MySql

                DataTable tabelaCliente = new DataTable();
                string sql = "select * from tb_clientes";

                //2 Passo - Organizar o comando e executar

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //3 Passo - Criar o MySqlDataAdapter para preencher os dados no DataTable

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaCliente);

                //Fechar a conexao com o Banco
                conexao.Close();

                return tabelaCliente;          
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Realizar a Consulta" + erro);
                return null;    
            }
        }

        #endregion

        #region AlterarClientes
        public void alterarCliente(Cliente obj)
        {
            try
            {
                //1 Passo - definir o cmd sql - Insert into
                string sql = @"update tb_clientes set nome=@nome, rg=@rg, cpf=@cpf, email=@email, telefone=@telefone, celular=@celular, cep=@cep, 
                               endereco=@endereco, numero=@numero, complemento=@complemento, bairro=@bairro, cidade=@cidade, estado=@estado 
                                where id=@id";
                                

                //2 Passo - Organizar o cmd SQL
                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);

                executaCmd.Parameters.AddWithValue("@nome", obj.nome);
                executaCmd.Parameters.AddWithValue("@rg", obj.rg);
                executaCmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executaCmd.Parameters.AddWithValue("@email", obj.email);
                executaCmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executaCmd.Parameters.AddWithValue("@celular", obj.celular);
                executaCmd.Parameters.AddWithValue("@cep", obj.cep);
                executaCmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executaCmd.Parameters.AddWithValue("@numero", obj.numero);
                executaCmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executaCmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executaCmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executaCmd.Parameters.AddWithValue("@estado", obj.estado);
                executaCmd.Parameters.AddWithValue("@id", obj.codigo);

                //3 Passo - Abrir a Conexão e Executar o comando SQL

                conexao.Open();
                executaCmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Alterado com Sucesso!");

                //Fechar a conexao com o Banco
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Alterar: " + erro);
            }
        }


        #endregion


        #region ExcluirClientes

        public void excluirCliente(Cliente obj)
        {
            try
            {
                //1 Passo - definir o cmd sql - Insert into
                string sql = @"delete from tb_clientes where id=@id";


                //2 Passo - Organizar o cmd SQL
                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);

                executaCmd.Parameters.AddWithValue("@id", obj.codigo);

                //3 Passo - Abrir a Conexão e Executar o comando SQL

                conexao.Open();
                executaCmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Excluido com Sucesso!");

                //Fechar a conexao com o Banco
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Excluir: " + erro);
            }
        }
        #endregion

        #region BuscarClientePorNome

        public DataTable BuscarClientePorNome(string nome)
        {
            try
            {
                //1 Passo - Criar DataTable e o comanod MySql

                DataTable tabelaCliente = new DataTable();
                string sql = "select * from tb_clientes where nome=@nome";

                //2 Passo - Organizar o comando e executar

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                //3 Passo - Criar o MySqlDataAdapter para preencher os dados no DataTable

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaCliente);

                //Fechar a conexao com o Banco
                conexao.Close();

                return tabelaCliente;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Realizar a Consulta" + erro);
                return null;
            }
        }


        #endregion

        #region listarClientesPorNome

        public DataTable listarClientesPorNome(string nome)
        {
            try
            {
                //1 Passo - Criar DataTable e o comanod MySql

                DataTable tabelaCliente = new DataTable();
                string sql = "select * from tb_clientes where nome like @nome";

                //2 Passo - Organizar o comando e executar

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                //3 Passo - Criar o MySqlDataAdapter para preencher os dados no DataTable

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaCliente);

                //Fechar a conexao com o Banco
                conexao.Close();

                return tabelaCliente;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Realizar a Consulta" + erro);
                return null;
            }
        }


        #endregion





        //Metodo Buscar Clientes por CPF
    }
}
