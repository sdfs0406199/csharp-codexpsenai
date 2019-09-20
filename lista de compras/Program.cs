using System;

namespace lista_de_compras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de compra");

            string[] lista = new string[6];
            
            int produto = 0;

            while(produto <6){
                Console.WriteLine($"Digite o {produto+1}º produto");
                lista[produto] = Console.ReadLine();
                produto++;
            }
            produto = 0;
            while(produto < 6){
                Console.WriteLine($"O nome na posição {produto+1} é {lista[produto]}");
                produto++;
            }
        }
    }
}
