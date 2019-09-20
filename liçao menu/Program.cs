using System;

namespace liçao_menu
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("Digite o primeiro número");
            float x = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            float y = float.Parse(Console.ReadLine());

            Console.WriteLine("------------------");
            Console.WriteLine("( a ) - Soma de 2 números");
            Console.WriteLine("( b ) - Subtração do Primeiro pelo Segundo");
            Console.WriteLine("( c ) - Subtração do Segundo pelo Primeiro");
            Console.WriteLine("( d ) - Multiplicação dos dois números");
            Console.WriteLine("( e ) - Divisão do primeiro pelo segundo");
            Console.WriteLine("( f ) - Divisão do segundo pelo primeiro");
            Console.WriteLine("-------------------");

            string letras = Console.ReadLine();
            float resultado;
            
            if ( letras == "e" || letras == "f" ){
                if ( x == 0  || y == 0 ){
                    Console.WriteLine("Número igual a 0 nao é divisivel");
                    return;
                }
            }
            
            switch(letras){
                case "a":
                    resultado = x + y;
                    Console.WriteLine($"O resultado é {resultado}");
                break;

                case "b":
                    resultado = x - y;
                    Console.WriteLine($"O resultado é {resultado}");
                break;

                case "c":
                    resultado = y - x;
                    Console.WriteLine($"O resultado é {resultado}");
                break;

                case "d":
                    resultado = x * y;
                    Console.WriteLine($"O resultado é {resultado}");
                break;

                case "e":
                    resultado = x / y;
                    Console.WriteLine($"O resultado é {resultado}");
                break;

                case "f":
                    resultado = y / x;
                    Console.WriteLine($"O resultado é {resultado}");
                break;
            }
        }
    }
}
