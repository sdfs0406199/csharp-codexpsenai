using System;

namespace Atividade1
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.WriteLine("Digite sua Idade");
            idade = int.Parse(Console.ReadLine());

            int idadeMeses = idade * 12;
            int idadeDias = idade * 365;
            int idadeHoras = idade * 8760;
            int idadeMinutos = idade * 525600;

            Console.WriteLine($"A idade é {idade} anos, em Meses {idadeMeses}, em dias {idadeDias}, em horas {idadeHoras}, em minutos {idadeMinutos}");
        }
    }
}
