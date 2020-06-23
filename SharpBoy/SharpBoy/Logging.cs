using System;
using System.Collections.Generic;
using System.Text;

namespace SharpBoy.Core
{
    public enum Severity
    {
        Information,
        Warning,
        Error
    }

    public static class Logging
    {
        public static void Log(string text, Severity severity)
        {
            ChangeColor(severity);
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void ChangeColor(Severity severity)
        {
            switch(severity)
            {
                case Severity.Warning:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case Severity.Information:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case Severity.Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
            }
        }

    }
}
