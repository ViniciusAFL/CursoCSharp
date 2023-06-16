using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Excecao
{
    class PrimeiraExcecao
    {   
        public class Conta
        {
            private double Saldo;

            public Conta(double saldo)
            {
                Saldo = saldo;
            }

            public void Sacar(double valor)
            {
                if (valor > Saldo)
                {
                    throw new ArgumentException("Saldo insuficiente");
                }
                //Se o usuario sacar um valor menor que o saldo
                Saldo -= valor;
            }

         }

        

        public static void Executar()
        {
            var conta = new Conta(1200);

            try
            {
                //Aqui vamos tentar sacar, se der certo o valor será retirado
                conta.Sacar(500);
                Console.WriteLine("Valor retirado com sucesso!");
            }
            catch(Exception ex)
            {
                //Aqui dentro vamos receber a exceção
                Console.WriteLine(ex.Message);
            } //Além do try e cach temos o finnaly que é executado em qualquer situação
            finally
            {
                Console.WriteLine("Obrigado!");
            }
        }
    }
}
