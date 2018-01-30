using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_CommandPrompt
{
    class cs_CommandPrompt
    {
        private System.Diagnostics.Process process;

        public string StdOut { get; private set; }
        public int ExitCode { get; private set; }

        public bool IsWaitForExit { get; set; }

        public cs_CommandPrompt()
        {
            process = new Process();

            process.StartInfo.FileName = "cmd";
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
        }

        public cs_CommandPrompt(string cmd): this()
        {
            SetCommand(cmd);
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

        public void Execute(string cmd)
        {
            SetCommand(cmd);
            Execute();
        }

        public void SetCommand(string cmd)
        {
            process.StartInfo.Arguments = "/C " + cmd;
        }
    }
}
