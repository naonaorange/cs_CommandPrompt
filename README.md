# cs_CommandPrompt
You can execute command prompt using C#

# Repository Comstructure

- cs_CommandPrompt.cs : program to use command prompt

- cs_CommandPrompt.sln : sample project(VS 2015) using this program


# Useage
Please add cs_CommandPrompt.cs in your project.

If you use this program, write following code as example.
```cs
include cs_CommandPrompt

var cmd = new cs_CommandPrompt("dir"); //Input program in arg.
cmd.Execute();

System.Console.WriteLine(cmd.ExitCode);
System.Console.WriteLine(cmd.StdOut);
```