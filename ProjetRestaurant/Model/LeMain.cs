using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Model
{
	class LeMain
	{
		static void Main(string[] args)
		{
			Log r = new Log();
			int nombreClient = r.RandomClient();
			Log write = new Log();
			write.Logs(nombreClient);

		}

	}
}
