using System.Collections.Generic;
using System;
namespace L4S08
{
	public class PhoneBook
	{
		List<string> names=new List<string>(); //!Используется генерик
		List<string> phones=new List<string>();
		public void Add(string name, string phone)
		{
			names.Add (name);
			phones.Add (phone);
		}
		public string this[string name]
		{
			get
			{
				var index=names.IndexOf(name);
				if (index==-1) throw new ArgumentException();
				return phones[index];
			}
		}
	}
	
	class Program
	{
		public static void Main()
		{
			var book=new PhoneBook();
			book.Add ("Smith","555666777");
			book.Add ("Jones","444555666");
			Console.WriteLine (book["Smith"]);
			
		}
	}
}

//!Индексаторы - телефонна книга