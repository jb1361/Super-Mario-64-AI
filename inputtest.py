from ctypes import*
import time 
lib = cdll.LoadLibrary("KeyboardInput.dll")
#a = lib.test(1)
i = 0

while i < 15:
	lib.KeyDown(45)
	time.sleep(0.1)
	lib.KeyUp(45)
	time.sleep(0.1)
	i = i +1