using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class LendoDados {

        public static void Executar()
        {
            Console.WriteLine("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual é a sua idade? ");
            //Fazendo a conversão de um inteiro
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é a sua altura? ");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine($"Olá {nome} você tem {idade} anos  e sua altura é {altura}");
        }
    }
}
