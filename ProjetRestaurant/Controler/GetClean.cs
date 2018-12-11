﻿using Model;
using MySql.Data.MySqlClient;
using System.Threading;

namespace Controler
{
    public class GetClean
    {
        //Instanciation des objets
        Log write = new Log();
        SetAvailable sa = new SetAvailable();

        //Mise à jour de l'état de la table dans la bdd
        public void getClean(int table, int id_group)
        {
            //Attente que le groupe mange
            Thread.Sleep(5000);
            string texte = "Le groupe " + id_group;
            write.Logs(texte, " a fini de manger ");

            //Débarrasse la table
            Thread.Sleep(1000);
            string text = "Serveur " + id_group;
            write.Logs(text, " débarasse la table ");

            //Mise à jour de la table dans la bdd
            string requete1 = "UPDATE tables SET situation=2 WHERE id_groupe=" + id_group;
            MySqlCommand cmd = new MySqlCommand(requete1, DBConnector.Instance.Connect);
            cmd.ExecuteNonQuery();

            sa.setAvailable(table, id_group);
        }
    }
}