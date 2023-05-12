using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritmeticos
    {
        public static void Executar()
        { 
            
            Console.WriteLine("Digite um numero:");

            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro numero:");

            int numero2 = int.Parse(Console.ReadLine());

            int soma = numero1 + numero2;

            Console.WriteLine($"A soma deu: {soma}");


            Console.WriteLine("Digite a base do triangulo:");
            double basenum = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altuera do triangulo:");
            double alturanum = double.Parse(Console.ReadLine());

            double area = basenum * alturanum / 2;

            Console.WriteLine($"A área do triangulo é de {area}");
        }
    }
    
}
