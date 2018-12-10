using Model;
using System.Collections.Generic;


namespace Controler
{
    public class ActionFull
    {
        ClientBdd clientbdd = new ClientBdd ( );
        LogStart ls = new LogStart ( );
        public void actionFull ( )
        {
            ls.logStart ( );
            DBStart.dbStart ( );
            List<int> numberList = new List<int> ( );

            ClientModel clientModel = new ClientModel ( );
            int numberClient = clientModel.RandomClient ( );
            clientModel.CreationGroup ( numberClient );
            int groupType = clientModel.GroupType ( numberClient );
            int id_group = clientModel.GroupClient ( numberList );
            clientbdd.clientBdd ( groupType, id_group, numberClient );

        }
    }
}
