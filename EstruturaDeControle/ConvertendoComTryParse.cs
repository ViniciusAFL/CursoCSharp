using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    class ConvertendoComTryParse
    {
        public static void Executar()
        {
            //Convertendo com Try parse
            Console.WriteLine("Digite um numero:");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero);
            Console.WriteLine($"Resultado: {numero}");
            /*Enquanto o parse faz a conversão da informação o Tryparse verifica
             * se é possivel converter para depois fazer a conversão */

        }
    }
}
