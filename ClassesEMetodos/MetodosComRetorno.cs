using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class MetodosComRetorno
    {

        class CalculadoraComum
        {

            public int Somar(int a, int b)
            {
                return a + b;
            }

            public int Subtrair(int c, int d)
            {
                return c - d;
            }

            public int Multiplicacao(int e, int f)
            {
                return e * f;
            }

            public double Divisao(double g, double h)
            {
                return g / h;
            }
}
            public static void Executar()
            {
                var calculadoracomum = new CalculadoraComum();

                var resultado = (calculadoracomum.Somar(27, 42));
                Console.WriteLine(resultado);

                Console.WriteLine(calculadoracomum.Multiplicacao(10, 10));
            }
        }
    }

