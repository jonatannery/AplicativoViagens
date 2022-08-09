using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AplicativoViagens
{
    public class Motorista: Usuario
    {
        private Constantes Constante = new Constantes();
        public ContaBancaria Conta { get; set; }
        public Automovel Veiculo { get; set; }
        public StatusMotorista Selecionarstatus { get; set; }

        public override void Login()
        {
            bool cadastrado = false;
            Motorista motoristaAtual = new Motorista();

            while (cadastrado == false)
            {
                Console.WriteLine("Informe seu e-mail");
                var email = Console.ReadLine();
                Console.WriteLine("Informe sua senha");
                var senha = Console.ReadLine();

                var motoristas = Constante.GetMotorista();

                foreach (var p in motoristas)
                {
                    if (p.EMail == email && p.Senha == senha)
                    {
                        motoristaAtual = p;
                        cadastrado = true;
                        break;
                    }
                }

                if (cadastrado == false)
                {
                    Console.WriteLine("Usuario não encontrado na base de dados!");
                    Console.WriteLine("Informe o email e senha novamente, ou cadastre um novo perfil\t");
                    Console.WriteLine("Deseja criar um novo perfil ?");
                    Console.WriteLine("1 = Sim; 2 = Não;");
                    var acao = Console.ReadLine();

                    if (acao == "0")
                    {
                        break;
                    }
                }
            }

            if (cadastrado == true)
            {
                bool statusCorrida = false;
                var status = 0;
                while (statusCorrida == false)
                {
                    Console.WriteLine("Informe seu status");
                    if(status <= 1)
                    {
                        Console.WriteLine("1 = Aguardando; 2 = Iniciada; 3 = Em Trajeto; 4 = Finalizada;");
                        status = int.Parse(Console.ReadLine());
                    }
                    else if (status == 2)
                    {
                        Console.WriteLine("3 = Em Trajeto; 4 = Finalizada;");
                        status = int.Parse(Console.ReadLine());
                    }

                    if ((int)StatusMotorista.aguardando == status)
                    {
                        Console.WriteLine("Aguardando a corrida ...");
                        Thread.Sleep(5000);
                        Console.WriteLine("Pegar corrida ?");
                        Console.WriteLine("1 = Sim; 2 = Não");
                        var resposta = Console.ReadLine();
                        if(resposta == "1")
                        {
                        }
                        statusCorrida = false;
                    }
                    else if ((int)StatusMotorista.inciada == status)
                    {

                        Console.WriteLine("Corrida iniciada ...");
                        Thread.Sleep(5000);
                        statusCorrida = false;
                    }
                    else if ((int)StatusMotorista.em_trajeto == status)
                    {

                        Console.WriteLine("Corrida em trajeto ...");
                        Thread.Sleep(5000);
                        statusCorrida = false;
                    }
                    else if ((int)StatusMotorista.finalizada == status)
                    {

                        Console.WriteLine("Corrida finalizada!");
                        statusCorrida = true;
                    }
                }
            }
        }


        public void AceitarCorrida()
        {
            Console.Clear();

            bool statusCorrida = false;
            var status = -1;

            Console.WriteLine("Procurando motorista...");
            Thread.Sleep(5000);

            Console.WriteLine("Motorista Julio aceiou a corrida e esta indo até o local...");
            Thread.Sleep(5000);

            Console.WriteLine("Corrida em andamento...");
            Thread.Sleep(5000);

            Console.WriteLine("Corrida em finalizada  ");
            Thread.Sleep(5000);

            Console.WriteLine("Corrida ficou no valor de R$ 50,00");

            /*while (statusCorrida == false)
            {
                Console.WriteLine("Informe seu status");
                if (status <= 0)
                {
                    Console.WriteLine("0 = Aguardando; 1 = Iniciada; 2 = Em Trajeto; 3 = Finalizada;");
                    status = int.Parse(Console.ReadLine());
                }
                else if (status >= 1)
                {
                    Console.WriteLine("2 = Em Trajeto; 3 = Finalizada;");
                    status = int.Parse(Console.ReadLine());
                }

                if ((int)StatusMotorista.aguardando == status)
                {
                    Console.WriteLine("Aguardando a corrida ...");
                    Thread.Sleep(5000);
                    Console.WriteLine("Pegar corrida ?");
                    Console.WriteLine("1 = Sim; 2 = Não");
                    var resposta = Console.ReadLine();
                    if (resposta == "1")
                    {

                    }
                    statusCorrida = false;
                }
                else if ((int)StatusMotorista.inciada == status)
                {

                    Console.WriteLine("Corrida iniciada ...");
                    Thread.Sleep(5000);
                    statusCorrida = false;
                }
                else if ((int)StatusMotorista.em_trajeto == status)
                {

                    Console.WriteLine("Corrida em trajeto ...");
                    Thread.Sleep(5000);
                    statusCorrida = false;
                }
                else if ((int)StatusMotorista.finalizada == status)
                {

                    Console.WriteLine("Corrida finalizada!");
                    statusCorrida = true;
                }
            }*/
        }
    }
}
