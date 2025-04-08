using System;

namespace MyApp
{
    internal class Program
    {
        static int BuscaLinear(int[] array, int elemento)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == elemento)
                {
                    return i;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int[] numeros = { 20, 33, 54, 60, 89, 93, 100 };
            
            Console.WriteLine("Qual número você deseja encontrar no array?");
            int chave = Convert.ToInt32(Console.ReadLine());
           
            int resultado = BuscaLinear(numeros, chave);
            Console.WriteLine(resultado != -1 ? $"Elemento {chave} encontrado na posição {resultado}." : $"Elemento {chave} não encontrado no array.");
        }
    }
}