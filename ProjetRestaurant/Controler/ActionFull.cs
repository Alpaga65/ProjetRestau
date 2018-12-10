using Model;
using System.Collections.Generic;


namespace Controler
{
	public class ActionFull
	{
		ClientBdd clientbdd = new ClientBdd();
		public void actionFull()
		{
			
			DBStart.dbStart();
			List<int> numberList = new List<int>();

			int numberClient = ClientModel.RandomClient();
			ClientModel.CreationGroup(numberClient);
			int groupType = ClientModel.GroupType(numberClient);
			int id_group = ClientModel.GroupClient(numberList);		
			clientbdd.clientBdd(groupType, id_group, numberClient);

		}
	}
}
