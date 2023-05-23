using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            /*Instanciando a classe pessoa
             e criando um objeto pessoa1*//*

            Pessoa pessoa1 = new Pessoa();

            pessoa1.Nome = "Cleiton Perez";
            pessoa1.Idade = 22;

            // PAO DE CREME
            Pessoa pessoa2 = new Pessoa();
            pessoa2.Nome = "Yuri alberto";
            pessoa2.Idade = 21;

            *//*Console.WriteLine($"Olá{pessoa1.Nome} você tem {pessoa1.Idade}");
           
            Console.WriteLine($"Olá{pessoa2.Nome} você tem {pessoa2*//*.Idade}");*//*

            //Chamando o metodo apresentar
            pessoa1.ApresentarNoConsole();*/

            Computador computador1 = new Computador();

            computador1.Fonte = "850w";
            computador1.PlacaDeVideo = "RTX-4090";
            computador1.Processador = "Xeon E5 2640v4";
            computador1.HD ="Seagate 1TB";
            computador1.MemoriaRam = "16GB DDR4 3600MHZ";


            computador1.MostrarConfigs();

        }
    }
}
