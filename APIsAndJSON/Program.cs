using Newtonsoft.Json.Linq;
using System;

namespace APIsAndJSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();

            var ronVSKanye = new RonVSKanyeAPI(client);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Kanye: {ronVSKanye.KayneQuote()}");
                Console.WriteLine();
                Thread.Sleep(500);
                Console.WriteLine($"Ron: {ronVSKanye.RonQuote()}");
                Console.WriteLine();
                Thread.Sleep(500);
            }
        }
    }
}