using System;

namespace rodizio_veicular
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o ultimo número da placa");
            int placa = int.Parse(Console.ReadLine());

            if (placa == 0 || placa == 1){
                Console.WriteLine("Segunda-Feira");
            }else if (placa == 2 || placa == 3){
                Console.WriteLine("Terça-Feira");
            }else if (placa == 4 || placa == 5){
                Console.WriteLine("Quarta-Feira");
            }else if (placa == 6 || placa == 7){
                Console.WriteLine("Quinta-Feira");
            }else if(placa == 8 || placa == 9){
                Console.WriteLine("Sexta-Feira");
            }
            
        }
    }
}
