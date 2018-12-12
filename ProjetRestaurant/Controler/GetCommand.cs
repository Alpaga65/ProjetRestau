using Model;
using MySql.Data.MySqlClient;

using System.Threading;

namespace Controler
{
    public class GetCommand
    {
        //Instanciation des objets
        public GetTable table = new GetTable ( );
        public Log write = new Log ( );
        public Serveur service = new Serveur ( );

        //Récupération de la commande des clients par groupe
        public void getCommand ( int id_table, int id_group, int numberClient )
        {
            Thread.Sleep ( 5000 ); 
            string requete = "SELECT id_plat FROM Clients WHERE id_groupe=" + id_group;
            MySqlCommand cmd = new MySqlCommand ( requete, DBConnector.Instance.Connect );
            MySqlDataReader reader = cmd.ExecuteReader ( );

            //Récupération de la commande par client 
            while ( reader.Read ( ) )
            {
                string test = reader.GetString ( "id_plat" );
                string message = "Un client du groupe n°" + id_group + " commande - " + test;
                write.Logs ( "Maitre de rang", message );
            }
            reader.Close ( );

            //Appel de la fonction suivante
            service.Server ( id_table, id_group );
        }
    }
}
