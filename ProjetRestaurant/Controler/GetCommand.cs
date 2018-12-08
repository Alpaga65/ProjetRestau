using MySql.Data.MySqlClient;
using Projet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controler
{
	class GetCommand
	{
		DBConnector connexion = new DBConnector();
		public void GetTable(int id_group)
		{
			string requete = "SELECT id_plat FROM Clients WHERE id_groupe=" + id_group+" id_plat!=null";
			MySqlCommand cmd = new MySqlCommand(requete, connexion.connect);
			MySqlDataReader reader = cmd.ExecuteReader();
			if (reader.Read())
			{

				int t = reader.GetInt32(0);
				reader.Close();
				
			}

		}
	}
}
