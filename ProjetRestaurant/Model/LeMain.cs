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
            Log write = new Log();
            write.Logs();
            
            using (StreamReader reader = new StreamReader(@"C:\Users\sadoun\Desktop\projetc#\DossierLog\log.txt"))
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
