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
            keyboard.Send(Keyboard.ScanCodeShort.KEY_L);
            System.Threading.Thread.Sleep(100);
            keyboard.SendKeyUp(Keyboard.ScanCodeShort.KEY_L);
        }
        public void L_keyDown()
        {
            keyboard.Send(Keyboard.ScanCodeShort.KEY_L);
        }
        public void L_keyUp()
        {
            keyboard.SendKeyUp(Keyboard.ScanCodeShort.KEY_L);
        }
        //======================================================


    }
}
