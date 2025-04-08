using System;

class Aluno
{
    public string Nome { get; set; }
    public int Matricula { get; set; }
}

class Program
{
    static void Main()
    {
        // Lista de alunos
        Aluno[] alunos = new Aluno[]
        {
            new Aluno { Nome = "Rafael", Matricula = 1 },
            new Aluno { Nome = "Bruno", Matricula = 2 },
            new Aluno { Nome = "Pedro", Matricula = 3 },
            new Aluno { Nome = "Laura", Matricula = 4 },
            new Aluno { Nome = "Matheus", Matricula = 5 },
            new Aluno { Nome = "Gabriel", Matricula = 6 },
        };

        Console.WriteLine("Digite a matrícula do aluno que deseja encontrar (1 a 6):");
        int matriculaProcurada = Convert.ToInt32(Console.ReadLine());

        Aluno alunoEncontrado = BuscarAlunoPorMatricula(alunos, matriculaProcurada);

        if (alunoEncontrado != null)
        {
            Console.WriteLine($"Aluno encontrado: {alunoEncontrado.Nome} (Matrícula: {alunoEncontrado.Matricula})");
        }
        else
        {
            Console.WriteLine("Aluno não encontrado.");
        }
    }

    static Aluno BuscarAlunoPorMatricula(Aluno[] lista, int matricula)
    {
        for (int i = 0; i < lista.Length; i++)
        {
            if (lista[i].Matricula == matricula)
            {
                return lista[i];
            }
        }

        return null; // Retorna null se não encontrar
    }
}
