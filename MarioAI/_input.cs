using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput.Native;
using WindowsInput;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace MarioAI
{
    class _input
    {

        /*
        InputSimulator inputsim = new InputSimulator();
        Process[] p64 = Process.GetProcessesByName("Project64");

        const uint WM_KEYDOWN = 0x100;
        const uint WM_KEYUP = 0x0101;

        const uint VK_RETURN = 0x0D;


       
        [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string lpClassName,string lpWindowName);

        [DllImport("user32.dll", EntryPoint = "FindWindowEx")]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

        [DllImport("User32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern IntPtr PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
        */

        Keyboard keyboard = new Keyboard();
        
        public void Start_key()
        {
            //When the key is press its flag is set to down so we need to set it back up and we also need to wait some time for the game to detect the input
            keyboard.Send(Keyboard.ScanCodeShort.RETURN);
            System.Threading.Thread.Sleep(100);
            keyboard.SendKeyUp(Keyboard.ScanCodeShort.RETURN);
         
        }
        public void X_key()
        {
            keyboard.Send(Keyboard.ScanCodeShort.KEY_X);
            System.Threading.Thread.Sleep(100);
            keyboard.SendKeyUp(Keyboard.ScanCodeShort.KEY_X);
        }
        public void UpArrow_key()
        {
            keyboard.Send(Keyboard.ScanCodeShort.KEY_P);
           // System.Threading.Thread.Sleep(100);
           // keyboard.SendKeyUp(Keyboard.ScanCodeShort.RETURN);
        }

    }
}






// IntPtr p64Handle = FindWindow("p64", "Project64");          

// SendMessage(p64[0].MainWindowHandle, WM_KEYDOWN, ((IntPtr)VK_RETURN), (IntPtr)0);
// IntPtr result3 = SendMessage(p64[0].MainWindowHandle, 0x0101, ((IntPtr)VK_RETURN), (IntPtr)0);
// Console.WriteLine(result3);
// inputsim.Keyboard.KeyDown(VirtualKeyCode.RETURN);
// inputsim.Keyboard.KeyUp(VirtualKeyCode.RETURN);

// inputsim.Keyboard.KeyDown(VirtualKeyCode.RETURN);
// inputsim.Keyboard.KeyUp(VirtualKeyCode.RETURN);
/*
PostMessage(p64[0].MainWindowHandle, WM_KEYDOWN, ((IntPtr)VK_RETURN), (IntPtr)15);
IntPtr test = PostMessage(p64[0].MainWindowHandle, WM_KEYDOWN, ((IntPtr)VK_RETURN), (IntPtr)0);
PostMessage(p64[0].MainWindowHandle, WM_KEYDOWN, ((IntPtr)VK_RETURN), (IntPtr)0);
Console.WriteLine("Key Pressed: " + test);
*/
