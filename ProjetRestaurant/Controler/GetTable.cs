using MySql.Data.MySqlClient;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Controler
{
	public class GetTable
	{
        
        Log write = new Log();
		public int getTable(int capacite)
		{
            int t = 0;
			string requete = "SELECT id_table FROM tables WHERE situation=0 AND capacite>=" + capacite;
			MySqlCommand cmd = new MySqlCommand(requete, DBConnector.Instance.Connect );
			MySqlDataReader reader = cmd.ExecuteReader();
			if (reader.Read())
			{
			t = reader.GetInt32(0);
				reader.Close();
				return t;
			}
            string message = "Nous avons aucunes tables pour votre groupe";
            write.Logs( "Maitre d'hotêl", message );
			return 0;
		}
	}
}