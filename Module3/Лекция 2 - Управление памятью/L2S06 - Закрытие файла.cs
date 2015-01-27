using System;
using System.IO;

class L2S06
{
	public static void MainX()
	{
		var writer=new StreamWriter("temp.txt");
		writer.WriteLine("Hello, world!");
		throw new Exception("");
		writer.Close ();
	}
}
		 
//!Если перед закрытием файла вылетело исключение - будет то же самое