using System;
using System.Data.Common;
using MySql.Data.MySqlClient;

namespace Projet
{
    public class DBConnector
    {

        public MySqlConnection connect;
        public static DBConnector instance;
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
        public DBConnector ( )
        {
            if ( connect == null )
            {
                try
                {
                    connect = new MySqlConnection ( "SERVER=178.62.4.64;DATABASE=Groupe1_Pau;UID=Groupe1Pau;PASSWORD=grp1" );
                    connect.Open ( );
                    //Console.WriteLine ( "sys : INSTANCIATION CONNEXION SQL" );
                }
                catch ( MySql.Data.MySqlClient.MySqlException ex )
                {
                    Console.WriteLine ( ex.Message );
                    Console.ReadKey ( );
                }
            }
        }
        public void CloseConnection ( )
        {
            connect.Close ( );
        }
    }
}