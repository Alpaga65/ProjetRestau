using Model;
using MySql.Data.MySqlClient;
using System.Threading;

namespace Controler
{
    public class GetClean
    {
        //Instanciation des objets
        public Log write = new Log ( );
        public SetAvailable sa = new SetAvailable ( );

        //Réinitialisation des tables utilisées
        public void getClean ( int table, int id_group )
        {
            Thread.Sleep ( 5000 ); 
            string texte = "Le groupe " + id_group;
            write.Logs ( texte, " a fini de manger " );

            Thread.Sleep ( 1000 );
            string text = "Serveur " + id_group;
            write.Logs ( text, " débarasse la table " );

            string requete1 = "UPDATE tables SET situation=2 WHERE id_groupe=" + id_group;
            MySqlCommand cmd = new MySqlCommand ( requete1, DBConnector.Instance.Connect );
            cmd.ExecuteNonQuery ( );

            //Appel de la fonction suivante
            sa.setAvailable ( table,id_group );
        }
    }
}