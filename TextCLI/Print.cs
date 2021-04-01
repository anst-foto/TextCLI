using System;

namespace TextCLI
{
    public static class Print
    {
        public static void Info(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"{DateTime.Now:u} [ERROR] : {message}");
            Console.ResetColor();
        }
        
        
    }
}
