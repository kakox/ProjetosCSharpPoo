// Programa que faz leitura de dado de duas pessoas e verifica a mais velha
using System;
using System.Formats.Asn1;
using System.Globalization;
using Course;


namespace exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();


            Console.WriteLine("Digite o nome: ");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("=================================================");
            Console.WriteLine("Dados da primeira pessoa: ");

            Console.WriteLine("Nome: " + p1.Nome);
            Console.WriteLine("Idade: " + p1.Idade);
            Console.WriteLine("=================================================");

            Console.WriteLine("Digite o nome: ");
            p2.Nome = Console.ReadLine();

            Console.WriteLine("Digite a idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("=================================================");
            Console.WriteLine("Dados da segunda pessoa: ");

            Console.WriteLine("Nome: " + p2.Nome);
            Console.WriteLine("Idade: " + p2.Idade);
            Console.WriteLine("=================================================");

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + p1.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + p2.Nome);
            }


        }
    }
}