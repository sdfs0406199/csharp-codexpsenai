using System;

namespace cadastro_com__
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Insira seu E-Mail");
            string email = Console.ReadLine();

            int i = 0; 
            bool flag = false;

            while(i < email.Length){
                if(email[i] == '@'){
                    flag = true;
                }
                i++;
            }

            //alexjvm90@gmail.com

            if(flag == false){
                Console.WriteLine("E-Mail Invalido");
                
            }else{
                Console.WriteLine("E-Mail Válido");
            }

        }
    }
}
