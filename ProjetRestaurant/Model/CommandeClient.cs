using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public class CommandeClient
	{
	    //Ramdom plat client
		public string commandeclient()
		{
			
		var random = new Random();
			var list = new List<string> {"Pates bolognaise", "Pates carbonara", "Pates pesto", "Pates saumon", "Pates cèpes",
			"Pizza margarita", "Pizza 4 fromages", "Pizza montagnarde", "Pizza kebab", "Pizza saveur" };
			int number = random.Next(list.Count);
			string text = list[number];
			return text;
		}
	}	
}
 
