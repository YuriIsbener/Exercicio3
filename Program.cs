using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double salario;
            double aumentoSalario;
            double novoSalario;

            Console.WriteLine("Qual seu salario?");
            salario = double.Parse(Console.ReadLine());

            aumentoSalario = salario*0.3;
            novoSalario = salario+aumentoSalario;
            
            if (salario>500)
            {
                Console.WriteLine("Tenha um bom dia.");
            }else
            {
                Console.WriteLine("Parabéns... você ira receber um aumento de 30% sobre seu salario atual");
                Console.WriteLine("Seu novo salario será: "+novoSalario);
        
            }

        }
    }
}
