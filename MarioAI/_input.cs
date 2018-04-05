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
        
        public void Start_keyPress()
        {
            //When the key is press its flag is set to down so we need to set it back up and we also need to wait some time for the game to detect the input
            keyboard.Send(Keyboard.ScanCodeShort.RETURN);
            System.Threading.Thread.Sleep(100);
            keyboard.SendKeyUp(Keyboard.ScanCodeShort.RETURN);
         
        }
        public void Start_keyDown()
        {         
            keyboard.Send(Keyboard.ScanCodeShort.RETURN);           
        }
        public void Start_keyUp()
        {          
            keyboard.SendKeyUp(Keyboard.ScanCodeShort.RETURN);
        }
        //======================================================

        //X key Binded to A button on project 64
        public void X_keyPress()
        {
            keyboard.Send(Keyboard.ScanCodeShort.KEY_X);
            System.Threading.Thread.Sleep(100);
            keyboard.SendKeyUp(Keyboard.ScanCodeShort.KEY_X);
        }
        public void X_keyDown()
        {
            keyboard.Send(Keyboard.ScanCodeShort.KEY_X);           
        }
        public void X_keyUp()
        {
            keyboard.SendKeyUp(Keyboard.ScanCodeShort.KEY_X);
        }
        //======================================================
       
        //C key Binded to B button on project 64
        public void C_keyPress()
        {
            keyboard.Send(Keyboard.ScanCodeShort.KEY_C);
            System.Threading.Thread.Sleep(100);
            keyboard.SendKeyUp(Keyboard.ScanCodeShort.KEY_C);
        }
        public void C_keyDown()
        {
            keyboard.Send(Keyboard.ScanCodeShort.KEY_C);
        }
        public void C_keyUp()
        {
            keyboard.SendKeyUp(Keyboard.ScanCodeShort.KEY_C);
        }
        //======================================================

        //I key Binded to UP button on project 64
        public void I_keyPress()
        {
            keyboard.Send(Keyboard.ScanCodeShort.KEY_I);
            System.Threading.Thread.Sleep(100);
            keyboard.SendKeyUp(Keyboard.ScanCodeShort.KEY_I);
        }
        public void I_keyDown()
        {
            keyboard.Send(Keyboard.ScanCodeShort.KEY_I);
        }
        public void I_keyUp()
        {
            keyboard.SendKeyUp(Keyboard.ScanCodeShort.KEY_I);
        }
        //======================================================


        //J key Binded to UP button on project 64
        public void J_keyPress()
        {
            keyboard.Send(Keyboard.ScanCodeShort.KEY_J);
            System.Threading.Thread.Sleep(100);
            keyboard.SendKeyUp(Keyboard.ScanCodeShort.KEY_J);
        }
        public void J_keyDown()
        {
            keyboard.Send(Keyboard.ScanCodeShort.KEY_J);
        }
        public void J_keyUp()
        {
            keyboard.SendKeyUp(Keyboard.ScanCodeShort.KEY_J);
        }
        //======================================================

        //K key Binded to UP button on project 64
        public void K_keyPress()
        {
            keyboard.Send(Keyboard.ScanCodeShort.KEY_K);
            System.Threading.Thread.Sleep(100);
            keyboard.SendKeyUp(Keyboard.ScanCodeShort.KEY_K);
        }
        public void K_keyDown()
        {
            keyboard.Send(Keyboard.ScanCodeShort.KEY_K);
        }
        public void K_keyUp()
        {
            keyboard.SendKeyUp(Keyboard.ScanCodeShort.KEY_K);
        }
        //======================================================

        //L key Binded to UP button on project 64
        public void L_keyPress()
        {
            keyboard.Send(Keyboard.ScanCodeShort.KEY_K);
            System.Threading.Thread.Sleep(100);
            keyboard.SendKeyUp(Keyboard.ScanCodeShort.KEY_K);
        }
        public void L_keyDown()
        {
            keyboard.Send(Keyboard.ScanCodeShort.KEY_K);
        }
        public void L_keyUp()
        {
            keyboard.SendKeyUp(Keyboard.ScanCodeShort.KEY_K);
        }
        //======================================================


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
