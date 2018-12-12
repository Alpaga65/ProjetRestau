using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Model;
using System.Threading;


namespace Controler
{
	public class ClientBdd
	{
        //Instanciation des objets
		public GetTable gt = new GetTable ( ); 
        public SetTable st = new SetTable ( );
        public CommandeClient client = new CommandeClient( );
		public GetCommand order = new GetCommand( );
		public Log log = new Log( );

        //Ajout clients dans la BDD
		public void clientBdd(int groupType, int id_group, int numberClient)
		{
            //Gestion des tables
            int id_table = gt.getTable ( numberClient );
            st.setTable ( id_table, id_group, 1 );
		
		    Thread.Sleep(1000);

            //Ajout de chaque client
		    for(int i = 1; i <= numberClient; i++)
		    {
				string commande = client.commandeclient( );

				string requete1 = "INSERT INTO Clients (type, id_plat, id_groupe) VALUES (" + groupType + ", '" + commande + "', " + id_group + ")";
				MySqlCommand cmd = new MySqlCommand(requete1, DBConnector.Instance.Connect );
				cmd.ExecuteNonQuery( );
				
			}
            //Appel de la fonction suivante
			order.getCommand( id_table,id_group, numberClient );
		}
	}
}
