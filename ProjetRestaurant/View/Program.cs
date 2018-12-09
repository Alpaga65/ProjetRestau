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
		ActionFull action = new ActionFull();
		void Main(string[] args)
		{
			
			action.actionFull();

		}

	}
}