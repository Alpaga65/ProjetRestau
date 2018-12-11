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
        //public string a = "Nombre de client";
        public string dateString = DateTime.Today.ToShortDateString ( );
        public string HourString = DateTime.Now.Hour.ToString();
		public string MinuteString = DateTime.Now.Minute.ToString();
		public string SecondString = DateTime.Now.Second.ToString();

		/*PAS TOUCHE*/
		public void Logs(String Role, String Message)
		{         
            StreamWriter w = File.AppendText("C:/temp/DossierLog.txt");
            w.WriteLine ( $"{dateString} {HourString}{":"}{MinuteString}{":"}{SecondString} {":"} {Role} {":"} {Message}" );
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
