﻿using System;

namespace PrimeiroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aqui é onde iremos inserir o código

            Console.WriteLine("Soma de dois números");

            int n1, n2;

            Console.WriteLine("Digite o primeiro númemro");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            n2 = int.Parse(Console.ReadLine());

            int resultado = n1 + n2;

            Console.WriteLine($"O resultado é: {resultado}");

        }
    }
}
