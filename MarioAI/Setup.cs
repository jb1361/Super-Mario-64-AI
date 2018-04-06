using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarioAI
{
    class Setup
    {
        static void Main(string[] args)
        {
            Setup setup = new Setup();
            Console.WriteLine("Starting Thread.");
            Thread myThread = new System.Threading.Thread(new
            System.Threading.ThreadStart(setup.run));
            myThread.Start();
        }

        public void run()
        {
            StartProcess proc = new StartProcess();
            proc.start();
            System.Threading.Thread.Sleep(12000);

            //Input to get started in the game
            _input Input = new _input();
            Console.WriteLine("Enter key pressed");
            Input.Start_keyPress();
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Enter key pressed");
            Input.Start_keyPress();
                  
        }

        

    }
}
