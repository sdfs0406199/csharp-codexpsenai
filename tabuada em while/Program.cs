using System;

namespace tabuada_em_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número");
            int numero = int.Parse(Console.ReadLine());
            
            int contador = 0;

            while (contador <= 10){
                int resultado = numero * contador;
                Console.WriteLine($"o resultado de {numero}x{contador} é: {resultado}");
                contador++;
            }
        }
    }
}
