using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controler
{
	internal class SetTable
	{

		public Boolean Set(int NumberPerson, int NumberSlot)
		{
			int NbrPerson = NumberPerson;
			int Slots = NumberSlot;
			Boolean Available = false;       //SQL NEEDED
			Boolean OtherTable = true;
			if (Available == true)
			{
				Console.WriteLine("Bonne table");
				Console.ReadKey();
				return true;
			}
			else if (OtherTable == true)     //SQL NEEDED      
			{
				Console.WriteLine("Table de taille supérieur");
				Console.ReadKey();
				Boolean Test = SetOther(Slots);
				return Test;

			}
			else
			{
				return false;
			}
		}



		public Boolean SetOther(int NumberSlot)
		{

			int Numberslots = NumberSlot + 2;
			Boolean Available = false;

			if (NumberSlot == 4)
			{
				for (int i = 0; i < 11; i++)
				{
					if (Available == true)
					{
						Console.WriteLine("Table trouvé");
						Console.ReadKey();
						return true;
					}
					else
					{
						System.Threading.Thread.Sleep(250);
						Console.WriteLine("Recherche de table 4");
						Console.ReadKey();

					}
					if (i == 10)
					{
						SetOther(Numberslots);
					}

				}
			}
			else if (NumberSlot == 6)
			{
				for (int i = 0; i < 6; i++)
				{
					if (Available == true)
					{
						Console.WriteLine("Table trouvé");
						Console.ReadKey();
						return true;
					}
					else
					{
						System.Threading.Thread.Sleep(50);
						Console.WriteLine("Recherche de table 6");
						Console.ReadKey();

					}
					if (i == 5)
					{
						SetOther(Numberslots);
					}
				}
			}
			else if (NumberSlot == 8)
			{
				for (int i = 0; i < 6; i++)
				{
					if (Available == true)
					{
						Console.WriteLine("Table trouvé");
						Console.ReadKey();
						return true;
					}
					else
					{
						System.Threading.Thread.Sleep(50);
						Console.WriteLine("Recherche de table 8");
						Console.ReadKey();

					}
					if (i == 5)
					{
						SetOther(Numberslots);
					}
				}
			}
			else if (NumberSlot == 10)
			{
				
				for (int i = 0; i < 3
					
					; i++)
				{
					if (Available == true)
					{
						Console.WriteLine("Table trouvé");
						Console.ReadKey();
						return true;
					}
					else
					{
						System.Threading.Thread.Sleep(50);
						Console.WriteLine("Recherche de table 10");
						Console.ReadKey();
					}
					if (i == 2)
					{
						Console.WriteLine("pas de place déso");
						Console.ReadKey();
					}
				}
			}
			return true;
		}
	}
}