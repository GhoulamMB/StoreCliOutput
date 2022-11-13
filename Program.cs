using CliWrap;
using CliWrap.Buffered;
using System.Diagnostics;



//Method 1 : using CLI Wrap lib
var result = await Cli.Wrap("powershell.exe").
    WithArguments("-file C:\\Users\\okbb\\Desktop\\test.ps1").
    ExecuteBufferedAsync();

string outresult = result.StandardOutput.ToString();
Console.WriteLine("Method 1 : using CLI Wrap lib");
Console.WriteLine(outresult);


//Method 2 : usig the built-in Process class

Process p = new Process();
ProcessStartInfo startInfo = new ProcessStartInfo();
startInfo.FileName = "powershell.exe";
startInfo.Arguments = "-file C:\\Users\\okbb\\Desktop\\test.ps1";
p.StartInfo = startInfo;
p.StartInfo.RedirectStandardOutput = true;
p.Start();
string output = p.StandardOutput.ReadToEnd();
Console.WriteLine("Method 2 : usig the built-in Process class");
Console.WriteLine(output);
