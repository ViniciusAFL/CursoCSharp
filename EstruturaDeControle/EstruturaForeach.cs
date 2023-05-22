using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaForeach
    {
        public static void Executar()
        {
            /*var palavra = "Banana";
            foreach (var letra in palavra)
            {
                Console.WriteLine(letra);
            }*/

            //Percorrendo um array
            var alunos = new string[] { "jose", "Cleiton", "Maria", "josenildo" };

            foreach (var nome in alunos)
            {
                Console.WriteLine(nome);
            }

        }
    }
}
