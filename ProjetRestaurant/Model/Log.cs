using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Model
{
	class Log
	{
		public string a = "Nombre de client";
		public string dateString = DateTime.Today.ToShortDateString();
		public string HourString = DateTime.Now.Hour.ToString();
		public string MinuteString = DateTime.Now.Minute.ToString();
		public string SecondString = DateTime.Now.Second.ToString();



		public int RandomClient()
		{
			Random randClient = new Random();
			int nombreClient = randClient.Next(0, 11);
			return nombreClient;

		}

		public void Logs(int nombreClient)
		{

			StreamWriter w = File.AppendText("C:/DossierLog.txt");
			w.WriteLine($"{dateString} {HourString}{":"}{MinuteString}{":"}{SecondString} {":"} {a} {nombreClient}");
			w.Close();

			using (StreamReader reader = new StreamReader(@"C:/DossierLog.txt"))
			{
				string content = reader.ReadToEnd();
				reader.Close();
				String b = content;
				Console.WriteLine(b);
				Console.ReadKey();

			}

		}
	}
}
