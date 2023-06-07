using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encapsulamento;

namespace CursoCSharp.POO
{

    public class FilhoNaoReconhecido : SubCelebridade
    {

        public new void MeusAcessos()
        {
            Console.WriteLine("Filho não reconhecido");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
        }

        class Encapsulamento
        {
            public static void Executar()
            {

            }
        }
    }
}
