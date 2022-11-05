using Sistema_de_Vendas.br.com.sistema.DAO;
using Sistema_de_Vendas.br.com.sistema.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Sistema_de_Vendas.br.com.sistema.VIEWS
{
    public partial class FrmFuncionarios : Form
    {
        public FrmFuncionarios()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Botao Salvar
            Funcionario obj = new Funcionario();

            // Receber dados dos campos

            obj.nome = txtNome.Text;
            obj.bairro = txtBairro.Text;
            obj.rg = txtRg.Text;
            obj.cpf = txtRg.Text;
            obj.email = txtEmail.Text;
            obj.senha = txtSenha.Text;
            obj.nivelAcesso = cbAcesso.SelectedItem.ToString();
            obj.telefone = txtTel.Text;
            obj.celular = txtCel.Text;
            obj.cep = txtCep.Text;
            obj.cidade = txtCidade.Text;
            obj.numero = int.Parse(txtNumero.Text);
            obj.complemento = txtComp.Text;
            obj.endereco = txtEndereco.Text;
            obj.cargo = cbCargo.SelectedItem.ToString();
            obj.estado = cbUf.SelectedItem.ToString();

            //Criar Objeto FuncionarioDAO
            FuncionarioDAO dao = new FuncionarioDAO();
            dao.cadastrarFuncionario(obj);

            tabelaFuncionario.DataSource = dao.listarFuncionarios();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void FrmFuncionarios_Load(object sender, EventArgs e)
        {
            FuncionarioDAO dao = new FuncionarioDAO();
            tabelaFuncionario.DataSource = dao.listarFuncionarios();
        }

        private void tabelaFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabelaFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tabelaFuncionario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegar os dados da Linha Selecionada

            txtCodigo.Text = tabelaFuncionario.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = tabelaFuncionario.CurrentRow.Cells[1].Value.ToString();
            txtRg.Text = tabelaFuncionario.CurrentRow.Cells[2].Value.ToString();
            txtCpf.Text = tabelaFuncionario.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = tabelaFuncionario.CurrentRow.Cells[4].Value.ToString();
            txtSenha.Text = tabelaFuncionario.CurrentRow.Cells[5].Value.ToString();
            cbCargo.Text = tabelaFuncionario.CurrentRow.Cells[6].Value.ToString();
            cbAcesso.Text = tabelaFuncionario.CurrentRow.Cells[7].Value.ToString();
            txtTel.Text = tabelaFuncionario.CurrentRow.Cells[8].Value.ToString();
            txtCel.Text = tabelaFuncionario.CurrentRow.Cells[9].Value.ToString();
            txtCep.Text = tabelaFuncionario.CurrentRow.Cells[10].Value.ToString();
            txtEndereco.Text = tabelaFuncionario.CurrentRow.Cells[11].Value.ToString();
            txtNumero.Text = tabelaFuncionario.CurrentRow.Cells[12].Value.ToString();
            txtComp.Text = tabelaFuncionario.CurrentRow.Cells[13].Value.ToString();
            txtBairro.Text = tabelaFuncionario.CurrentRow.Cells[14].Value.ToString();
            txtCidade.Text = tabelaFuncionario.CurrentRow.Cells[15].Value.ToString();
            cbUf.Text = tabelaFuncionario.CurrentRow.Cells[16].Value.ToString();

            //Ir para a pagina de Cadastro com as informacões preenchidas

            tabFuncionarios.SelectedTab = tabPage1;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Funcionario obj = new Funcionario();

            obj.codigo = int.Parse(txtCodigo.Text);

            FuncionarioDAO dao = new FuncionarioDAO();
            dao.excluirFuncionario(obj);

            tabelaFuncionario.DataSource = dao.listarFuncionarios();

            new Helpers().LimparTela(this);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //Botao Alterar
            Funcionario obj = new Funcionario();

            // Receber dados dos campos

            obj.nome = txtNome.Text;
            obj.bairro = txtBairro.Text;
            obj.rg = txtRg.Text;
            obj.cpf = txtRg.Text;
            obj.email = txtEmail.Text;
            obj.senha = txtSenha.Text;
            obj.nivelAcesso = cbAcesso.SelectedItem.ToString();
            obj.telefone = txtTel.Text;
            obj.celular = txtCel.Text;
            obj.cep = txtCep.Text;
            obj.cidade = txtCidade.Text;
            obj.numero = int.Parse(txtNumero.Text);
            obj.complemento = txtComp.Text;
            obj.endereco = txtEndereco.Text;
            obj.cargo = cbCargo.SelectedItem.ToString();
            obj.estado = cbUf.SelectedItem.ToString();
            obj.codigo = int.Parse(txtCodigo.Text);

            //Criar Objeto FuncionarioDAO
            FuncionarioDAO dao = new FuncionarioDAO();
            dao.alterarFuncionario(obj);

            tabelaFuncionario.DataSource = dao.listarFuncionarios();
            new Helpers().LimparTela(this);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtPesquisa.Text;

            FuncionarioDAO dao = new FuncionarioDAO();

            tabelaFuncionario.DataSource = dao.buscaFuncionariosPorNome(nome);

            if(tabelaFuncionario.Rows.Count == 0 || txtPesquisa.Text == string.Empty)
            {
                MessageBox.Show("Funcionário não Encontrado!");
                tabelaFuncionario.DataSource = dao.listarFuncionarios();
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txtPesquisa.Text + "%";

            FuncionarioDAO dao = new FuncionarioDAO();
            tabelaFuncionario.DataSource = dao.listarFuncionariosPorNome(nome);
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            //Botao consultar cep 

            try
            {
                string cep = txtCep.Text;
                string xml = "https://viacep.com.br/ws/" + cep + "/xml/";

                DataSet dados = new DataSet();

                dados.ReadXml(xml);

                txtEndereco.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                txtBairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                txtCidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                txtComp.Text = dados.Tables[0].Rows[0]["complemento"].ToString();
                cbUf.Text = dados.Tables[0].Rows[0]["uf"].ToString();

            }
            catch (Exception)
            {

                MessageBox.Show("Endereço não encontrado, por favor digite manualmente");
            }
        }
    }
    }

