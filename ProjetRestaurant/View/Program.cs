using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Controler;
using Model;

namespace View
{
	
	class Program
    {
        //Instanciation des objets
        public static LogStart ls = new LogStart ( );
		static ActionFull action = new ActionFull();

        //Initialisation programme
		static void Main(string[] args)
		{
            ls.logStart ( );
            DBStart.dbStart ( );
			Thread.Sleep(1000);
			action.actionFull();

		}
	}
}