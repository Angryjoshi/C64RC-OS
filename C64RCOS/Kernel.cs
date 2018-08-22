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
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("    **** COMMODORE 64 BASIC V2 ****    ");
            Console.WriteLine(" 64K RAM SYSTEM  38911 BASIC BYTES FREE");
            Console.WriteLine("READY.");
        }
        
        protected override void Run()
        {
            Console.Write("");
            var input = Console.ReadLine();
            
            if(input == "helloworld")
            {
                Console.WriteLine("Hello, World!");
            }

        }
    }
}
