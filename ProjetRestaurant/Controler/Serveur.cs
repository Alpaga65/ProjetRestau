
using Model;
using MySql.Data.MySqlClient;
using Projet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Controler
{
    public class Serveur
    {
        DBConnector connexion = new DBConnector ( );
        Log write = new Log ( );
        public Serveur ( int id_group )
        {
            string requete = "SELECT id_plat FROM Clients WHERE id_groupe=" + id_group;
            MySqlCommand cmd = new MySqlCommand ( requete, connexion.connect );
            MySqlDataReader reader = cmd.ExecuteReader ( );

            while ( reader.Read ( ) )
            {
                string plat = reader.GetString ( "id_plat" );
                string message = " Apporte" + plat + " au groupe" + id_group;
                write.Logs ( "Serveur", message );


            }
            reader.Close ( );

        }
    }
}