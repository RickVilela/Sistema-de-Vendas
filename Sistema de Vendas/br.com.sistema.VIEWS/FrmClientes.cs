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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //1 Passo - Receber os dados dentro do Objeto modelo de Cliente
            Cliente obj = new Cliente();

            obj.nome = txtNome.Text;
            obj.rg = txtRg.Text;
            obj.cpf = txtCpf.Text;
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

            //2 Passo - Criar Objeto da Classe Cliente DAO e chamar Metodo Cadastrar

            ClienteDAO dao = new ClienteDAO();
            dao.cadastrarCliente(obj);

            //Recarregar o DataGridView
            tabelaCliente.DataSource = dao.listarClientes();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            tabelaCliente.DefaultCellStyle.ForeColor = Color.Black;

            ClienteDAO dao = new ClienteDAO();
            tabelaCliente.DataSource = dao.listarClientes();
        }

        private void tabelaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabelaCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegar os dados da Linha Selecionada

            txtCodigo.Text = tabelaCliente.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = tabelaCliente.CurrentRow.Cells[1].Value.ToString();
            txtRg.Text = tabelaCliente.CurrentRow.Cells[2].Value.ToString();
            txtCpf.Text = tabelaCliente.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = tabelaCliente.CurrentRow.Cells[4].Value.ToString();
            txtTel.Text = tabelaCliente.CurrentRow.Cells[5].Value.ToString();
            txtCel.Text = tabelaCliente.CurrentRow.Cells[6].Value.ToString();
            txtCep.Text = tabelaCliente.CurrentRow.Cells[7].Value.ToString();
            txtEndereco.Text = tabelaCliente.CurrentRow.Cells[8].Value.ToString();
            txtNumero.Text = tabelaCliente.CurrentRow.Cells[9].Value.ToString();
            txtComp.Text = tabelaCliente.CurrentRow.Cells[10].Value.ToString();
            txtBairro.Text = tabelaCliente.CurrentRow.Cells[11].Value.ToString();   
            txtCidade.Text = tabelaCliente.CurrentRow.Cells[12].Value.ToString();
            cbUf.Text = tabelaCliente.CurrentRow.Cells[13].Value.ToString();
            
        }

        private void tabelaCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tabClientes.SelectedTab = tabPage1;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Botao Excluir
            Cliente obj = new Cliente();

            //Pegar o codigo

            obj.codigo = int.Parse(txtCodigo.Text);

            ClienteDAO dao = new ClienteDAO();

            dao.excluirCliente(obj);

            //Recarregar o DataGridView
            tabelaCliente.DataSource = dao.listarClientes();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //1 Passo - Receber os dados dentro do Objeto modelo de Cliente
            Cliente obj = new Cliente();

            obj.nome = txtNome.Text;
            obj.rg = txtRg.Text;
            obj.cpf = txtCpf.Text;
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

            //2 Passo - Criar Objeto da Classe Cliente DAO e chamar Metodo Alterar

            ClienteDAO dao = new ClienteDAO();
            dao.alterarCliente(obj);

            //Recarregar o DataGridView
            tabelaCliente.DataSource = dao.listarClientes();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtPesquisa.Text;

            ClienteDAO dao = new ClienteDAO();

            tabelaCliente.DataSource = dao.BuscarClientePorNome(nome);

            if(tabelaCliente.Rows.Count == 0)
            {
                //Recarregar o DataGridView
                tabelaCliente.DataSource = dao.listarClientes();
            }
        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtPesquisa.Text + "%";

            ClienteDAO dao = new ClienteDAO();

            tabelaCliente.DataSource = dao.listarClientesPorNome(nome);

         
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Botao consultar cep 

            try
            {
                string cep = txtCep.Text;
                string xml = "https://viacep.com.br/ws/"+cep+"/xml/";

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
    }
 }
   

