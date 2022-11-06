using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Vendas.br.com.sistema.MODEL
{
    public class ItemVenda
    {
        public int id { get; set; }
        public int vendaId { get; set; }
        public int produtoId { get; set; }
        public int qtd { get; set; }
        public decimal subTotal { get; set; }
    }
   
}
