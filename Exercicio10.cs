using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um texto:");
        string texto = Console.ReadLine();

        Console.WriteLine("Digite a palavra que deseja buscar:");
        string palavra = Console.ReadLine();

        int posicao = BuscarPalavraNoTexto(texto, palavra);

        if (posicao != -1)
        {
            Console.WriteLine($"A palavra '{palavra}' foi encontrada na posição {posicao}.");
        }
        else
        {
            Console.WriteLine("Palavra não encontrada no texto.");
        }
    }

    static int BuscarPalavraNoTexto(string texto, string palavra)
    {
        return texto.IndexOf(palavra, StringComparison.OrdinalIgnoreCase);
    }
}
