using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Projet;
using Controler;
using System.Threading;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
			//DBConnector connexion = new DBConnector();
			/*List<int> numberList = new List<int>();
			for (int i = 1; i <= 5; i++)
			{
				ClientModel.CreationGroup();
				int groupType = ClientModel.GroupType();
				int idGroup = ClientModel.GroupClient(numberList);
				int numberClient = ClientModel.RandomClient();
				ClientBdd.clientBdd(groupType, idGroup, numberClient);

				Thread.Sleep(1000);
			}*/
			ActionFull();
				
		}


		static void ActionFull()
		{
			//DBConnector connexion = new DBConnector();
			DBStart.dbStart();
			List<int> numberList = new List<int>();
			for (int i = 1; i <= 5; i++)
			{
				
				ClientModel.CreationGroup();
				int groupType = ClientModel.GroupType();
				int idGroup = ClientModel.GroupClient(numberList);
				int numberClient = ClientModel.RandomClient();
				ClientBdd.clientBdd(groupType, idGroup, numberClient);

				Thread.Sleep(1000);
			}
		}
    }
}
