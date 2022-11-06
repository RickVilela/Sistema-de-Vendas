using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Vendas.br.com.sistema.MODEL
{
    public class Venda
    {
        //Atributos e Propriedades de Acesso (Getters And Setters)

        public int id { get; set; }
        public int clienteId { get; set; }
        public DateTime dataVenda { get; set; }
        public decimal totalVenda { get; set; }
        public string obs { get; set; }
    }
}
