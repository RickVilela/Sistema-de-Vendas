using MySql.Data.MySqlClient;
using Sistema_de_Vendas.br.com.sistema.CONEXAO;
using Sistema_de_Vendas.br.com.sistema.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Vendas.br.com.sistema.DAO
{
    public class FuncionarioDAO
    {
        private MySqlConnection conexao;

        public FuncionarioDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region CadastrarFuncionario

        public void cadastrarFuncionario(Funcionario obj)
        {
            try
            {
                //1 Passo - Criar comando SQL

                string sql = @"insert into tb_funcionarios (nome, rg, cpf, email, senha, cargo, nivel_acesso, telefone, celular,cep, endereco, numero, complemento, bairro, cidade, estado)
                              values (@nome, @rg, @cpf, @email,@senha,@cargo,@nivel_acesso, @telefone, @celular,@cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado)";

                //2 Passo - Organizar e executar Comando

                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);

                executaCmd.Parameters.AddWithValue("@nome", obj.nome);
                executaCmd.Parameters.AddWithValue("@rg", obj.rg);
                executaCmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executaCmd.Parameters.AddWithValue("@email", obj.email);
                executaCmd.Parameters.AddWithValue("@senha", obj.senha);
                executaCmd.Parameters.AddWithValue("@cargo", obj.cargo);
                executaCmd.Parameters.AddWithValue("@nivel_acesso", obj.nivelAcesso);
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

                MessageBox.Show("Funcionário Cadastrado com Sucesso!");

                //Fechar a conexao com o Banco
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao Cadastrar Funcionario: " + erro);
            }
        }

        #endregion

        #region Alterar Funcionario

        public void alterarFuncionario(Funcionario obj)
        {
            try
            {
                //1 Passo - Criar comando SQL

                string sql = @"update tb_funcionarios set nome=@nome, rg=@rg, cpf=@cpf, email=@email, senha=@senha, cargo=@cargo, nivel_acesso=@nivel_acesso, telefone=@telefone, celular=@celular,cep=@cep, endereco=@endereco, numero=@numero, complemento=@complemento, bairro=@bairro, cidade=@cidade, estado=@estado
                               where id=@id";

                //2 Passo - Organizar e executar Comando

                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);

                executaCmd.Parameters.AddWithValue("@nome", obj.nome);
                executaCmd.Parameters.AddWithValue("@rg", obj.rg);
                executaCmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executaCmd.Parameters.AddWithValue("@email", obj.email);
                executaCmd.Parameters.AddWithValue("@senha", obj.senha);
                executaCmd.Parameters.AddWithValue("@cargo", obj.cargo);
                executaCmd.Parameters.AddWithValue("@nivel_acesso", obj.nivelAcesso);
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

                MessageBox.Show("Funcionário Alterado com Sucesso!");

                //Fechar a conexao com o Banco
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao Alrerar Funcionario: " + erro);
            }
        }

        #endregion

        #region Excluir Funcionario

        public void excluirFuncionario(Funcionario obj)
        {
            try
            {
                //1 Passo - Criar comando SQL

                string sql = @"delete from tb_funcionarios where id=@id";

                //2 Passo - Organizar e executar Comando

                MySqlCommand executaCmd = new MySqlCommand(sql, conexao);

                executaCmd.Parameters.AddWithValue("@id", obj.codigo);

                //3 Passo - Abrir a Conexão e Executar o comando SQL

                conexao.Open();
                executaCmd.ExecuteNonQuery();

                MessageBox.Show("Funcionário Excluído com Sucesso!");

                //Fechar a conexao com o Banco
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao Excluir Funcionario: " + erro);
            }
        }

        #endregion

        #region Listar Funcionario

        public DataTable listarFuncionarios()
        {
            try
            {
                //1 Passo - Criar DataTable e o comanod MySql

                DataTable tabelaFuncionario = new DataTable();
                string sql = "select * from tb_funcionarios";

                //2 Passo - Organizar o comando e executar

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //3 Passo - Criar o MySqlDataAdapter para preencher os dados no DataTable

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaFuncionario);

                //Fechar a conexao com o Banco
                conexao.Close();

                return tabelaFuncionario;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Realizar a Consulta" + erro);
                return null;
            }
        }


        #endregion

        #region BuscarFuncionarios Por Nome

        public DataTable buscaFuncionariosPorNome(string nome)
        {
            try
            {
                //1 Passo - Criar DataTable e o comanod MySql

                DataTable tabelaFuncionario = new DataTable();
                string sql = "select * from tb_funcionarios where nome = @nome";

                //2 Passo - Organizar o comando e executar

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //3 Passo - Criar o MySqlDataAdapter para preencher os dados no DataTable

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaFuncionario);

                //Fechar a conexao com o Banco
                conexao.Close();

                return tabelaFuncionario;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Realizar a Consulta" + erro);
                return null;
            }
        }
        #endregion

        #region Lista Funcionarios Por nome

        public DataTable listarFuncionariosPorNome(string nome)
        {
            try
            {
                //1 Passo - Criar DataTable e o comanod MySql

                DataTable tabelaFuncionario = new DataTable();
                string sql = "select * from tb_funcionarios where nome like @nome";

                //2 Passo - Organizar o comando e executar

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //3 Passo - Criar o MySqlDataAdapter para preencher os dados no DataTable

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaFuncionario);

                //Fechar a conexao com o Banco
                conexao.Close();

                return tabelaFuncionario;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Realizar a Consulta" + erro);
                return null;
            }
        }
    

        #endregion
    }

}
