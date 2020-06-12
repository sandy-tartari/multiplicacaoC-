using System;

namespace multiplicacao
{
    class Program
    {
        static void Main(string[] args)
        {
            // Algorirmo para multiplicar dois números
            int n1, n2, multiplicacao;
            Console.WriteLine("Escreva um número (e tecle ENTER)");
            n1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Escreva umm número (e tecle ENTER)");
            n2 = int.Parse(Console.ReadLine());
            
            multiplicacao = n1 * n2; 
            
            Console.WriteLine("O resultado é {0}.", multiplicacao);
        }
    }
}
