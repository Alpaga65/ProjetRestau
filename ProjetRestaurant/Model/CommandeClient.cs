using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	class CommandeClient
	{
		int numberClient = ClientModel.RandomClient();
		List<string> entrées = new List<string>
		{
			"Foie gras", "Carottes rapées", "Betterave", "Salade de thon maïs",
			"Tapas", "Oeuf à la coque", "melon", "Pastèque", "Taboulet", "Carpaccio de saumon"
		};

		List<string> plats = new List<string>
		{
			"Pates bolognaise", "Pates carbonara", "Pates pesto", "Pates saumon", "Pates cèpes",
			"Pizza margarita", "Pizza 4 fromages", "Pizza montagnarde", "Pizza kebab", "Pizza saveur"
		};

		List<string> desserts = new List<string>
		{
			"Glace vanille", "Glace chocolat", "Glace orange", "Glace citron", "Glace pistache", "Glace fraise",
			"Glace framboise", "Glace fruit de la passion", "Glace ananas", "Glace cerises", "Glace vegan vanille", "Glace mangue"
		};
		/*public class Plats
		{
			
		}*/


	}
}
