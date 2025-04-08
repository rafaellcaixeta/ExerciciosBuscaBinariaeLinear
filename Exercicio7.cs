using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 3, 56, 4, 12, 34, 76, 43, 56, 3, 56, 4, 3, 22, 12, 34, 43};

        Console.WriteLine("Digite o número que deseja encontrar:");
        int valor = Convert.ToInt32(Console.ReadLine());

        int ultimaOcorrencia = BuscarUltimaOcorrencia(numeros, valor);

        if (ultimaOcorrencia != -1)
        {
            Console.WriteLine($"Última ocorrência do número {valor} está no índice {ultimaOcorrencia}.");
        }
        else
        {
            Console.WriteLine($"Número {valor} não encontrado no array.");
        }
    }

    static int BuscarUltimaOcorrencia(int[] array, int valor)
    {
        int indice = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == valor)
            {
                indice = i;
            }
        }

        return indice; 
    }
}
