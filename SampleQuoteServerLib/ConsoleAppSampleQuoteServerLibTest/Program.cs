using SampleQuoteServerLib;
using static System.Console;

namespace ConsoleAppSampleQuoteServerLibTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string QUOTESFILE = "quotes.txt";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, QUOTESFILE);
            WriteLine($"FilePath: {filePath}");
            Console.WriteLine("Hello, World!");
            var qs = new QuoteServer(filePath, 5678);
            qs.Start();
            WriteLine("Press return to exit");
            ReadLine();
            qs.Stop();
        }
    }
}
