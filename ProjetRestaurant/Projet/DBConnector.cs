using System;
using System.Data.Common;
using MySql.Data.MySqlClient;

namespace Projet
{
    public class DBConnector
    {

        private MySqlConnection connect;
        private static DBConnector instance;
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
        private DBConnector ( )
        {
            if ( connect == null )
            {
                try
                {
                    connect = new MySqlConnection ( "SERVER=178.62.4.64;DATABASE=Groupe1_Pau;UID=Groupe1Pau;PASSWORD=grp1" );
                    connect.Open ( );
                    Console.WriteLine ( "sys : INSTANCIATION CONNEXION SQL" );
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


        public int GetTable ( int capacite )
        {
            string requete = "SELECT id_table FROM tables WHERE situation=0 AND capacite>=" + capacite;
            MySqlCommand cmd = new MySqlCommand ( requete, connect );
            MySqlDataReader reader = cmd.ExecuteReader ( );
            if ( reader.Read ( ) )
            {

                int t = reader.GetInt32 ( 0 );
                reader.Close ( );
                return t;
            }
            return 0;
        }

        public void SetTable ( int id, int id_groupe )
        {
            string requete1 = "UPDATE tables SET situation=1 WHERE id_table=" + id;
            string requete2 = "UPDATE clients SET id_table=" + id + " WHERE id_groupe=" + id_groupe;

            MySqlCommand cmd = new MySqlCommand ( requete1, connect );
            cmd.ExecuteNonQuery ( );
            cmd = new MySqlCommand ( requete2, connect );
            cmd.ExecuteNonQuery ( );
        }
    }
}