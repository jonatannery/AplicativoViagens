using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoViagens
{
    public class Cartao
    {
        public Tipo Tipo { get; set; }
        public string NomeTitular { get; set; }
        public string NumeroCartao { get; set; }
        public string CPF { get; set; }
        public int CVV { get; set; }
        public string Validade { get; set; }   
    }
}
