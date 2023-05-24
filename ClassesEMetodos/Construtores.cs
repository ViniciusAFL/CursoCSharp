using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{



    class Cliente
    {
        //Atributos de cliente
        public string Nome;
        public string Cpf;
        public string Sexo;
        public string Endereco;
        public int Idade;

        //Construtor Personalizado
        public Cliente(string nome, string cpf, string sexo, string endereco, int idade)
        {
            Nome = nome;
            Cpf = cpf;
            Sexo = sexo;
            Endereco = endereco;
            Idade = idade;
        }

        public Cliente()
        {

        }
    }



        class Construtores
        {

            public static void Executar()
            {
                var cliente1 = new Cliente();
                /** New cliente é um Construtor
                 * Esse construtor é padrão e não recebe
                 * nenhum parametro
                */
                cliente1.Nome = "Cleber";
                cliente1.Cpf = "11122233344";
                cliente1.Sexo = "M";
                cliente1.Endereco = "Vila pires";
                cliente1.Idade = 70;

                //Outra forma de chamar o contrutor
                var cliente2 = new Cliente("Rogerio ceni", "12345678910", "M", "Ramiro coleoni", 40);

                var cliente3 = new Cliente()
                {
                    Nome = "Amanda",
                    Sexo = "F",
                    Endereco = "Avenida portugal",
                    Idade = 25
                };

                Console.WriteLine($"Olá {cliente2.Nome} , você tem {cliente2.Idade} , e é Muito calvo filho ");

            }
        }
    }

