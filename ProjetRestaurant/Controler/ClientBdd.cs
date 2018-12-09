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
				string requete1 = "INSERT INTO Clients (type, id_groupe) SELECT " + groupType + ", " + idGroup + ";";
				MySqlCommand cmd = new MySqlCommand(requete1, connexion.connect);
				cmd.ExecuteNonQuery();
			}

			
		}
	}
}
