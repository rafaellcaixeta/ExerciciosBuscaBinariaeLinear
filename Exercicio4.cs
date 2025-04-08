using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escreva quantos números inteiros desejar:");
        int[] numeros = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int maior = EncontrarMaior(numeros);
        int menor = EncontrarMenor(numeros);

        Console.WriteLine($"O maior número encontrado é: {maior}");
        Console.WriteLine($"O menor número encontrado é: {menor}");
    }

    static int EncontrarMaior(int[] array)
    {
        int maior = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > maior)
            {
                maior = array[i];
            }
        }

        return maior;
    }

    static int EncontrarMenor(int[] array)
    {
        int menor = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < menor)
            {
                menor = array[i];
            }
        }

        return menor;
    }
}
