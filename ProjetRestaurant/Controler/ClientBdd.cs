﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Model;
using System.Threading;
using command;

namespace Controler
{
	public class ClientBdd
	{

		
		public CommandeClient client = new CommandeClient();
		public GetCommand order = new GetCommand();
		
		Log log = new Log();
		public void clientBdd(int groupType, int id_group, int numberClient)
		{
        //int t = connexion.Instance.GetTable ( numberClient );
        //int s = connexion.Instance.SetTable ( t, id_group, 1 );
		
			Thread.Sleep(1000);

			for(int i = 1; i <= numberClient; i++)
			{

				string commande = client.commandeclient();

				string requete1 = "INSERT INTO Clients (type, id_plat, id_groupe) VALUES (" + groupType + ", '" + commande + "', " + id_group + ")";
				MySqlCommand cmd = new MySqlCommand(requete1, DBConnector.Instance.Connect );
				cmd.ExecuteNonQuery();
				
			}
			order.getCommand(id_group, numberClient);
		}
        
	}
}
