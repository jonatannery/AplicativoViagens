using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoViagens
{
     public class Passageiro : Usuario
    {
        private Constantes constante = new Constantes();
        public string EndPartida{ get; set; }
        public string EndDestino { get; set; }
        public Cartao Cartao { get; set; }
        public FormaPagamento PagamentoAtual { get; set; }

        public override void Login()
        {   
            
            bool cadastrado = false;
            Passageiro passageiroAtual = new Passageiro();
            var acao = "";

            // validar o email 
            while (cadastrado == false)
            {
                Console.WriteLine("Informe seu e-mail");
                var email = Console.ReadLine();
                Console.WriteLine("Informe sua senha");
                var senha = Console.ReadLine();
                Console.WriteLine();

                //lista de passageiro
                // um lista de login cadastrados , que vem da classe constantes
                var passageiros = constante.GetPassageiro();

                foreach (var p in passageiros)
                {
                    if(p.EMail == email && p.Senha == senha)
                    {
                        passageiroAtual = p;
                        cadastrado = true;
                        break;
                    }
                }

                if (cadastrado == false)
                {
                    Console.WriteLine("Usuario não encontrado na base de dados!");
                    Console.WriteLine("Informe o email e senha novamente\t");
                    Console.WriteLine("Deseja criar um novo perfil ?");
                    Console.WriteLine("1 = Sim; 2 = Não;");
                    acao = Console.ReadLine();

                    if(acao == "2")
                    {
                        break;
                    }
                    else
                    {
                        RegistrarConta();
                        break;
                    }
                }
            }

            if(acao != "1")
            {
                ComecarCorrida(passageiroAtual);
            }
        }

        public override void RegistrarConta()
        {
            Console.WriteLine("Informe seu nome");
            var nome = Console.ReadLine();
            Console.WriteLine("Informe seu e-mail");
            var email = Console.ReadLine();
            Console.WriteLine("Informe sua senha");
            var senha = Console.ReadLine();

            // cadastrar um conta ,caso nao esteja na lista cadastrada . "SetPassageiro"
            var passageiroAtual = constante.SetPassageiro(nome, email, senha);

            ComecarCorrida(passageiroAtual);
        }

        public void ComecarCorrida(Passageiro passageiroAtual)
        {
            Console.WriteLine("Informe sua localização");
            var patida = Console.ReadLine();
            Console.WriteLine("Informe seu destino");
            var destino = Console.ReadLine();

            passageiroAtual.EndPartida = patida;
            passageiroAtual.EndDestino = destino;

            bool pagar = false;
            while (pagar == false)
            {
                Console.WriteLine("Informe a forma de pagamento: ");
                Console.WriteLine("0 = Dinheiro; 1 = Debito; 2 = Credito ");
                int formaPagamento = int.Parse(Console.ReadLine());
                // "Enum" pra selecionar a forma de pagamento em Debito
                if ((int)FormaPagamento.debito == formaPagamento)
                {
                    Console.WriteLine("Informe os dados do cartão");
                    Console.Write("Nome do titular: ");
                    var nomeTitular = Console.ReadLine();
                    Console.Write("Numero do cartão: ");
                    var numeroCartao = Console.ReadLine();
                    Console.Write("CPF: ");
                    var cpf = Console.ReadLine();
                    Console.Write("CVV: ");
                    var cvv = Console.ReadLine();
                    Console.Write("Validade: ");
                    var validade = Console.ReadLine();

                    passageiroAtual.Cartao = new Cartao()
                    {
                        Tipo = Tipo.Debito,
                        NomeTitular = nomeTitular,
                        CPF = cpf,
                        NumeroCartao = numeroCartao,
                        CVV = int.Parse(cvv),
                        Validade = DateTime.Parse(validade).Month + "/" + DateTime.Parse(validade).Year
                    };

                    passageiroAtual.PagamentoAtual = FormaPagamento.debito;

                    pagar = true;
                }
                // "Enum" pra selecionar a forma de pagamento em credito
                else if ((int)FormaPagamento.credito == formaPagamento)
                {
                    Console.WriteLine("Informe os dados do cartão");
                    Console.Write("Nome do titular: ");
                    var nomeTitular = Console.ReadLine();
                    Console.Write("Numero do cartão: ");
                    var numeroCartao = Console.ReadLine();
                    Console.Write("CPF: ");
                    var cpf = Console.ReadLine();
                    Console.Write("CVV: ");
                    var cvv = Console.ReadLine();
                    Console.Write("Validade: ");
                    var validade = Console.ReadLine();

                    passageiroAtual.Cartao = new Cartao()
                    {
                        Tipo = Tipo.Debito,
                        NomeTitular = nomeTitular,
                        CPF = cpf,
                        NumeroCartao = numeroCartao,
                        CVV = int.Parse(cvv),
                        Validade = DateTime.Parse(validade).Month + "/" + DateTime.Parse(validade).Year
                    };

                    passageiroAtual.PagamentoAtual = FormaPagamento.credito;
                    pagar = true;
                }
                // "Enum" pra selecionar a forma de pagamento em credito
                else if ((int)FormaPagamento.dinheiro == formaPagamento)
                {

                    passageiroAtual.PagamentoAtual = FormaPagamento.dinheiro;
                    pagar = true;
                }
                else
                {
                    Console.WriteLine("Informe a forma de pagamento correta");
                }
            }
            
            Console.WriteLine($"Nome: {passageiroAtual.Nome}");
        }

    }
}
