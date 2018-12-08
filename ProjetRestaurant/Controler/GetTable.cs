using MySql.Data.MySqlClient;
using Projet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command
{
	public class setTable
	{
		DBConnector connexion = new DBConnector();
		public int GetTable(int capacite)
		{
			string requete = "SELECT id_table FROM tables WHERE situation=0 AND capacite>=" + capacite;
			MySqlCommand cmd = new MySqlCommand(requete, connexion.connect);
			MySqlDataReader reader = cmd.ExecuteReader();
			if (reader.Read())
			{

				int t = reader.GetInt32(0);
				reader.Close();
				return t;
			}
			return 0;

		}
	}
}
