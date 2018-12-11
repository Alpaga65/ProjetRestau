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
        //Instanciation de l'objet
        public Log write = new Log ( );

        //Attribution de la table selon la taille du groupe
        public int getTable ( int capacite )
        {
            //Instanciation des variables
            int t = 0;
            string message = "";

            //Attribution de la table
            string requete = "SELECT id_table FROM tables WHERE situation=0 AND capacite>=" + capacite;
            MySqlCommand cmd = new MySqlCommand ( requete, DBConnector.Instance.Connect );
            MySqlDataReader reader = cmd.ExecuteReader ( );
            if ( reader.Read ( ) )
            {
                t = reader.GetInt32 ( 0 );
                reader.Close ( );
                message = "Affectation à la table n°" + t;
                write.Logs ( "Maitre d'hotêl", message );
                return t;
            }
            message = "Nous avons aucunes tables pour votre groupe";
            write.Logs ( "Maitre d'hotêl", message );
            return 0;
        }
    }
}