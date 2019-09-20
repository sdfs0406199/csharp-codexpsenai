using System;

namespace alex_é_raivoso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite seu salário: R$");
            double salario = double.Parse(Console.ReadLine());

            
            Console.WriteLine("------------------");
            Console.WriteLine("( 1 ) - Escriturário");
            Console.WriteLine("( 2 ) - Secretário");
            Console.WriteLine("( 3 ) - Caixa");
            Console.WriteLine("( 4 ) - Gerente");
            Console.WriteLine("( 5 ) - Diretor");
            Console.WriteLine("-------------------");

            Console.Write("Digite seu código: ");
            int codigo = int.Parse(Console.ReadLine());
            double aumento;


            switch(codigo){
                    case 1:
                        Console.WriteLine($"Nome: {nome}");
                        Console.WriteLine($"Salário: {salario}");
                        Console.WriteLine($"Código: {codigo}");
                        Console.WriteLine("Cargo Escriturário");
                        Console.WriteLine("Percentual de aumento de 50%");
                        aumento = 0.5 * salario;
                        salario = salario + aumento;
                        Console.WriteLine($"O salário com aumento é: {salario}");
                    break;

                    case 2:
                        Console.WriteLine($"Nome: {nome}");
                        Console.WriteLine($"Salário: {salario}");
                        Console.WriteLine($"Código: {codigo}");
                        Console.WriteLine("Cargo Secretário");
                        Console.WriteLine("Percentual de aumento de 35%");
                        aumento = 0.35 * salario;
                        salario = salario + aumento;
                        Console.WriteLine($"O salário com aumento é: {salario}");
                    break;

                    case 3:
                        Console.WriteLine($"Nome: {nome}");
                        Console.WriteLine($"Salário: {salario}");
                        Console.WriteLine($"Código: {codigo}");
                        Console.WriteLine("Cargo Caixa");
                        Console.WriteLine("Percentual de aumento de 20%");
                        aumento = 0.2 * salario;
                        salario = salario + aumento;
                        Console.WriteLine($"O salário com aumento é: {salario}");
                    break;

                    case 4:
                        Console.WriteLine($"Nome: {nome}");
                        Console.WriteLine($"Salário: {salario}");
                        Console.WriteLine($"Código: {codigo}");
                        Console.WriteLine("Cargo Caixa");
                        Console.WriteLine("Percentual de aumento de 10%");
                        aumento = 0.1 * salario;
                        salario = salario + aumento;
                        Console.WriteLine($"O salário com aumento é: {salario}");
                    break;

                    case 5:
                        Console.WriteLine($"Nome: {nome}");
                        Console.WriteLine($"Salário: {salario}");
                        Console.WriteLine($"Código: {codigo}");
                        Console.WriteLine("Cargo Diretor");
                        Console.WriteLine("Não tem aumento");
                    break;

                    default:
                        Console.WriteLine("Digite um valor entre 1 e 5");
                    break;
            }
            

        }
    }
}
