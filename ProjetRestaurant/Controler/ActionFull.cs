using Model;
using System.Collections.Generic;


namespace Controler
{
    public class ActionFull
    {

        public ClientBdd clientbdd = new ClientBdd ( );
        public  List<int> numberList = new List<int> ( );
        public ClientModel clientModel = new ClientModel ( );

        //Lancement application
        public void actionFull ( )
        {
            
            int numberClient = clientModel.RandomClient ( );
            clientModel.CreationGroup ( numberClient );
            int groupType = clientModel.GroupType ( numberClient );
            int id_group = clientModel.GroupClient ( numberList );
            clientbdd.clientBdd ( groupType, id_group, numberClient );

        }
    }
}
