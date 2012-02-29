using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new IronJS.Hosting.CSharp.Context();

            Console.WriteLine("Type a JS expression below and press enter. (Blank line to quit.)");

            Console.Write("js-console> ");
            string command = Console.ReadLine();

            while (command != "" && command != "exit")
            {
                Console.WriteLine(context.Execute(command));
                Console.Write("js-console> ");
                command = Console.ReadLine();
            }
        }
    }
}
