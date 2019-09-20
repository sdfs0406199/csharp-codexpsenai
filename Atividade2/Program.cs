using System;

namespace Atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu ano de nascimento");
            int nascimento = int.Parse(Console.ReadLine());
            

            int anoAtual = DateTime.Now.Year;

            int idade = anoAtual - nascimento;

            int semanas = idade * 52;

            Console.WriteLine($"Sua idade é {idade} isso convertido em semanas é igual a {semanas} semanas");

             
        }
    }
}
