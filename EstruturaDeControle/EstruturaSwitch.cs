using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaSwitch
    {
        public static void Executar()
        {
            /*Console.WriteLine("Avalie o meu atendimento com uma nota de 1 a 5");
            int.TryParse(Console.ReadLine(),out int nota);

            switch (nota)
            {
                case 1:
                    Console.WriteLine("Péssimo!");
                    break;
                case 2:
                    Console.WriteLine("Ruim!");
                    break;
                case 3:
                    Console.WriteLine("Regular");
                    break;
                case 4:
                    Console.WriteLine("Bom!");
                    break;
                    case 5:
                        Console.WriteLine("Excelente");
                    break;
                default:
                    Console.WriteLine("Nota invalida");
                    break;
*/


            Console.WriteLine("Digite o ddd para a ligação intermunicipal:");
            int.TryParse(Console.ReadLine(), out int ddd);
            switch (ddd)
            {
                case 61:
                    Console.WriteLine("Ligação para Brasilia");
                    break;

                case 71:
                    Console.WriteLine("Ligação para Salvador");
                    break;

                case 11:
                    Console.WriteLine("Ligação Para São Paulo");
                    break;
                case 21:
                    Console.WriteLine("Ligação Para o Rio De janeiro");
                    break;
                case 32:
                    Console.WriteLine("Ligação Para Juiz De fora");
                    break;
                case 19:
                    Console.WriteLine("Ligação Para Campinas");
                    break;
                case 27:
                    Console.WriteLine("Ligação Para Vitória");
                    break;
                case 31:
                    Console.WriteLine("Ligação Para Belo Horizonte");
                    break;
                default:
                    Console.WriteLine("DDD inválido:");
                    break;
            }






            }
        }
    }

