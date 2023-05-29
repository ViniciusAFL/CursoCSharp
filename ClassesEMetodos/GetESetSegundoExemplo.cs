using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class GetESetSegundoExemplo
    {   
        public class CarroOpcional
        {
            private double desconto = 0.1;
            private string nome;

            public string Nome
            {
                get
                {
                    return "Opcional" + nome;
                }

                set
                {
                    nome = value;
                }

            }

            public double Desconto { get; set; }

            public double Preco { get; set; }

            public double PrecoComDesconto
            {
                get
                {
                    return Preco - (Desconto*Preco);
                }
            }

            //criando o construtor personalizado
            public CarroOpcional(string nome, double preco)
            {
                Nome = nome;
                Preco = preco;
            }

        }


        public static void Executar()
        {
            var op = new CarroOpcional("Aerofólio", 1.500);
            var op2 = new CarroOpcional("Ar Condicionado", 3.200);
            Console.WriteLine(op.PrecoComDesconto);
            Console.WriteLine(op2.PrecoComDesconto);
        }
    }
}
