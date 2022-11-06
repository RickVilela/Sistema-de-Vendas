using Sistema_de_Vendas.br.com.sistema.DAO;
using Sistema_de_Vendas.br.com.sistema.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Vendas.br.com.sistema.VIEWS
{
    public partial class FrmVendas : Form
    {
        //Objetos Cliente e ClienteDAO
        Cliente cliente = new Cliente();
        ClienteDAO cdao = new ClienteDAO();

        //Objetos de Produtos
        Produto p = new Produto();
        ProdutoDAO pdao = new ProdutoDAO();

        //Variaveis para Adicionar ao Carrinho
        int qtd;
        decimal preco; 
        decimal subtotal,total;

        //Carrinho
        DataTable carrinho = new DataTable();

        public FrmVendas()
        {
            InitializeComponent();

            carrinho.Columns.Add("Código", typeof(int));
            carrinho.Columns.Add("Produto", typeof(string));
            carrinho.Columns.Add("Quantidade", typeof(int));
            carrinho.Columns.Add("Preço", typeof(decimal));
            carrinho.Columns.Add("SubTotal", typeof(decimal));

            tabelaProdutos.DataSource = carrinho;
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
               cliente = cdao.retornaClientePorCpf(txtCpf.Text);

                if(cliente != null)
                {
                    txtCodCli.Text = cliente.codigo.ToString();
                    txtNome.Text = cliente.nome;
                }
                else
                {
                    txtCpf.Clear();
                    txtCpf.Focus();
                }
            }
        }

        private void txtCodCli_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCodCli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cliente = cdao.retornaClientePorCodigo(int.Parse(txtCodCli.Text));

                if (cliente != null)
                {
                    txtCpf.Text = cliente.cpf;
                    txtNome.Text = cliente.nome;
                }
                else
                {
                    MessageBox.Show("Cliente não Encontrado!");
                    txtCodCli.Clear();
                    txtCodCli.Focus();
                }
            }
        }

        private void txtCodigoProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 )
            {
                p = pdao.retornaProdutoPorCodigo(int.Parse(txtCodigoProd.Text));

                if (p != null)
                {
                    txtDesc.Text = p.descricao;
                    txtPreco.Text = p.preco.ToString();
                }
                else
                {
                    MessageBox.Show("Produto não Encontrado!");
                    txtCodigoProd.Clear();
                    txtCodigoProd.Focus();
                }
            }
           
            

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                //Botao Adicionar Item
                qtd = int.Parse(txtQtd.Text);
                preco = decimal.Parse(txtPreco.Text);

                subtotal = qtd * preco;

                total += subtotal;

                //Adicionar Item no Carrinho
                carrinho.Rows.Add(int.Parse(txtCodigoProd.Text), txtDesc.Text, qtd, preco, subtotal);

                txtTotal.Text = total.ToString();


                //Limpar os campos
                txtCodigoProd.Clear();
                txtDesc.Clear();
                txtQtd.Clear();
                txtPreco.Clear();

                txtCodigoProd.Focus();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Verifique as informações inseridas!");
            }


        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            //Botao Remover Item

        

            string message = "Tem Certeza que deseja remover o Item?";
            string title = "Remover o Item";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                decimal subproduto = decimal.Parse(tabelaProdutos.CurrentRow.Cells[4].Value.ToString());
                int indice = tabelaProdutos.CurrentRow.Index;
                DataRow linha = carrinho.Rows[indice];
                carrinho.Rows.Remove(linha);
                carrinho.AcceptChanges();
                total -= subproduto;
                txtTotal.Text = total.ToString();

                MessageBox.Show("Item removido com Sucesso!");
            }
            else
            {
                
            }       
        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            //Botao Pagamentos

            DateTime data = DateTime.Parse(txtData.Text);

            FrmPagamentos tela = new FrmPagamentos(cliente, carrinho, data);

            //Passando o Total para a tela de Pagamentos
            tela.txtTotal.Text = total.ToString();

            tela.ShowDialog();
        }

        private void txtCodigoProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmVendas_Load(object sender, EventArgs e)
        {
            //Pegando a data atual

            txtData.Text = DateTime.Now.ToShortDateString();
        }
    }
}
