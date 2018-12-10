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
			/*for (int i = 1; i <= 5; i++)
			{

				
			
			}*/
			int numberClient = ClientModel.RandomClient();
			ClientModel.CreationGroup(numberClient);
			int groupType = ClientModel.GroupType(numberClient);
			int idGroup = ClientModel.GroupClient(numberList);
			
			
			
			clientbdd.clientBdd(groupType, idGroup, numberClient);

		}
	}
}
