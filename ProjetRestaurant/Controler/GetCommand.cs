using Controler;
using Model;
using MySql.Data.MySqlClient;

using System.Threading;

namespace Controler
{
    public class GetCommand
    {
        GetTable table = new GetTable ( );
        Log write = new Log ( );
        public Serveur service = new Serveur ( );

        public void getCommand ( int id_table, int id_group, int numberClient )
        {
            Thread.Sleep ( 5000 );
            string requete = "SELECT id_plat FROM Clients WHERE id_groupe=" + id_group;
            MySqlCommand cmd = new MySqlCommand ( requete, DBConnector.Instance.Connect );
            MySqlDataReader reader = cmd.ExecuteReader ( );


            while ( reader.Read ( ) )
            {
                string test = reader.GetString ( "id_plat" );
                string message = "Un client du groupe n°" + id_group + " commande - " + test;
                write.Logs ( "Maitre de rang", message );
            }
            reader.Close ( );
            service.Server ( id_table, id_group );
        }
    }
}
