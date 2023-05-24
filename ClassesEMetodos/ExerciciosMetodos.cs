using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class ExerciciosMetodos
    {

        class Converter{

            public double ConverterDolar(double a)
        {
                return a / 4.95; ;
        }
        
    }

        class Graus
        {
            public double GrausParaF(double a)
            {
                return a * 1.8 + 32;
            }
        }



        public static void Executar()
        {
           var calculardolar = new Converter();
            Console.WriteLine("Digite o Valor em Reais que você deseja Converter");
            double valor = double.Parse(Console.ReadLine());

            var resultado = calculardolar.ConverterDolar(valor);
            Console.WriteLine($"O Valor em dolar é:{resultado}\n");


            var grausparaf = new Graus();
            Console.WriteLine("Qual a temperatura que você deseja converter?");
            double fah = double.Parse(Console.ReadLine());

            var resultadograu = grausparaf.GrausParaF(fah);
            Console.WriteLine($"A temperatura é de :{resultadograu}");
            
        }
    }
}
