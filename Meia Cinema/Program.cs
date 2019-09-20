using System;

namespace Meia_Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, digite sua idade");
            int idade = int.Parse(Console.ReadLine());

            if (idade<18 || idade>=60){
                Console.WriteLine("Você paga MEIA");
            }else{
                Console.WriteLine("Você paga INTEIRA");
            }

        }
    }
}
