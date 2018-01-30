using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_CommandPrompt
{
    class Program
    {
        static void Main(string[] args)
        {
            var cmd = new cs_CommandPrompt("dir");
            cmd.Execute();

            System.Console.WriteLine(cmd.ExitCode);
            System.Console.WriteLine(cmd.StdOut);
        }
    }
}
