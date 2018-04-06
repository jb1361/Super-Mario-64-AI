using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using WindowsInput.Native;
//using WindowsInput;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace MarioAI
{
    class _input
    {
        Keyboard keyboard = new Keyboard();
        
        public void Start_keyPress()
        {
            //When the key is press its flag is set to down so we need to set it back up and we also need to wait some time for the game to detect the input
            keyboard.Send(Keyboard.ScanCodeShort.RETURN);
            System.Threading.Thread.Sleep(100);
            keyboard.SendKeyUp(Keyboard.ScanCodeShort.RETURN);
         
        }
    }
}
