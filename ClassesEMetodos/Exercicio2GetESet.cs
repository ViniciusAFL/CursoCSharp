using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Exercicio2GetESet
    {
        class Aluno
        {
            public double n1;
            public double n2;
            public double n3;
            public string nome;

            public double Media
            {
                get
                {
                    return (n1 + n2 + n3) / 3;
                }

                set
                {
                    n1 = value;
                    n2 = value;
                    n3 = value;
                }
            }

            public string Nome
            {
                get {
                    return Nome;
                }

                set
                {
                    nome = value;
                }

            }

           


            public Aluno(string nome, double n1, double n2, double n3)
            {
                this.n1 = n1;
                this.n2 = n2;
                this.n3 = n3;
                Nome = nome;
            }

      

        }

        public static void Executar()
        {
            var aluno1 = new Aluno("cleiton",2,4,5);
            Console.WriteLine("Olá");
            Console.WriteLine(aluno1.nome);
            Console.WriteLine("Sua media foi de:");
            Console.WriteLine(aluno1.Media);
            

        }
    }



}
