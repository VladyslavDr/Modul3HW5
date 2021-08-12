using System;
using System.IO;
using System.Threading.Tasks;

namespace Modul3HW5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static async Task<string> GetHello()
        {
            return await File.ReadAllTextAsync(@"File\Hello.txt");
        }

        public static async Task<string> GetWorld()
        {
            return await File.ReadAllTextAsync(@"File\World.txt");
        }

        public static async Task<string> GetHelloWorld()
        {
            return await GetHello() + " " + await GetWorld();
        }

        public static async void Run()
        {
            Console.WriteLine(await GetHelloWorld());
        }
    }
}
