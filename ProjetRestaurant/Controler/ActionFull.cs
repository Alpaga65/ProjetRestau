using Model;
using Projet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Controler
{
	public class ActionFull
	{
		ClientBdd clientbdd = new ClientBdd();
		public void actionFull()
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
				clientbdd.clientBdd(groupType, idGroup, numberClient);
				
				
				
				
			}
		}
	}
}
