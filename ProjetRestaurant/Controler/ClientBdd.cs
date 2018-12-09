using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Projet;
using Model;

namespace Controler
{
	public class ClientBdd
	{
		static DBConnector connexion = new DBConnector();

		public static void clientBdd(int groupType, int idGroup, int numberClient)
		{
			for(int i = 1; i <= numberClient; i++)
			{
				var random = new Random();
				var list = new List<string>
				{
					"Pates bolognaise", "Pates carbonara", "Pates pesto", "Pates saumon", "Pates cèpes",
					"Pizza margarita", "Pizza 4 fromages", "Pizza montagnarde", "Pizza kebab", "Pizza saveur"
				};
				int number = random.Next(list.Count);
				string order = list[number];
				//toto.Logs("Client", order);
				//return list[number];


				string requete1 = "INSERT INTO Clients (type, id_plat, id_groupe) VALUES (" + groupType + ", '"+ order + "', " + idGroup +")";
				MySqlCommand cmd = new MySqlCommand(requete1, connexion.connect);
				cmd.ExecuteNonQuery();
			}

			
		}
	}
}
