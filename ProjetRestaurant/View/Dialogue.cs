using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace View
{
	class Dialogue
	{
		Log message = new Log();
		public void texte(int id_groupe)
		{

			Thread.Sleep(5000);
			string texte = "Le groupe"+ id_groupe;
			message.Logs(texte, "a fini de manger");
			Thread.Sleep(5000);
			string text = "Serveur" + id_groupe;
			message.Logs(text, "nettoie la table");
		}
			

	}
}
