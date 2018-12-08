using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    class Programe
    {
        static void Main ( string[] args )
        {
            int t = DBConnector.Instance.GetTable ( 11 );
           // int s = DBConnector.Instance.SetTable ( t );




            DBConnector.Instance.CloseConnection ( );
            Console.ReadKey ( );

        }
    }
}
