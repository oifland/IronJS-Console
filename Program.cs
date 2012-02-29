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
                try
                {
                    Console.WriteLine(context.Execute(command));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Oops. Got an error: \n" + ex.Message);
                }
                Console.Write("js-console> ");
                command = Console.ReadLine();
            }
        }
    }
}
