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
            
            //Example1

            var cmd = new cs_CommandPrompt("dir");
            cmd.Execute();
            

            //Example2
            /*
            var cmd = new cs_CommandPrompt();
            cmd.SetCommand("echo helloworld");
            cmd.Execute();
            */

            //Example3
            /*
            var cmd = new cs_CommandPrompt();
            cmd.Execute("echo hoge");
            */


            System.Console.WriteLine(cmd.ExitCode);
            System.Console.WriteLine(cmd.StdOut);
        }
    }
}
