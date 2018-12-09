using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public class CommandeClient
	{
		int numberClient = ClientModel.RandomClient();
		public Log toto = new Log();
		public string Commande()
		{
			var random = new Random();
			var list = new List<string> {"Pates bolognaise", "Pates carbonara", "Pates pesto", "Pates saumon", "Pates cèpes",
			"Pizza margarita", "Pizza 4 fromages", "Pizza montagnarde", "Pizza kebab", "Pizza saveur" };
			int number = random.Next(list.Count);
			string order = "Le client commande :" + list[number] + "";
			toto.Logs("Client", order);
			return list[number];
		}
	}	
}
 
