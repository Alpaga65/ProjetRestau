using Controler;
using Model;
using MySql.Data.MySqlClient;
using Projet;
using System.Threading;

namespace command
{
	public class GetCommand
	{
		DBConnector connexion = new DBConnector();
		Log write = new Log();
		public Serveur service = new Serveur();

		public void GetTable(int id_group, int numberClient)
		{
			Thread.Sleep(5000);
			string requete = "SELECT id_plat FROM Clients WHERE id_groupe=" + id_group;
			MySqlCommand cmd = new MySqlCommand(requete, connexion.connect);
			MySqlDataReader reader = cmd.ExecuteReader();


			while(reader.Read())
			{

				string test = reader.GetString("id_plat");
				string message = "Un client du groupe n°" + id_group +" a choisi son menu" + test;

				write.Logs("Maitre de rang", message);

			}
			
			reader.Close();
			service.Server(id_group);
		}
	}
}
