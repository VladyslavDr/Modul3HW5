using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Modul3HW5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var str = GetHelloWorld().GetAwaiter().GetResult();

            Console.WriteLine(str);
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
            var helloWorldList = new List<Task<string>>();

            helloWorldList.Add(GetHello());
            helloWorldList.Add(GetWorld());

            return string.Join(" ", await Task.WhenAll(helloWorldList));
        }
    }
}
