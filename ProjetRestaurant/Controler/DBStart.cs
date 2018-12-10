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
		public static void dbStart()
		{
			string requete1 = "DELETE FROM Clients";
			string requete2 = "UPDATE tables SET situation = 0";

			MySqlCommand cmd = new MySqlCommand(requete1, DBConnector.Instance.Connect);
			cmd.ExecuteNonQuery();
			cmd = new MySqlCommand(requete2, DBConnector.Instance.Connect );
			cmd.ExecuteNonQuery();
		}
	}
}
