using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Variaveis e Constantes - Fundamentos",VariaveisEConstantes.Executar },
                {"Notação Ponto - Fundamentos",NotacaoPonto.Executar },
                {"Lendo Dados - Fundamentos",LendoDados.Executar },
                {"Formatando Numeros - Fundamentos",FormatandoNumeros.Executar },
                {"Operadores Aritmeticos - Fundamentos",OperadoresAritmeticos.Executar },
                {"Exercicios Operadores - Fundamentos",ExerciciosOperadores.Executar },
                {"Operadores Relacionais - Fundamentos",OperadoresRelacionais.Executar },
                {"Operadores Atribuição - Fundamentos",OperadoresAtribuicao.Executar},

                // Estrutura de Controle
                {"EstuturaIf",EstruturaIf.Executar },
                {"Exerciciosif",Exerciciosif.Executar },
                {"Convertendo Com Try Parse",ConvertendoComTryParse.Executar },
                {"Estrutura Switch",EstruturaSwitch.Executar },
                {"Estrutura While e For",EstruturaWhileEFor.Executar },
                {"Exercicios While e For",ExerciciosWhileEFor.Executar },
                {"Estrutura Foreach",EstruturaForeach.Executar },


                //Classes e Metodos
                {"Membros",Membros.Executar },
                {"Construtores",Construtores.Executar }
            });

            central.SelecionarEExecutar();
        }
    }
}