using System;
class L2S01
{
	public static void MainX()
	{
		for (int i=0;i<20;i++)
		{
			var bytes=new byte[1000000];
			Console.WriteLine (GC.GetTotalMemory(false));
		}
		
	}
}

//!Демонстрируем, что память при выделении кончается