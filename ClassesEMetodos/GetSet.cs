using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class GetSet
    {

        class Cliente
        {
            /* O modificador PRIVATE vai garantir que
             * somente a class Cleinte vai ter acesso
             Ao nome*/
            private string nome;
            
            /* Entretanto Haverá momento em que precisaremos
             * tirar esse valor ou abstrair alguma informação
             então usamos GET e SET
            GET PEGA O VALOR e o SET ENVIA O VALOR*/
            
            //GET e o SET precisam ser IGUAIS ao nosso atribruto
            // Da classe Cliente porém com a primeira letra maiuscula
            public string Nome
            {
                //Aqui vamos especificar nossas ações
                get
                {
                    //para pegar valor de Nome, irei usar o return
                    return nome;
                }

                set
                {
                    /* set vai servir para que eu envie o valor
                     então o valor é o valor que o usuario vai me informar
                     na outra classe */
                    nome = value;
                }

            }
        
        
        }


        public static void Executar()
        {
            /* vamos instanciar um objeto da nossa classe */
            Cliente cliente1 = new Cliente();

            /* Exemplo de GET */
            //cliente1.Nome;

            // Usando o SET para enviar uma informação
            cliente1.Nome = "Cleiton";

            Console.WriteLine(cliente1.Nome);
        }
    }
}
