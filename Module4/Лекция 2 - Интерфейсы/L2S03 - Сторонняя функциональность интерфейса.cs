using System;
namespace L2S03
{
	public interface IPrintable
	{
		void Print();	
		ConsoleColor Color { get; }
	}
	
	public class Person : IPrintable
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public void Print()
		{
			Console.WriteLine("{0} ({1} y.o)",Name,Age);
		}
		public ConsoleColor Color { get { return ConsoleColor.Red; } }
	}
	
	class Program
	{
		static void PrintWithColor(IPrintable prn)
		{
			Console.ForegroundColor=prn.Color;
			prn.Print ();
		}
		
		public static void MainX()
		{
			PrintWithColor (new Person{ Name="Smith", Age=20 });		
		}
	}
}

//! Хранение свойств в интерфейсе (ведь свойство - это метод!)
