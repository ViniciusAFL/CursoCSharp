using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    class ExercicioLambda
    {
        public static void Executar()
        {
            Func<int, bool> Numeropar = (total) =>
             {
                 if (total%2 == 0)
                 {
                     Console.WriteLine("O numero é par");
                     return true;
                 }
                 else
                 {
                     Console.WriteLine("O numero é impar");
                     return false;
                 }
             };

            Console.WriteLine(Numeropar(2));
        
        
        }
    }
}
