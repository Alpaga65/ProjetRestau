using System;
using System.Data.Common;
using MySql.Data.MySqlClient;

namespace Controler
{
    public class DBConnector
    {

        private MySqlConnection connect;
        private static DBConnector instance;

        //Création du singleton de connexion
        public static DBConnector Instance
        {
            get
            {
                if ( instance == null )
                {
                    instance = new DBConnector ( );
                }
                return instance;
            }
        }

        //Création de la connexion
        private  DBConnector ( )
        {
            if ( connect == null )
            {
                try
                {
                    connect = new MySqlConnection ( "SERVER=178.62.4.64;DATABASE=Groupe1_Pau;UID=Groupe1Pau;PASSWORD=grp1" );
                    connect.Open ( );
                    Console.WriteLine ( "CONNEXION SQL = TRUE" );
                }
                catch ( MySql.Data.MySqlClient.MySqlException ex )
                {
                    Console.WriteLine ( ex.Message );
                    Console.ReadKey ( );
                }
            }
        }

        //Ferme la connexion
        public void CloseConnection ( )
        {
            connect.Close ( );
        }

        //Retoune la connexion
        public MySqlConnection Connect
        {
            get { return connect; }
        }
    }
}