﻿using System.IO;
using System;
using System.Text;
class L1S01
{
	public static void MainX()
	{
		Console.WriteLine(Directory.Exists("Temp"));
		Directory.CreateDirectory ("Temp");
		Console.WriteLine(Directory.Exists("Temp"));
		SuperConsole.Line ();
		
		File.WriteAllText("Temp/text","Hello, world!");
		
		var strings=new []  {"Line 1","Line 2","Line 3"};
		File.WriteAllLines ("Temp/strings", strings);
			
		var bytes=Encoding.UTF8.GetBytes ("Привет мир!");
		foreach(var e in bytes) Console.Write ((char)e);
		Console.WriteLine ();
		File.WriteAllBytes("Temp/bin", bytes);
		SuperConsole.Line ();
			
		var files=Directory.GetFiles("Temp");
		foreach(var file in files)
			Console.WriteLine (file);
		SuperConsole.Line();

		Console.WriteLine (File.ReadAllText ("Temp/text"));
		SuperConsole.Line();
		
		var lines=File.ReadLines ("Temp/text");
		foreach(var e in lines)
			Console.WriteLine (e);
		SuperConsole.Line();
		
		bytes=File.ReadAllBytes ("Temp/bin");
		foreach(var e in bytes) 
			Console.Write ((char)e);
		Console.WriteLine ();
		Console.WriteLine (Encoding.UTF8.GetString (bytes));
		
	}
}

//!Простейшая работа с файлами