using System;
using System.Collections.Generic;

public class PilhaResultados<T>
{
    private Stack<T> pilhaResultado = new Stack<T>();

    public void InserirValor(T item)
    {
        pilhaResultado.Push(item);
    }

    public void LimparPilha()
    {
        Console.WriteLine("Limpando pilha.");
        while (pilhaResultado.Count > 0)
        {
            pilhaResultado.Pop();
        }
        Console.WriteLine("Pilha vazia.");
    }   

    public void MostrarValores()
    {
        List<T> listaPilha = new List<T>(pilhaResultado);
        listaPilha.Reverse();

        foreach (T item in listaPilha)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("\n");

    }

    public int Count
    {
        get { return pilhaResultado.Count; }
    }

}
