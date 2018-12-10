using Model;
using System.Threading;
using Controler;
//using MySql.Data.MySqlClient;

namespace View
{
    class Dialogue
    {
       /* Log message = new Log ( );

        public void texte ( int id_group )
        {

            Thread.Sleep ( 5000 );
            string texte = " Le groupe " + id_group;
            message.Logs ( texte, " a fini de manger " );

            Thread.Sleep ( 5000 );
            string text = " Serveur " + id_group;
            message.Logs ( text, " nettoie la table " );

            string requete = "UPDATE tables SET situation = '0' WHERE id_groupe=" + id_group;
            MySqlCommand cmd = new MySqlCommand ( requete, DBConnector.Instance.Connect );

        }

        public numeroTable ( )
        {
            string requete = "SELECT id_table FROM tables WHERE id_groupe=" + id_group;
            MySqlCommand cmd = new MySqlCommand ( requete, DBConnector.Instance.Connect );
            string num = cmd.ExecuteNonQuery ( );

            string texte = " La table " + num;
            message.Logs ( texte, " est propre ! " );

        }*/
    }
}