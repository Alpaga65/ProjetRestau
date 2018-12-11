using System.Collections.Generic;
using Model;



namespace Controler
{
	public class ActionFull
	{
        //Instanciation des objets
		ClientBdd clientbdd = new ClientBdd();
        ClientModel clientModel = new ClientModel();
        List<int> numberList = new List<int>();

        //Lancement de l'application
        public void actionFull()
		{
			int numberClient = clientModel.RandomClient();
			clientModel.CreationGroup(numberClient);
			int groupType = clientModel.GroupType(numberClient);
			int id_group = clientModel.GroupClient(numberList);
			clientbdd.clientBdd(groupType, id_group, numberClient);
		}
	}
}
