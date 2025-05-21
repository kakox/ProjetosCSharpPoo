using System;
using System.Globalization;
using DadosFuncionario;

class Program
{
    static void Main(string[] args)
    {
        Funcionario f1 = new Funcionario();

        Console.WriteLine("Digite o nome do funcionario: ");
        f1.Nome = Console.ReadLine();

        Console.WriteLine("Digite o Salario Bruto do funcionario: ");
        f1.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Digite o Imposto:");
        f1.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine(f1);

        Console.WriteLine("Digite a porcentagem para aumentar o salario: ");
        double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        f1.AumentarSalario(porcentagem);

        Console.WriteLine("Dados atualizados: " +f1);

    }
}
