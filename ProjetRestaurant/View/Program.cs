using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
		static void Main(string[] args)
		{
			Thread.Sleep(1000);
			action.actionFull();

		}

	}
}