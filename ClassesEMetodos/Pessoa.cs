using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Pessoa
    {   
        /*Estamos colocando o tipo public porque
         quero que esse atributo fique visível para a
        minha classe, imagina que na vida real temos alguns atributos que
        precisam ser pubic e outros que precisam ser privados*/
        public string Nome;
        public int Idade;

        public string Apresentar()
        {
            return string.Format($"Olá!, Me chamo {Nome} e tenho {Idade} anos ");
        }
        /*O método Format retorna uma string formatada
         e imprime no console*/

        public void ApresentarNoConsole()
        {
            /*Aqui eu vou chamar no console
             O metodo que eu criei que é o apresentar*/
            Console.WriteLine(Apresentar());

            

        }

    }



}
