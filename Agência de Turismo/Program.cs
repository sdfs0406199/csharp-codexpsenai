using System;

namespace Agência_de_Turismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Agência de Turismo");
            string[] nome = new string[5];
            string[] origem = new string[5];
            string[] destino = new string[5];
            DateTime[] data = new DateTime[5];

            int opcao = 0, i = 0;
            int j = 0;

            do{
                Console.WriteLine("Selecione uma opção");
                Console.WriteLine("1 - Cadastrar Passagem");
                Console.WriteLine("2 - Listar Passagens");
                Console.WriteLine("0 - Sair");
                opcao = int.Parse(Console.ReadLine());
            
            switch(opcao){
                case 1:
                    Console.WriteLine("Vamos Cadastrar Agora");
                    string resposta;
                    do{
                        if(i <= 2){
                            Console.WriteLine("Digite o nome do passageiro");
                            nome[i] = Console.ReadLine();

                            Console.WriteLine("Digite a Origem");
                            origem[i] = Console.ReadLine();

                            Console.WriteLine("Digite o Destino");
                            destino[i] = Console.ReadLine();

                            Console.WriteLine("Digite a Data do Vôo");
                            data[i] = DateTime.Parse(Console.ReadLine());

                            Console.WriteLine("Você deseja cadastrar mais um? S/N");
                            resposta = Console.ReadLine();
                        }else{
                            Console.WriteLine("Número de passagens Excedida");
                            break;
                        }
                         i++;
                    } while(resposta == "S");

                break;

                case 2:
                    Console.WriteLine("Listando as Passagens");
                    while (j < 2){
                        Console.WriteLine($"Passageiro nome: {nome[j]}, origem: {origem[j]}");
                        j++;
                    }
                break;
                case 0:
                break;
                default:
                    Console.WriteLine("Opçâo Inválida");
                break;
            }//fim switch

            }while (opcao != 0);

                Console.WriteLine("Obrigado por usar nossso sistema");
        }
    }
}
