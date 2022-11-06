using Sistema_de_Vendas.br.com.sistema.DAO;
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
    public partial class FrmHistorico : Form
    {
        public FrmHistorico()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            DateTime dataInicio, dataFim;

            dataInicio = Convert.ToDateTime(dtInicio.Value.ToString("yyyy-MM-dd"));
            dataFim = Convert.ToDateTime(dtFim.Value.ToString("yyyy-MM-dd"));

            VendaDAO dao = new VendaDAO();

            tbHistorico.DataSource = dao.listarVendasPorPeriodo(dataInicio, dataFim);

        }

        private void FrmHistorico_Load(object sender, EventArgs e)
        {
            VendaDAO dao = new VendaDAO();

            tbHistorico.DataSource = dao.listarVendas();

        }

        private void tbHistorico_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //1 Passo - Abrir o outro formulario (Detalhes da Venda)
            //Passando Id da Venda
            int idVenda = int.Parse(tbHistorico.CurrentRow.Cells[0].Value.ToString());
            FrmDetalhes tela = new FrmDetalhes(idVenda);

            DateTime dataVenda = Convert.ToDateTime(tbHistorico.CurrentRow.Cells[1].Value.ToString());

            tela.txtData.Text = dataVenda.ToString("dd/MM/yyyy");
            tela.txtCliente.Text = tbHistorico.CurrentRow.Cells[2].Value.ToString();
            tela.txtTotalVenda.Text = tbHistorico.CurrentRow.Cells[3].Value.ToString();
            tela.txtObs.Text = tbHistorico.CurrentRow.Cells[4].Value.ToString();

            tela.ShowDialog();
        }
    }
}
