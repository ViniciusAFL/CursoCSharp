using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    class ExemploLambda
    {
        public static void Executar()
        {   
            //Criando a função
            Action algoNoConsole = () =>
            {
                Console.WriteLine("Palmeiras não tem mundial");
            };

            //Chamando a função
            //algoNoConsole();

            //Criando uma função com retorno
            Func<int> jogarDados = () =>
            {
                Random random = new Random();
                return random.Next(1, 6);
            };

            Console.WriteLine(jogarDados());

            Func<int, int, int, string> formatarData = (dia, mes, ano) =>
            {
                return string.Format("{0:D2} / {1:D2} / {2:D2}", dia, mes, ano);
            };

            Console.WriteLine(formatarData(20,03,1998));
        }
    }
}
