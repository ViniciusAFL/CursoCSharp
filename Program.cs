﻿using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.POO;

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
                {"Construtores",Construtores.Executar },
                {"Metodos com Retorno",MetodosComRetorno.Executar },
                {"Exercicios Com Metodos",ExerciciosMetodos.Executar },
                {"Metodos Estáticos",MetodosEstaticos.Executar },
                {"Params ",Params.Executar },
                {"Get E set",GetSet.Executar },
                {"Get E Set Segundo Exemplo",GetESetSegundoExemplo.Executar },
                {"Exercicio 1 Get E Set",Exercicio1GetESET.Executar },
                {"Exercicio 2 Get E Set",Exercicio2GetESet.Executar },
                {"Exercicio 3 Get E Set",Exercicio3GetESet.Executar },

                //Coleções
                {"Arrays",Arrays.Executar },
                {"Queue",ColecoesQueue.Executar },
                {"Coleções Stack",ColecoesStack.Executar },

                //POO
                {"Herença",Herenca.Executar },
                {"Construtor this-PDO",ConstrutorThis.Executar },
                {"Encapsulamento",POO.Encapsulamento.Executar },
                {"Polimorfismo",Polimorfismo.Executar },
                {"Exercicio Polimorfismo",ExercicioPolimorfismo.Executar }

            });

            central.SelecionarEExecutar();
        }
    }
}