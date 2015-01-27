using System;
using System.Collections.Generic;

namespace LabEvent
{
	
	
	
	public class Game
	{
			
		bool OnBorderCrush() { return true;}
		void OnHearts() {}
		void OnDiamonds() {}
		
		#region Don't look here
		struct GameObject
		{
			public int X { get; set; }
			public int Y { get; set; }
			public char Symbol { get; set; }
		}
		
		public void Start()
		{
			Console.Clear ();
			int width=30;
			int height=20;
			SuperConsole.DoubleFrame(0,0,width+1,height+1, ConsoleColor.Green);
			
			var items=new List<GameObject>();
			var rnd=new Random();
			for (int i=0;i<50;i++)
				items.Add (new GameObject
				          {
							X=rnd.Next(width-1)+1,
							Y=rnd.Next (height-1)+1,
							Symbol=rnd.Next(2)==1?Symbols.Hearts:Symbols.Diamonds
				});
			foreach(var e in items)
				SuperConsole.Put (e.X,e.Y,e.Symbol,ConsoleColor.Red);
			
			int x=1;
			int y=1;
			while(true)
			{
				SuperConsole.Put (x,y,Symbols.WhiteFace,ConsoleColor.Cyan);
				var key=Console.ReadKey (true);
				var oldX=x;
				var oldY=y;
				switch(key.Key)
				{
					case   ConsoleKey.UpArrow : 
						if (y!=1) y--;
						else if (OnBorderCrush()) return;
						break;
				case  ConsoleKey.DownArrow:
					if (y!=height) y++;
					else if (OnBorderCrush ()) return;
					break;
				case ConsoleKey.LeftArrow:
					if (x!=1) x--;
					else if (OnBorderCrush ()) return;
					break;
				case ConsoleKey.RightArrow:
					if (x!=width) x++;
					else if (OnBorderCrush()) return;
					break;
				case ConsoleKey.Escape:
					return;
				}
				foreach(var e in items)
					if (e.X==x  && e.Y==y) 
				{
					if (e.Symbol==Symbols.Hearts) OnHearts();
					if (e.Symbol==Symbols.Diamonds) OnDiamonds();
					break;
				}
				
				SuperConsole.Put (oldX,oldY,' ');
			}
		}
		#endregion 
		
	}
}
