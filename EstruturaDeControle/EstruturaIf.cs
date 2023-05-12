using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaIf
    {
        public static void Executar()
        {
            Console.WriteLine("Digite a primeira nota:");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota:");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota:");
            double n3 = double.Parse(Console.ReadLine());

            double notas = (n1 + n2 + n3) / 3;

            if (notas>=7)
            {
                Console.WriteLine("Você foi aprovado!");
            }

            else
            {
                Console.WriteLine("Você Foi reprovado!");
            }
        }
    }
}
