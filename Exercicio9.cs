using System;

class Program
{
    static void Main()
    {
        int[] numerosOriginais = {2, 12, 43, 54, 32, 25, 53, 65, 52, 4};

        Console.WriteLine("Digite o número que deseja buscar:");
        int valorProcurado = Convert.ToInt32(Console.ReadLine());

        int indice = BuscaComSentinela(numerosOriginais, valorProcurado, 0);

        if (indice != -1)
        {
            Console.WriteLine($"Valor {valorProcurado} encontrado no índice {indice}.");
        }
        else
        {
            Console.WriteLine("Valor não encontrado.");
        }
    }

    static int BuscaComSentinela(int[] arrayOriginal, int valor, int v)
    {
        int[] array = new int[arrayOriginal.Length + 1];

        for (int i = v; i < arrayOriginal.Length; i++)
        {
            array[i] = arrayOriginal[i];
        }

        array[arrayOriginal.Length] = valor;

        int i = 0;

        while (array[i] != valor)
        {
            i++;
        }

        if (i < arrayOriginal.Length)
        {
            return i;
        }
        else
        {
            return -1;
        }
    }
}
