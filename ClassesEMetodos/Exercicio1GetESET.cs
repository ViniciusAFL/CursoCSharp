using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Exercicio1GetESET
    {

        class Pessoa
        {


            private string nome;
            private double altura;
            private DateTime datadeNasc;



            public string Nome
            {
                get
                {
                    return nome;
                }

                set
                {
                    nome = value;
                }

            }


            public double Altura
            {
                get
                {
                    return altura;
                }

                set
                {
                    altura = value;
                }

            }

            public DateTime DatadeNasc
            {
                get
                {
                    return DatadeNasc;
                }

                set
                {
                    datadeNasc = value;
                }

            }



            public int calcularidade()
            {

                return DateTime.Today.Year - datadeNasc.Year;

            }

            public void Imprimir()
            {
                Console.WriteLine($"Olá {nome}");
                Console.WriteLine($"Sua altura é {altura}");
                Console.WriteLine($"E a sua idade é {datadeNasc}");
            }


           

           
        }

        public static void Executar()
        {
            Pessoa pessoa1 = new Pessoa();
            pessoa1.Nome = "C";
            pessoa1.Altura = 1.80;
            pessoa1.DatadeNasc = new DateTime(2001, 10, 24);

            pessoa1.Imprimir();
            // pessoas.calcularidade();


            int idade = pessoa1.calcularidade();



            Console.WriteLine($"Sua Idade:{idade}");
        }

    }
}