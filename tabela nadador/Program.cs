﻿using System;

namespace tabela_nadador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a idade do nadador : ");
            int idade = int.Parse (Console.ReadLine());

            if (idade <= 7){
                Console.WriteLine("Infantil A");
            }else if(idade >= 8 && idade <= 10){
                Console.WriteLine("Infantil B");
            }else if(idade >=11 && idade <=13){
                Console.WriteLine("Infantil A");
            }else if(idade >=14 && idade <=17){
                Console.WriteLine("Infantil B");
            }
            else{
                Console.WriteLine("Adulto");
            }
    
        }
    }
}
