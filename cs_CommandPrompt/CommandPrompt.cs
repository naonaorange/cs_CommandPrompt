using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPromptUtil
{
    class CommandPrompt
    {
        private System.Diagnostics.Process process;

        public string StdOut { get; private set; }
        public int ExitCode { get; private set; }

        public bool IsWaitForExit { get; set; }

        public CommandPrompt(string arg)
        {
            process = new Process();

            process.StartInfo.FileName = "cmd";
            process.StartInfo.Arguments = "/C " + arg;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
        }

        public void Execute()
        {
            process.Start();
            if (IsWaitForExit)
            {
                process.WaitForExit();
                ExitCode = process.ExitCode;
            }
            StdOut = process.StandardOutput.ReadToEnd();
        }
    }
}
