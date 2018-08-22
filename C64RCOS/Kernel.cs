using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace C64RCOS
{
    public class Kernel: Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("    **** COMMODORE 64 BASIC V2 ****    ");
            Console.WriteLine("64K RAM SYSTEM  38911 BASIC BYTES FREE");
            Console.WriteLine("READY.");
        }
        
        protected override void Run()
        {
            Console.Write("");
            var input = Console.ReadLine();

            if (input == "helloworld")
            {
                Console.WriteLine("Hello, World!");
            }
            else if (input.StartsWith("print"))
            {
                try
                {
                    Console.WriteLine(input.Remove(0, 5));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else if (input == "reboot")
            {
                Sys.Power.Reboot();
            }
            else if (input == "clear")
            {
                Console.Clear();
            }
            else if (input == "listcmds")
            {
                Console.WriteLine("----Commands----");
                Console.WriteLine("helloworld - displays Hello, World!");
                Console.WriteLine("print - prints the text that follows after a space");
                Console.WriteLine("reboot - restarts the computer");
                Console.WriteLine("clear - clear the screen of text");
                Console.WriteLine("----Commands----");
            }
            else
            {
                Console.WriteLine("?Syntax Error.");
            }
        }
    }
}
