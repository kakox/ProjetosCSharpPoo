using System;
using System.Globalization;
using NotasAluno;


class Program
{
    static void Main(string[] args)
    {
       Aluno a = new Aluno();

        Console.WriteLine("Nome do Aluno: ");
        a.Nome = Console.ReadLine();

        Console.WriteLine("Digite as três notas do aluno: ");
        a.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        a.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        a.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("NOTA FINAL = " +a.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

        if (a.EstaAprovado())
        {
            Console.WriteLine("APROVADO");
        }
        else
        {
            Console.WriteLine("REPROVADO");
            Console.WriteLine("FALTARAM " + a.PontosFaltando().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
        }


    }
}
