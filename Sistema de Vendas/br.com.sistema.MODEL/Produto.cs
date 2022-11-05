using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Vendas.br.com.sistema.MODEL
{
    public class Produto
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public decimal preco { get; set; }
        public int qtdEstoque { get; set; }
        public int for_id { get; set; }

    }
}
