using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoViagens
{
    public class Corrida
    {
        public double valorCorrida { get; set; }
        public string FinalizarCorrida { get; set; }

        public void Receber()
        {
            valorCorrida = 50;
            while (true) {
                string finalizar = Console.ReadLine();
                if (finalizar == "Corrida finalizada")
                {
                    FinalizarCorrida = finalizar;
                    Console.WriteLine(FinalizarCorrida);
                }
                Console.WriteLine("Corrida em andamento");
            }

        }
    }
}
