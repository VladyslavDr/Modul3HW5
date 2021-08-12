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

        public static async Task<string> GetHelloWorld()
        {
            Func<string, Task<string>> reareadFromFile = async path => await File.ReadAllTextAsync(path);

            var helloWorldList = new List<Task<string>>();

            helloWorldList.Add(reareadFromFile(@"File\Hello.txt"));
            helloWorldList.Add(reareadFromFile(@"File\World.txt"));

            return string.Join(" ", await Task.WhenAll(helloWorldList));
        }
    }
}
