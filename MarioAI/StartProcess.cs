using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioAI
{
    class StartProcess
    {
        public void start()
        {
           // try
           // {
                Console.WriteLine("Starting Project64.");
                var proc = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        UseShellExecute = false,
                        RedirectStandardInput = true,
                        RedirectStandardOutput = true,
                        CreateNoWindow = false
                    }
                };
                proc.Start();
                proc.StandardInput.WriteLine("cd C:/Users/justi/Desktop/Class files repo/Class-files-repo/C463 AI/Mario64AI/Project64 2.3");
                proc.StandardInput.WriteLine("Project64.exe"); 
            //  }catch(Exception e)
            //  {
            //      Console.WriteLine("Couldn't start Project64, check that filepaths are correct.");
            //  }
            Console.WriteLine("Process Started.");
        }
    }
}
