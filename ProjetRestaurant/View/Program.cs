using System.Threading;
using System.Threading.Tasks;
using command;
using Controler;
using Model;

namespace View
{

	class Program
	{
		static ActionFull action = new ActionFull();
        static LogStart ls = new LogStart();
        static void Main(string[] args)
		{
            ls.logStart();
            DBStart.dbStart();
            Thread.Sleep(1000);
			action.actionFull();

		}

	}
}