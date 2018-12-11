using MySql.Data.MySqlClient;


namespace Controler
{
	public class SetTable
	{
       //Attribut la table au groupe
        public void setTable(int table, int id_group, int situation)
		{
			string requete1 = "UPDATE tables SET situation= "+ situation + ", id_groupe="+ id_group +" WHERE id_table=" + table;
			MySqlCommand cmd = new MySqlCommand(requete1, DBConnector.Instance.Connect );
			cmd.ExecuteNonQuery();
		}
	}
}
