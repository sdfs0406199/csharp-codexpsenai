using System;

namespace Media_escolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Média Escolar");
            
            Console.WriteLine("Digite o seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a primeira nota: ");
            string valorDigitado = Console.ReadLine();
            float nota1 = float.Parse(valorDigitado);

            Console.WriteLine("Digite a segunda nota: ");
            float nota2 = float.Parse(Console.ReadLine());

            float media = (nota1+nota2)/2;
            string resultado;
            if(media>=7){
                resultado = "Aprovado";
            }else{
                resultado ="Reprovado";
            }
            Console.WriteLine($"O aluno {nome} com a média {media} está {resultado}");
        }
    }
}
