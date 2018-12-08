using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controler
{
    class Table
    {
        
        private static void Main(string[] args)
        {
            int person = 5;
			CheckTable CheckTest = new CheckTable();
			SetTable SetTest = new SetTable();
			int Checktest = CheckTest.Check(person);
			Boolean Settest = SetTest.Set(person, Checktest);
	


        }

	}

}

