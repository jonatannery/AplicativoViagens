using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoViagens
{
    public class Constantes
    {
        public List<Passageiro> listPassageiro = new List<Passageiro>();
        public List<Motorista> listMotorista = new List<Motorista>();

        //uma lista de login cadastrado
        public List<Passageiro> GetPassageiro()
        {
            var user1 = new Passageiro()
            {
                Nome = "Nilton",
                EMail = "nilton@gmail.com",
                Senha = "123456"
            };

            listPassageiro.Add(user1);

            var user2 = new Passageiro()
            {
                Nome = "Jonatan",
                EMail = "jonatan@gmail.com",
                Senha = "123456"
            };

            listPassageiro.Add(user2);

            var user3 = new Passageiro()
            {
                Nome = "Thalita",
                EMail = "thalita@gmail.com",
                Senha = "123456"
            };

            listPassageiro.Add(user3);

            var user4 = new Passageiro()
            {
                Nome = "Camila",
                EMail = "camila@gmail.com",
                Senha = "123456"
            };

            listPassageiro.Add(user4);

            return listPassageiro;
        }
        //cadastrar um passageiro
        public Passageiro SetPassageiro(string nome, string email, string senha)
        {

            var user1 = new Passageiro()
            {
                Nome = nome,
                EMail = email,
                Senha = senha                
            };

            listPassageiro.Add(user1);

            return user1;
        }
        // lista de motorista cadastrado
        public List<Motorista> GetMotorista()
        {
            var user1 = new Motorista()
            {
                Nome = "Nilton",
                EMail = "nilton@gmail.com",
                Senha = "123456",
                Conta = new ContaBancaria()
                {
                    NumeroConta = 131231,
                    Banco = "Itau",
                    Agencia = 123,
                    Saldo = 100
                },
                Veiculo = new Automovel()
                {
                    Cor = "Preto",
                    Marca = "Chevrolet",
                    Modelo = "Corsa",
                    Placa = "aaf1d245"
                }
            };

            listMotorista.Add(user1);

            var user2 = new Motorista()
            {
                Nome = "Jonatan",
                EMail = "jonatan@gmail.com",
                Senha = "123456",
                Conta = new ContaBancaria()
                {
                    NumeroConta = 131231,
                    Banco = "Itau",
                    Agencia = 123,
                    Saldo = 100
                },
                Veiculo = new Automovel()
                {
                    Cor = "Preto",
                    Marca = "Chevrolet",
                    Modelo = "Corsa",
                    Placa = "WAW22D22"
                }
            };

            listMotorista.Add(user2);

            var user3 = new Motorista()
            {
                Nome = "Thalita",
                EMail = "thalita@gmail.com",
                Senha = "123456",
                Conta = new ContaBancaria()
                {
                    NumeroConta = 131231,
                    Banco = "Itau",
                    Agencia = 123,
                    Saldo = 100
                },
                Veiculo = new Automovel()
                {
                    Cor = "Preto",
                    Marca = "Chevrolet",
                    Modelo = "Corsa",
                    Placa = "WAW22D22"
                }
            };

            listMotorista.Add(user3);

            var user4 = new Motorista()
            {
                Nome = "Camila",
                EMail = "camila@gmail.com",
                Senha = "123456",
                Conta = new ContaBancaria()
                {
                    NumeroConta = 131231,
                    Banco = "Itau",
                    Agencia = 123,
                    Saldo = 100
                },
                Veiculo = new Automovel()
                {
                    Cor = "Preto",
                    Marca = "Chevrolet",
                    Modelo = "Corsa",
                    Placa = "WAW22D22"
                }
            };

            listMotorista.Add(user4);

            return listMotorista;
        }

        public Motorista SetMotorista(
            string nome, string email, string senha, int numConta, string banco, int agencia, string cor, string marca, string modelo, string placa)
        {

            var user1 = new Motorista()
            {
                Nome = nome,
                EMail = email,
                Senha = senha,
                Conta = new ContaBancaria()
                {
                    NumeroConta = numConta,
                    Banco = banco,
                    Agencia = agencia,
                    Saldo = 100
                },
                Veiculo = new Automovel()
                {
                    Cor = cor,
                    Marca = marca,
                    Modelo = modelo,
                    Placa = placa
                }
            };

            listMotorista.Add(user1);

            return user1;
        }
    }
}
