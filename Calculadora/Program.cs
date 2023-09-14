﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Operacoes> filaOperacoes = new Queue<Operacoes>();
            filaOperacoes.Enqueue(new Operacoes { valorA = 2, valorB = 3, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 14, valorB = 8, operador = '-' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 5, valorB = 6, operador = '*' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 2147483647, valorB = 2, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 18, valorB = 3, operador = '/' });

            Calculadora calculadora = new Calculadora();

            PilhaResultados<decimal> pilhaResultados = new PilhaResultados<decimal>();

            
            while (filaOperacoes.Count > 0)
            {
                Operacoes operacao = filaOperacoes.Peek();
                calculadora.calcular(operacao);
                Console.WriteLine("{0} {1} {2} = {3}", operacao.valorA,operacao.operador,operacao.valorB, operacao.resultado);
                
                pilhaResultados.InserirValor(operacao.resultado);
                filaOperacoes.Dequeue();

                calculadora.mostrarListaOperacoes(filaOperacoes);
            }

            pilhaResultados.MostrarValores();
            pilhaResultados.LimparPilha();

        }
    }
}
