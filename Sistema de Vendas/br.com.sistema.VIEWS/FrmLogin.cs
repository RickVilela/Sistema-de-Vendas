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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //Botão entrar
            string email = txtEmail.Text;
            string senha = txtSenha.Text;

            FuncionarioDAO dao = new FuncionarioDAO();

            if (dao.EfetuarLogin(email, senha))
            {
               

                this.Hide();
            }
            
        }
    }
}
