using System;

namespace Cálculo_de_Média
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Média de notas");

        int n1, n2, n3;

        Console.WriteLine("Digite a primeira nota");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a segunda nota");
        n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a tercecira nota");
        n3 = int.Parse(Console.ReadLine());

        float resultado = (float) (n1 + n2 + n3) / 3;
        Console.WriteLine($"Sua média é {resultado}");

        }
    }
}
