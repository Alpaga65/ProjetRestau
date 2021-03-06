﻿
using Model;
using MySql.Data.MySqlClient;

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
        //Instanciation des objets
        public Log write = new Log ( );
        public GetClean gc = new GetClean ( );

        //Récupération des plats depuis la "cuisine" par le serveur
		public void Server ( int table , int id_group )
        {
			Thread.Sleep(10000);
			string requete = "SELECT id_plat FROM Clients WHERE id_groupe=" + id_group;
            MySqlCommand cmd = new MySqlCommand ( requete, DBConnector.Instance.Connect );
            MySqlDataReader reader = cmd.ExecuteReader ( ); 

            while ( reader.Read ( ) )
            {
                string plat = reader.GetString ( "id_plat" );
                string message = "Apporte - " + plat + " au groupe n°" + id_group;
                write.Logs ( "Serveur", message );
            }
            reader.Close ( );
            gc.getClean (table , id_group );
        }
        
    }
}