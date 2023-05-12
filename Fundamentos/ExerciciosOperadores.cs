using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class ExerciciosOperadores
    {
        public static void Executar()
        {
            //exercicio 1
            /*Console.WriteLine("Digite o nome do aluno");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a primeira nota:");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Segunda nota do aluno:");
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Terceira nota do aluno:");
            double n3 = double.Parse(Console.ReadLine());

            double media = (n1 + n2 + n3) / 3;

            Console.WriteLine($"A média do {nome} é de: {media}")*/;

            // exercicio 2
            /*Console.WriteLine("Digite Sua nota");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite Sua segunda nota");
            double n2 = double.Parse(Console.ReadLine());

            double median1 = n1 * 3.5;
            double median2 = n2 * 7.5;

            double mediatotal = (median1 + median2) / 11;
            Console.WriteLine(mediatotal.ToString("#.#"));

            Console.WriteLine($"A media total é de: {mediatotal}");*/



            //Exercicio 3
            Console.WriteLine("Digite o numero do funcionario:");
            int funcionario = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite A quantidade de horas Trabalhadas:");
            double horas = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o salário por hora trabalhada");
            double salhora = double.Parse(Console.ReadLine());

            double totalsal = horas * salhora;


            Console.WriteLine($"Numero de funcionário: {funcionario}");
            Console.WriteLine("O salário é de: \n");
            Console.WriteLine(totalsal.ToString("C")); ;


        }
            
    }

}
