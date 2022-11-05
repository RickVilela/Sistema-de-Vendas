using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Vendas.br.com.sistema.MODEL
{
    public class Funcionario : Cliente
    {
        // Atributos, Getters and Setters / (Utilizando Herança da Classe de Clientes)
        public string senha { get; set; }
        public string cargo { get; set; }
        public string nivelAcesso { get; set; }
    }
}
