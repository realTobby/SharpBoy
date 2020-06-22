using System;

namespace SharpBoy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            GameBoyWindow gbw = new GameBoyWindow();
            gbw.Start();
        }
    }
}
