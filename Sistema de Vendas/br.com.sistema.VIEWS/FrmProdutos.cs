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
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            FornecedorDAO f_dao = new FornecedorDAO();

            cbFornecedor.DataSource = f_dao.listarFornecedores();
            cbFornecedor.DisplayMember = "nome";
            cbFornecedor.ValueMember = "id";

            ProdutoDAO dao = new ProdutoDAO();
            tabelaProduto.DataSource = dao.listarProdutos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //1 Passo - Receber todos os dados da tela

            Produto obj = new Produto();

            obj.descricao = txtDesc.Text;
            obj.preco = decimal.Parse(txtPreco.Text);
            obj.qtdEstoque = int.Parse(txtQtdEstoque.Text);
            obj.for_id = int.Parse(cbFornecedor.SelectedValue.ToString());

            //2 passo - Criar obj Dao

            ProdutoDAO dao = new ProdutoDAO();
            dao.cadastrarProduto(obj);

            tabelaProduto.DataSource = dao.listarProdutos();

            new Helpers().LimparTela(this);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

        private void tabelaProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegar os dados da Linha Selecionada

            txtCodigo.Text = tabelaProduto.CurrentRow.Cells[0].Value.ToString();
            txtDesc.Text = tabelaProduto.CurrentRow.Cells[1].Value.ToString();
            txtPreco.Text = tabelaProduto.CurrentRow.Cells[2].Value.ToString();
            txtQtdEstoque.Text = tabelaProduto.CurrentRow.Cells[3].Value.ToString();
            cbFornecedor.Text = tabelaProduto.CurrentRow.Cells[4].Value.ToString();

            //Ir para a pagina de Cadastro com as informacões preenchidas

            tabProdutos.SelectedTab = tabPage1;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //Botao Alterar
            Produto obj = new Produto();

            // Receber dados dos campos

            obj.descricao = txtDesc.Text;
            obj.preco = decimal.Parse(txtPreco.Text);
            obj.qtdEstoque = int.Parse(txtQtdEstoque.Text);
            obj.for_id = int.Parse(cbFornecedor.SelectedValue.ToString());
            obj.id = int.Parse(txtCodigo.Text);


            //Criar Objeto FuncionarioDAO
            ProdutoDAO dao = new ProdutoDAO();
            dao.alterarProduto(obj);

            tabelaProduto.DataSource = dao.listarProdutos();

            new Helpers().LimparTela(this);

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Botao Excluir
            Produto obj = new Produto();

            // Receber dados dos campos

            obj.id = int.Parse(txtCodigo.Text);


            //Criar Objeto FuncionarioDAO
            ProdutoDAO dao = new ProdutoDAO();
            dao.excluirProduto(obj);

            tabelaProduto.DataSource = dao.listarProdutos();

            new Helpers().LimparTela(this);
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string descricao = "%" + txtPesquisa.Text + "%";

            ProdutoDAO dao = new ProdutoDAO();
            tabelaProduto.DataSource = dao.listarProdutosPorDescricao(descricao);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string descricao = txtPesquisa.Text;

            ProdutoDAO dao = new ProdutoDAO();

            tabelaProduto.DataSource = dao.listarProdutosPorDescricao(descricao);

            if (tabelaProduto.Rows.Count == 0 || txtPesquisa.Text == string.Empty)
            {
                MessageBox.Show("Produto não Encontrado!");
                tabelaProduto.DataSource = dao.listarProdutos();
            }
        }
    }
}
