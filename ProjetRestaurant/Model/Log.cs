using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Model
{
    class Log
    {
        public string a = "Stplize";
        public string dateString = DateTime.Today.ToShortDateString();
        public string HourString = DateTime.Now.Hour.ToString();
        public string MinuteString = DateTime.Now.Minute.ToString();
        public string SecondString = DateTime.Now.Second.ToString();

        public static int RandomClient()
        {
            Random randClient = new Random();
            int nombreClient = randClient.Next(0, 10);
            return nombreClient;

        }
        public void Logs()
        {
            string monFichier = @"C:\Users\sadoun\Desktop\projetc#\DossierLog\log.txt";
            File.WriteAllText(monFichier, $"{dateString} {HourString}{":"}{MinuteString}{":"}{SecondString} {":"} {a}");

        }

    }
}
