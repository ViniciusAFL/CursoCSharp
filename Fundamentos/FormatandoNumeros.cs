using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumeros
    {
        public static void Executar()
        {
            double valor = 15.329;
            //Arredondar número
            Console.WriteLine(valor.ToString("F1"));
            //Transformar em valor monetário
            Console.WriteLine(valor.ToString("C"));
            //Formatando do seu jeito
            Console.WriteLine(valor.ToString("#.##"));
        }
    }
}
