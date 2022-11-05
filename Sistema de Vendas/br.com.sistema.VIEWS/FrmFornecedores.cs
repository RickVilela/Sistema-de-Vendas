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

namespace Sistema_de_Vendas.br.com.sistema.VIEWS
{
    public partial class FrmFornecedores : Form
    {
        public FrmFornecedores()
        {
            InitializeComponent();
        }

        private void FrmForncedores_Load(object sender, EventArgs e)
        {
            //Listar todos os Fornecedores

            FornecedorDAO dao = new FornecedorDAO();

            tabelaFornecedores.DataSource = dao.listarFornecedores();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
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

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Fornecedor obj = new Fornecedor();

            //1 Passo - Receber os dados dentro do Objeto modelo de Fornecedor

            obj.nome = txtNome.Text;
            obj.cnpj = txtCnpj.Text;          
            obj.email = txtEmail.Text;
            obj.telefone = txtTel.Text;
            obj.celular = txtCel.Text;
            obj.endereco = txtEndereco.Text;
            obj.numero = int.Parse(txtNumero.Text);
            obj.bairro = txtBairro.Text;
            obj.cidade = txtCidade.Text;
            obj.estado = cbUf.Text;
            obj.cep = txtCep.Text;
            obj.complemento = txtComp.Text;

            //2 Passo - Criar Objeto da Classe Fornecedor DAO e chamar Metodo Cadastrar

            FornecedorDAO dao = new FornecedorDAO();
            dao.cadastrarFornecedor(obj);

            //Recarregar o DataGridView
            tabelaFornecedores.DataSource = dao.listarFornecedores();

            new Helpers().LimparTela(this);

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //1 Passo - Receber os dados dentro do Objeto modelo de Fornecedor
            Fornecedor obj = new Fornecedor();

            obj.nome = txtNome.Text;
            obj.cnpj = txtCnpj.Text;
            obj.email = txtEmail.Text;
            obj.telefone = txtTel.Text;
            obj.celular = txtCel.Text;
            obj.endereco = txtEndereco.Text;
            obj.numero = int.Parse(txtNumero.Text);
            obj.bairro = txtBairro.Text;
            obj.cidade = txtCidade.Text;
            obj.estado = cbUf.Text;
            obj.cep = txtCep.Text;
            obj.complemento = txtComp.Text;

            obj.codigo = int.Parse(txtCodigo.Text);

            //2 Passo - Criar Objeto da Classe Fornecedor DAO e chamar Metodo Alterar

            FornecedorDAO dao = new FornecedorDAO();
            dao.alterarFornecedor(obj);

            //Recarregar o DataGridView
            tabelaFornecedores.DataSource = dao.listarFornecedores();
        }

        private void txtComp_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Botao Excluir
            Fornecedor obj = new Fornecedor();

            //Pegar o codigo

            obj.codigo = int.Parse(txtCodigo.Text);

            FornecedorDAO dao = new FornecedorDAO();

            dao.excluirFornecedor(obj);

            //Recarregar o DataGridView
            tabelaFornecedores.DataSource = dao.listarFornecedores();

            new Helpers().LimparTela(this);
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtPesquisa.Text + "%";

            FornecedorDAO dao = new FornecedorDAO();

            tabelaFornecedores.DataSource = dao.listarFornecedoresPorNome(nome);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtPesquisa.Text;

            FornecedorDAO dao = new FornecedorDAO();

            tabelaFornecedores.DataSource = dao.BuscarFornecedorPorNome(nome);

            if (tabelaFornecedores.Rows.Count == 0)
            {
                //Recarregar o DataGridView
                tabelaFornecedores.DataSource = dao.listarFornecedores();
            }
        }

        private void tabelaFornecedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegar os dados da Linha Selecionada

            txtCodigo.Text = tabelaFornecedores.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = tabelaFornecedores.CurrentRow.Cells[1].Value.ToString();
            txtCnpj.Text = tabelaFornecedores.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = tabelaFornecedores.CurrentRow.Cells[3].Value.ToString();
            txtTel.Text = tabelaFornecedores.CurrentRow.Cells[4].Value.ToString();
            txtCel.Text = tabelaFornecedores.CurrentRow.Cells[5].Value.ToString();
            txtCep.Text = tabelaFornecedores.CurrentRow.Cells[6].Value.ToString();
            txtEndereco.Text = tabelaFornecedores.CurrentRow.Cells[7].Value.ToString();
            txtNumero.Text = tabelaFornecedores.CurrentRow.Cells[8].Value.ToString();
            txtComp.Text = tabelaFornecedores.CurrentRow.Cells[9].Value.ToString();
            txtBairro.Text = tabelaFornecedores.CurrentRow.Cells[10].Value.ToString();
            txtCidade.Text = tabelaFornecedores.CurrentRow.Cells[11].Value.ToString();
            cbUf.Text = tabelaFornecedores.CurrentRow.Cells[12].Value.ToString();

            tabFornecedores.SelectedTab = tabPage1;
        }
    }
}
