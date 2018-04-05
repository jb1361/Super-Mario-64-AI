using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioAI
{
    class StartProcess
    {
        public void start()
        {
            Console.WriteLine("Starting Project64.");
            string path = Directory.GetCurrentDirectory();
            string newPath = Path.GetFullPath(Path.Combine(path, @"..\..\..\Project64 2.3\"));
            var proc = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                       // FileName = newPath + "Project64.exe",
                        UseShellExecute = false,
                        RedirectStandardInput = true,
                        RedirectStandardOutput = false,
                        CreateNoWindow = false
                    }
                };
            //string path = Directory.GetCurrentDirectory();
           // string newPath = Path.GetFullPath(Path.Combine(path, @"..\..\..\Project64 2.3\"));
            Console.WriteLine(newPath);
            proc.Start();
            proc.StandardInput.WriteLine("cd " + newPath);
            proc.StandardInput.WriteLine("Project64.exe");       
            Console.WriteLine("Process Started.");
            
        }
    }
}
