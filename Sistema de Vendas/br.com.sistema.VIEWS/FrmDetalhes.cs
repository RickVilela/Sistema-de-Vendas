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
    public partial class FrmDetalhes : Form
    {
        int vendaId;
        public FrmDetalhes(int idVenda)
        {
            vendaId = idVenda;
            InitializeComponent();
        }

        private void FrmDetalhes_Load(object sender, EventArgs e)
        {
            //Carrega Tela de Detalhes
            ItemVendaDAO dao = new ItemVendaDAO();

            tbDetalhesProd.DataSource = dao.listarItensPorVenda(vendaId);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
