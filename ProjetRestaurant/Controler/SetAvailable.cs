using Model;
using MySql.Data.MySqlClient;
using System.Threading;
using System;

namespace Controler
{
    public class SetAvailable
    {
        //Instanciation deS objets
        public Log write = new Log ( );
        //ActionFull Action = new ActionFull ( );

        //Actualise le status de la table
        public void setAvailable ( int table, int id_group )
        {
            string texte = ""; 
            string requete = "UPDATE tables SET situation='0' WHERE id_groupe=" + id_group;
            MySqlCommand cmd = new MySqlCommand ( requete, DBConnector.Instance.Connect );
            MySqlDataReader reader = cmd.ExecuteReader ( );

            texte = "Le Maître de rang dresse à nouveau la table n°" + table;
            write.Logs ( texte, "elle est disponible" );
            
            Console.ReadKey ( );

            //Appel de la fonction suivante
            //Action.actionFull ( );
        }
    }
}