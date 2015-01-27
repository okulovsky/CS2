using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
	
	public class TableGenerator
	{
		static List<Tuple<char,string>> data=new List<Tuple<char, string>>();
		static void Parse(string da)
		{
			foreach(var s in da.Split (' '))
			{
				var c=s[0];
				var ss=Normalize(s.Substring (1,s.Length-1));
				data.Add (Tuple.Create(c,ss));	
			}
		}
		
		static string Normalize(string str)
		{
					return str.OrderBy(z=>z).Select (z=>z.ToString ()).Aggregate((a,b)=>a+b);
		}
		
		public static void Main()
		{
			Parse("─lr │ud ┌dr ┐dl └ur ┘ul ├udr ┤udl ┬lrd ┴lru ┼lrdu ═LR ║UD ╒dR ╓Dr ╔DR ╕dR ╖Dr ╗DR ╘uR ╙Ur ╚UR ╛Lu ╜lU ╝LU ╞udR ╟UDr ╠UDR ╡udL ╢UDl ╣UDL ╤LRd ╥lrD ╦LRD ╧LRu ╨lrU ╩LRU ╪LRud ╫lrUD ╬LRUD");
			string syms=" ulrdULRD";
			List<string> seen=new List<string>();
			var bld=new StringBuilder("    ");
			for (int i=0;i<4;i++)
			{
				foreach(var e in syms)
				{
					bld[i]=e;
					var name=bld.ToString().Replace(" ","");
					if (seen.Contains (name)) continue;
					var str=Normalize(name);
					var d=data.Where(z=>z.Item2==str).FirstOrDefault();
					if (d==null) continue;
					Console.WriteLine ("public const char {0}='{1}';",name,d.Item1);
				}
			}		
		}
	}
}
