using System;
using System;
class Program
{
    static void Main()
    {
        string[] nomes = { "Rafael", "Bruno", "Maria Rita", "Matheus", "Vinicius", "Filipe", "Arthur" };

        Console.WriteLine("Digite o nome que você quer buscar (Lembre-se: a primeira letra deve ser maiuscula):");
        string nomeProcurado = Console.ReadLine();

        int indice = BuscarNome(nomes, nomeProcurado);

        if (indice != -1)
        {
            Console.WriteLine($"Nome '{nomeProcurado}' encontrado no índice {indice}.");
        }
        else
        {
            Console.WriteLine($"Nome '{nomeProcurado}' não encontrado na lista.");
        }
    }

    static int BuscarNome(string[] array, string nome)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Equals(nome))
            {
                return i;
            }
        }

        return -1;
    }
}
