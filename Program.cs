class Program
{
    static void Main()
    {
        int[] numeros = { 4, 7, 12, 34, 12, 56, 43, 12, 7, 88, 23 };
        
        Console.WriteLine("Qual número você deseja encontrar no array?");
        int valorProcurado = Convert.ToInt32(Console.ReadLine());

        int ocorrencias = ContarOcorrencias(numeros, valorProcurado);

        Console.WriteLine($"O valor {valorProcurado} aparece {ocorrencias} vez(es) no array.");
    }

    static int ContarOcorrencias(int[] array, int valor)
    {
        int contador = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == valor)
            {
                contador++;
            }
        }

        return contador;
    }
}
