using System;
using System.IO;
using System.Threading.Tasks;

namespace Modul3HW5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(GetHelloWorld().Result);
        }

        public static async Task<string> GetHello()
        {
            return await Task.Run(async () =>
            {
                return await File.ReadAllTextAsync(@"File\Hello.txt");
            });
        }

        public static async Task<string> GetWorld()
        {
            return await Task.Run(async () =>
            {
                return await File.ReadAllTextAsync(@"File\World.txt");
            });
        }

        public static async Task<string> GetHelloWorld()
        {
            return await Task.Run(() =>
            {
                return GetHello().Result + " " + GetWorld().Result;
            });
        }
    }
}
