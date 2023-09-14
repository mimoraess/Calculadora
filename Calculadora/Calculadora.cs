using System;
using System.Collections;
using System.Collections.Generic;

namespace Calculadora
{
    public class Calculadora
    {
        
        public Operacoes calcular(Operacoes operacao)
        {
            switch(operacao.operador)
            {
                case '+': operacao.resultado = soma(operacao);break;
                case '-': operacao.resultado = subtracao(operacao);break;
                case '*': operacao.resultado = multiplicacao(operacao);break;
                case '/': operacao.resultado = divisao(operacao);break;
                default: operacao.resultado = 0; break;
            }
            return operacao;
        }
        public long soma(Operacoes operacao)
        {
            return operacao.valorA + operacao.valorB;
        }
        public long subtracao(Operacoes operacao)
        {
            return operacao.valorA - operacao.valorB;
        }
        public long multiplicacao(Operacoes operacao)
        {
            return operacao.valorA * operacao.valorB;
        }
        public decimal divisao(Operacoes operacao)
        {
            try
            {
                return operacao.valorA / operacao.valorB;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Erro: Tentativa de divisão por zero.");
                return 0;
            }
        }

        public void mostrarListaOperacoes(Queue<Operacoes> filaOperacoes) 
        {
            

            bool res = estaVazia(filaOperacoes.Count);
            if (res == false) 
            {
                Console.WriteLine("Próximas operações:");
                foreach (Operacoes operacao in filaOperacoes)
                {
                    Console.WriteLine($"Valor A: {operacao.valorA}, Valor B: {operacao.valorB}, Operação: {operacao.operador}");
                }
                Console.WriteLine("\n"); 
            }
        }

        const int zerado = 0;
        private bool estaVazia(int filaOperacoes)
        {
            if (filaOperacoes == zerado) 
            {
                Console.WriteLine("Não há próxima operação\n");
                return true;
            }
            
            return false;
        }
       
    }
}
