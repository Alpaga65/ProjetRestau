using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controler
{
    public class LogStart
    {

        public void logStart ( )
        {
            string path = "C:/temp/DossierLog.txt";
            if (File.Exists (path ) )
            {

                File.Delete ( path );
            }
            using ( FileStream fs = File.Create ( path ) )
            {

            }
        }
    }
}
