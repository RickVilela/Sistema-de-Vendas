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
    public partial class FrmPagamentos : Form
    {

        Cliente cliente = new Cliente();
        DataTable carrinho = new DataTable();
        DateTime data;

        public FrmPagamentos(Cliente cliente, DataTable carrinho, DateTime data)
        {
            this.cliente = cliente;
            this.carrinho = carrinho;
            this.data = data;

            InitializeComponent();
            
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            //Botao Finalizar Venda

            try
            {
                decimal vDinheiro, vCartao, troco, totalPago, totalVenda;

                ProdutoDAO daoProduto = new ProdutoDAO();

                int qtdEstoque, qtdComprada, EstoqueAtualizado;

                vDinheiro = decimal.Parse(txtDinheiro.Text);
                vCartao = decimal.Parse(txtCartao.Text);
                totalVenda = decimal.Parse(txtTotal.Text);

                //Calcular total Pago

                totalPago = vDinheiro + vCartao;

                if(totalPago < totalVenda)
                {
                    MessageBox.Show("O Valor total pago é menor que o valor da Venda!");
                }
                else
                {
                    //Calcular o troco
                    troco = totalPago - totalVenda;

                    //Pegando os dados para inserir no Banco
                    Venda vendas = new Venda();

                    vendas.clienteId = cliente.codigo;
                    vendas.dataVenda = data;
                    vendas.totalVenda = totalVenda;
                    vendas.obs = txtObs.Text;

                    VendaDAO vdao = new VendaDAO();
                    txtTroco.Text = troco.ToString();

                    vdao.cadastrarVenda(vendas);

                    //Cadastrar os itens da Venda
                    //Percorrer os itens do Carrinho

                    foreach(DataRow linha in carrinho.Rows)
                    {
                        ItemVenda item = new ItemVenda();
                        item.vendaId = vdao.retornaIdUltimaVenda();
                        item.produtoId = int.Parse(linha["Código"].ToString());
                        item.qtd = int.Parse(linha["Quantidade"].ToString());
                        item.subTotal = decimal.Parse(linha["Subtotal"].ToString());

                        //Baixa no Estoque
                        qtdEstoque = daoProduto.retornaEstoqueAtual(item.produtoId);
                        qtdComprada = item.qtd;
                        EstoqueAtualizado = qtdEstoque - qtdComprada;

                        daoProduto.baixaEstoque(item.produtoId, EstoqueAtualizado);

                        ItemVendaDAO itemDao = new ItemVendaDAO();
                        itemDao.cadastrarItem(item);
                    }

                    MessageBox.Show("Venda Finalizada com Sucesso!");
                    
                   this.Dispose();

                    new FrmVendas().ShowDialog();
                }
            }
            catch (Exception)
            {

                throw;
            }
           
           
        }

        private void FrmPagamentos_Load(object sender, EventArgs e)
        {
            //Carregar Tela
            txtTroco.Text = "0,00";
            txtDinheiro.Text = "0,00";
            txtCartao.Text = "0,00";
        }
    }
}
