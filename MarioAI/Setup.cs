using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioAI
{
    class Setup
    {
        static void Main(string[] args)
        {
            Setup setup = new Setup();
            setup.run();
        }

        public void run()
        {
            StartProcess proc = new StartProcess();
            proc.start();
        }
    }
}
