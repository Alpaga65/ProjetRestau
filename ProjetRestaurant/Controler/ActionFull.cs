using Model;
using System.Collections.Generic;


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
