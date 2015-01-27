using System.IO;
using System;
class L2S08
{
	public static void MainX()
	{
		using (var writer=new StreamWriter("text.txt"))
		{
			writer.WriteLine ("Hello, world!");
			throw new Exception();
		}
	}
}

//!Блок using - более элегантное решение той же проблемы. Для демонстрации нужно запускать экзешник из шелла, т.к. студия прерывает выполнение программы на исключении.