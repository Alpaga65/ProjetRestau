using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Model
{
	public class Log
	{
        //Ecrire dans le fichier log et l'afficher dans la console
		public void Logs(String Role, String Message)
		{
            
            StreamWriter w = File.AppendText("C:/temp/DossierLog.txt");
            w.WriteLine ( $"{Role} {":"} {Message}" );
            w.Close ( );

            using (StreamReader reader = new StreamReader(@"C:/temp/DossierLog.txt"))
			{
				string content = reader.ReadToEnd();
				reader.Close();
				String b = content;
				Console.WriteLine(b);
				Thread.Sleep(250);

			}

           
		}
	}
}
