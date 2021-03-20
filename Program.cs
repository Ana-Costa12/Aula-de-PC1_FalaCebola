using System;

namespace Aula_de_PC1_FalaCebola
{
    class Program
    {
        static void Main(string[] args)
        {
            string cebolatradutor;

            Console.Write("Escreva algo para o CebolaTradutor:\n ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            cebolatradutor = Console.ReadLine();
            Console.ResetColor();
            Console.Clear();

            Console.WriteLine("Tecle enter para ver sua tradução. ");
            Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"{cebolatradutor.Replace("rr","l").Replace("rR","l").Replace("RR","L").Replace("Rr","L").Replace("r","l").Replace("R","L")}");
            Console.ResetColor();
        }
    }
}
