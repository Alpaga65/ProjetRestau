using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controler
{
    internal class SetTable
    {
       
        public Boolean Set(int NumberPerson, int Table)
        {
            int NbrPerson = NumberPerson;
            int IDTable = Table;
            Boolean Available = false;       //SQL NEEDED
            Boolean OtherTable = true;
            if (Available == true)
            {
                Console.WriteLine("Bonne table");
                Console.ReadKey();
                return true;
            }else
            {
                if (OtherTable == true)     //SQL NEEDED      
                {
                    Console.WriteLine("Table de taille supérieur");
                    Console.ReadKey();
                    return true;
                }
                else
                {
                    Console.WriteLine("Pas de place DESO");
                    Console.ReadKey();
                    return false;
                }
            }
            
        }
    }   
}
