using System;

namespace operador_logico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App cálculo de Média e Faltas");

            Console.WriteLine("Bem vindo a Escola SENAI de Informática");

            Console.WriteLine("Digite a primeira nota");
            int nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota");
            int nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de faltas");
            int faltas = int.Parse(Console.ReadLine());

            double media = (nota1+nota2)/2;

            if(media>=50 && faltas<=30){
                //resultado verdadeiro
                Console.WriteLine("Parabéns você foi Aprovado");
            }else{
                //resultado falso
                Console.WriteLine("Parabéns você foi Reprovado");
            }
        }
    }
}
