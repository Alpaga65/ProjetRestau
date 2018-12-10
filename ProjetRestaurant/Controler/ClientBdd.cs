using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Projet;
using Model;
using System.Threading;
using command;

namespace Controler
{
	public class ClientBdd
	{

		static DBConnector connexion = new DBConnector();
		public CommandeClient client = new CommandeClient();
		public GetCommand order = new GetCommand();
		Log log = new Log();
		public void clientBdd(int groupType, int idGroup, int numberClient)
		{
			Thread.Sleep(1000);

			for(int i = 1; i <= numberClient; i++)
			{

				string commande = client.commandeclient();

				string requete1 = "INSERT INTO Clients (type, id_plat, id_groupe) VALUES (" + groupType + ", '" + commande + "', " + idGroup + ")";
				MySqlCommand cmd = new MySqlCommand(requete1, connexion.connect);
				cmd.ExecuteNonQuery();
				
			}


			order.GetTable(idGroup, numberClient);
		}

		
	}
}
