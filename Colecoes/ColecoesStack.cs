using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class ColecoesStack
    {
        public static void Executar()
        {
            var pilha = new Stack();

            //adiciona elementos na pilha
            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14);

            //exibindo elementos da pilha
            foreach(var item in pilha)
            {
                Console.WriteLine($"{item}");
            }

            //removendo um elemento da pilha
            Console.WriteLine($"Pop: {pilha.Pop()}");

            //percorrendo novamente para verificar se o elemento
            //foi removido

            foreach (var item in pilha)
            {
                Console.WriteLine($"{item}");
            }

            //Usando peek
            Console.WriteLine($"Peek:{pilha.Peek()}");
            //contando os elementos
            Console.WriteLine(pilha.Count);

        }
    }
}
