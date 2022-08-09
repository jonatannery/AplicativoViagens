using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoViagens
{
    public class ContaBancaria
    {
        public int NumeroConta { get; set; }
        public string Banco { get; set; }
        public int Agencia { get; set; }
        public double Saldo { get; set; }

        public void ReceberPagamento(double valor)
        {
            Saldo += valor;
        }

    }
}
