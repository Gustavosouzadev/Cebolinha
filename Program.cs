using System;

namespace Cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Beep();

            string texto = "Escreva alguma frase para"; 
            string texto2 = "o Cebolinha reproduzir";
            string padrao;

            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("_______________________________");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"+| {texto} |+");
            Console.WriteLine($"   | {texto2} |");

            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("|_____________________________|");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Sua Frase: ");

            Console.ForegroundColor = ConsoleColor.White;
            padrao = Console.ReadLine();
            
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("-Cebolinha: ");

            Console.ResetColor();

            Console.Write($"{padrao.Replace("RR", "L").Replace("rr", "l").Replace("Rr", "L").Replace("rR", "l")}");

            Console.Beep();
        }
    }
}
