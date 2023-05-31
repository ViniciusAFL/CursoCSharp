using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Exercicio3GetESet
    {

        class Animal {

            public string nome;
            public string tipo;

            public string Nome
            {
                get {
                    return nome;
                }

                set
                {
                    nome = value;
                }

            }

             public string Tipo
            {
                get
                {
                    return tipo;
                }

                set
                {
                    if (tipo == "gato" || tipo == "cachorro" || tipo == "Ave")
                    {
                        tipo = value;
                    }
                    else
                    {
                        tipo = "ave";
                    }
                }

            }
           


        }
            
          
        
        






        public static void Executar()
        {
            var animal1 = new Animal();

            Console.WriteLine("Digite o nome do animal");
            animal1.Nome = (Console.ReadLine());

            Console.WriteLine("Digite o tipo do animal");
            animal1.Tipo = (Console.ReadLine());

            Console.WriteLine("Nome do animal:");
            Console.WriteLine(animal1.Nome);
            Console.WriteLine("O tipo do animal é:");
            Console.WriteLine(animal1.Tipo);
            
           
        }
    }
}
