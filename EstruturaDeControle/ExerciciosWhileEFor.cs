using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    class ExerciciosWhileEFor
    {
        public static void Executar()
        {

            /*int numero = 0;
            for (int i =0; i <10; i++ ) { 
            Console.WriteLine("Digite um numero:");
            int.TryParse(Console.ReadLine(), out int soma );
                numero += soma;
            }

            Console.WriteLine($"A soma dos numeros é: {numero}");*/


            //exercicio 2
            Console.WriteLine("Até quanto você quer contar?");
            int.TryParse(Console.ReadLine(), out int valor);
            int contador = 1;
            while (contador<=valor)
            {
                Console.WriteLine($"{contador}");
                contador++;
            }


            //Exercicio 3
           /* int contador1 = 1;

            Console.WriteLine("Digite um número para saber sua tabuada:");
            int.TryParse(Console.ReadLine(), out int n1);
            while (contador1 <= 10)
            {
                Console.WriteLine($"{n1} X {contador1} = {n1 * contador1}");
                contador1++;
            }*/

        }
    }
}