using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 3, 5, 77, 32, 13, 2, 44 };

        int numeroPar = BuscarPrimeiroPar(numeros);

        if (numeroPar != -1)
        {
            Console.WriteLine($"O primeiro número par encontrado é: {numeroPar}");
        }
        else
        {
            Console.WriteLine("Nenhum número par foi encontrado no array.");
        }
    }

    static int BuscarPrimeiroPar(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                return array[i];
            }
        }

        return -1; 
    }
}
