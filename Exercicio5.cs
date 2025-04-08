using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 34, 22, 12, 54, 40, 55, 33, 70, 73};

        Console.WriteLine("Digite o valor de X:");
        int x = Convert.ToInt32(Console.ReadLine());

        int multiplo = EncontrarMultiploDeX(numeros, x);

        if (multiplo != -1)
        {
            Console.WriteLine($"O primeiro número múltiplo de {x} é: {multiplo}");
        }
        else
        {
            Console.WriteLine($"Nenhum número múltiplo de {x} foi encontrado no array.");
        }
    }

    static int EncontrarMultiploDeX(int[] array, int x)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % x == 0)
            {
                return array[i];
            }
        }

        return -1; // Retorna -1 se não encontrar nenhum múltiplo
    }
}
