using System;

namespace AplicativoViagens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("||=============== Aplicativo de viagens ==================||0\n");
            Console.WriteLine("Selecione 1 para login ou 2 para registrar conta ");
            var acao = Console.ReadLine();
            if(acao == "1")
            {
                Logar();
                

            }
            else
            {
                Registrar();
            }

            var motorista = new Motorista();

            motorista.AceitarCorrida();
           

           
        }

        public static void Logar()
        {
            var passageiro = new Passageiro();

            passageiro.Login();
        }

        public static void Registrar()
        {
            var passageiro = new Passageiro();
            passageiro.RegistrarConta();
        }



    }    
}
