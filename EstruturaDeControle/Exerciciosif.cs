using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    class Exerciciosif
    {
        public static void Executar()
        {
            /*Console.WriteLine("Digite o ano de seu nascimento:");
            int ano = int.Parse(Console.ReadLine());
            int idade = 2023-ano;

            if (idade>18 && idade<70 )
            {
                Console.WriteLine($"Sua idade é de: {idade} e \n");
                Console.WriteLine("Seu Voto é obrigatório:");

            }

            if (idade<18)
            {
                Console.WriteLine("Você não tem idade para votar:");
            }

            else if(idade>70)
            {
                Console.WriteLine("Seu voto é facultativo");
            }*/


            //Exercicio 2

            /*var senha = "7azpqj9H";
            Console.WriteLine("Digite a senha:");

            var senha2 = (Console.ReadLine());

            if (senha2==senha) {
                Console.WriteLine("Acesso pertimido:");
            }

            else
            {
                Console.WriteLine("Acesso Negado");
            }*/



            //exercicios 3
            /*Console.WriteLine("Digite sua nota: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua Segunda nota:");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua Terceira nota");
            double n3 = double.Parse(Console.ReadLine());

            double media = (n1 + n2 + n3) / 3;

            if (media >=7)
            {
                Console.WriteLine("Sua nota foi de:");
                Console.WriteLine(media.ToString("#.##"));
                Console.WriteLine("E voce foi aprovado!");
            }

            else if (media>=5 && media<=7)
            {
                Console.WriteLine("Sua nota foi de:");
                Console.WriteLine(media.ToString("#.##"));
                Console.WriteLine("E você está de recuperação!");
            }

            else
            {
                Console.WriteLine("Sua nota foi de:");
                Console.WriteLine(media.ToString("#.##"));
                Console.WriteLine("E você foi reprovado!");
            }*/


            Console.WriteLine("Digite a sua altura:");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o seu peso:");
            double peso = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            if (imc <= 18.5)
            {
                Console.WriteLine($"Seu imc é de : ");
                Console.WriteLine(imc.ToString("#.##"));
                Console.WriteLine("E você está abaixo do peso!");
            }

            else if (imc >18.5 && imc<=24.9)
            {
                Console.WriteLine($"Seu imc é de : ");
                Console.WriteLine(imc.ToString("#.##"));
                Console.WriteLine("E você está Com o peso normal");
            }

            else if (imc>=24.9 && imc <=29.9)
            {
                Console.WriteLine($"Seu imc é de : ");
                Console.WriteLine(imc.ToString("#.##"));
                Console.WriteLine("E você está Acima do peso!");
            }

            else if (imc >= 29.9 && imc <= 34.9)
            {
                Console.WriteLine($"Seu imc é de : ");
                Console.WriteLine(imc.ToString("#.##"));
                Console.WriteLine("E você está com obesidade grau I");
            }

            else if (imc >= 34.9 && imc <= 39.9)
            {
                Console.WriteLine($"Seu imc é de : ");
                Console.WriteLine(imc.ToString("#.##"));
                Console.WriteLine("E você está com obesidade grau II");
            }
            else
            {
                Console.WriteLine($"Seu imc é de : ");
                Console.WriteLine(imc.ToString("#.##"));
                Console.WriteLine("E você está com obesidade grau III");
            }
        
        }   
    }
}
