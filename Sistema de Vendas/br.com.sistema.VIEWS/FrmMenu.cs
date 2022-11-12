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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            //Pegando a data atual
            txtData.Text = DateTime.Now.ToShortDateString();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txtUser_Click(object sender, EventArgs e)
        {

        }

        private void txtData_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Timer
            txtHora.Text = DateTime.Now.ToLongTimeString();    
        }

        private void menuCadastroClientes_Click(object sender, EventArgs e)
        {
            //Abrir a tela de Clientes
            FrmClientes tela = new FrmClientes();
            tela.ShowDialog();
        }

        private void menuConsultaClientes_Click(object sender, EventArgs e)
        {
            //Abrir com a tela de Consulta de Clientes
            FrmClientes tela = new FrmClientes();
            tela.tabClientes.SelectedTab = tela.tabPage2;
            tela.ShowDialog();
        }

        private void menuCadastroFuncionarios_Click(object sender, EventArgs e)
        {
            //Abrir a tela de Funcionarios
            FrmFuncionarios tela = new FrmFuncionarios();
            tela.ShowDialog();
        }

        private void menuConsultaFuncionarios_Click(object sender, EventArgs e)
        {
            //Abrir com a tela de Consulta de Funcionarios 
            FrmFuncionarios tela = new FrmFuncionarios();
            tela.tabFuncionarios.SelectedTab = tela.tabPage2;
            tela.ShowDialog();
        }

        private void menuCadastroFornecedores_Click(object sender, EventArgs e)
        {
            //Abrir a tela de Fornecedores
            FrmFornecedores tela = new FrmFornecedores();
            tela.ShowDialog();
        }

        private void menuConsultaFornecedores_Click(object sender, EventArgs e)
        {
            //Abrir com a tela de Consulta de Fornecedores 
            FrmFornecedores tela = new FrmFornecedores();
            tela.tabFornecedores.SelectedTab = tela.tabPage2;
            tela.ShowDialog();
        }

        private void menuCadastroProdutos_Click(object sender, EventArgs e)
        {
            //Abrir a tela de Produtos
            FrmProdutos tela = new FrmProdutos();
            tela.ShowDialog();
        }

        private void menuConsultaProdutos_Click(object sender, EventArgs e)
        {
            //Abrir com a tela de Consulta de Produtos
            FrmProdutos tela = new FrmProdutos();
            tela.tabProdutos.SelectedTab = tela.tabPage2;
            tela.ShowDialog();
        }

        private void menuVendaNova_Click(object sender, EventArgs e)
        {
            //Abrir a tela de Vendas
            FrmVendas tela = new FrmVendas();
            tela.ShowDialog();
        }

        private void menuVendasHistorico_Click(object sender, EventArgs e)
        {
            //Abrir a tela de Histórico de Vendas
            FrmHistorico tela = new FrmHistorico();
            tela.ShowDialog();
        }

        private void menuTrocaUsuario_Click(object sender, EventArgs e)
        {
            //Abrir a tela de Login
            FrmLogin tela = new FrmLogin();
            this.Dispose();
            tela.ShowDialog();
        }

        private void menuSair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Certeza que deseja sair?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }
    }
}
