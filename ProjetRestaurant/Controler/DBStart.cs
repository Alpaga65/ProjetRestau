using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controler
{
	public class DBStart
	{

		static DBConnector connexion = new DBConnector();

		public static void dbStart()
		{
			string requete1 = "DELETE FROM Clients";
			string requete2 = "UPDATE tables SET situation = 0";

			MySqlCommand cmd = new MySqlCommand(requete1, connexion.connect);
			cmd.ExecuteNonQuery();
			cmd = new MySqlCommand(requete2, connexion.connect);
			cmd.ExecuteNonQuery();
		}
	}
}
