using MySql.Data.MySqlClient;
using Projet;


namespace command
{
	public class SetTable
	{
		DBConnector connexion = new DBConnector();
		public void setTable(int table, int id_groupe, int situation)
		{

			
			string requete1 = "UPDATE tables SET situation= "+ situation + " WHERE id_table=" + table;
			string requete2 = "UPDATE clients SET id_table=" + table + " WHERE id_groupe=" + id_groupe;
			
			MySqlCommand cmd = new MySqlCommand(requete1, connexion.connect);
			cmd.ExecuteNonQuery();
			cmd = new MySqlCommand(requete2, connexion.connect);
			cmd.ExecuteNonQuery();
		}


	}

}
