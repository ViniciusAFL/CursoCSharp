using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaWhileEFor
    {
        public static void Executar()
        {
            /*Console.WriteLine("Até quanto você quer contar?");
            int.TryParse(Console.ReadLine(), out int valor);
            Console.WriteLine("Qual o valor dos saltos? \n");
            int.TryParse(Console.ReadLine(), out int saltos);

            int contador = 1;
            while (contador < valor)
            {
                Console.WriteLine(contador);
                contador+=saltos;
            }*/

            for (int contador = 1; contador <10 ; contador++)
            {
                Console.WriteLine(contador);
            }

        }
    }
}
