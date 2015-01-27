using System;
using System.IO;

class L2S05
{
	public static void MainX()
	{
		var writer=new StreamWriter("temp.txt");
		writer.WriteLine("Hello, world!");
		//writer.Close (); 
	}
}
//!Если забыли закрыть файл, то он останется пустым, поскольку сброс буфера происходит только в момент закрытия