using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Model
{
   public static class ClientModel
    {
        static void Main(string[] args)
        {

			//CreationGroup();
			
        }

		static List<int> numberList = new List<int>();
		public static void CreationGroup()
		{
			
			//for (int i = 1; i <= 50; i++)
			//{
				int number = RandomClient();
				
				int idGroup = GroupClient(numberList);
				if (number != 0)
				{
				string idGroupName = "Groupe " + idGroup + " de " + number + " personne(s)";
				Console.WriteLine(idGroupName);
				}
				else
				{
				Console.WriteLine("Pas de groupe");
				}
				GroupType();
				TextTypeGroupe();

				//Thread.Sleep(10000);
			//}

		}

		public static int RandomClient()
		{
			Random randClient = new Random();
			int numberClient = randClient.Next(1, 11);
			return numberClient;

		}



		public static int GroupClient(List<int> numberList)
		{

			int idGroup = 1;

			//int number = RandomClient();



			if (numberList.Contains(idGroup))
			{
				while (numberList.Contains(idGroup))
				{
					idGroup++;
				}

			}

			numberList.Add(idGroup);

			/*if (number != 0)
			{
				string idGroupName = "Groupe " + idGroup + " de " + number + " personne(s)";
				Console.WriteLine(idGroupName);
			}
			else
			{
				Console.WriteLine("Pas de groupe");
			}*/

			return idGroup;

		}



		public static string RandomType()
        {
            String[] typepersonne = { "pressé", "normal", "cool" };
            List<string> randomList = new List<string>();

            int number = RandomClient();
            Random randType = new Random();
            for (int i = 1; i <= number; i++)
            {
                int selection = randType.Next(0, 3);
                string type = typepersonne[selection];
                randomList.Add(type);
                
            }
            string groupeType = string.Join(",", randomList.ToArray());
            return groupeType;


        }




		public static int GroupType()
		{
			string listType = RandomType();
			bool type1 = listType.Contains("cool");
			bool type2 = listType.Contains("normal");
			bool type3 = listType.Contains("pressé");

			int groupType = 0;

			if (type1)
			{
				groupType = 1;

			}else if (!type1 & type2)
			{
				groupType = 2;
			}else if (!type1 & !type2 & type3)
			{
				groupType = 3;
			}else
			{
				groupType = 4;
			}
			return groupType;
		}



		static class Factory
		{

			public static Type Get(int groupType)
			{

				GroupType();


				switch (groupType)
				{
					case 1: return new Cool();
					case 2: return new Normal();
					case 3: return new Pressé();
					case 4:
					default: return new Aucun();
				}



			}
		}

		abstract class Type
		{
			public abstract string Title
			{
				get;
			}
		}

		class Cool : Type
		{
			public override string Title
			{
				get
				{
					string groupType = "cool";
					return groupType;
				}
			}
		}

		class Normal : Type
		{
			public override string Title
			{
				get
				{
					string groupType = "normal";
					return groupType;
				}
			}
		}

		class Pressé : Type
		{
			public override string Title
			{
				get
				{
					string groupType = "pressé";
					return groupType;
				}
			}
		}

		class Aucun : Type
		{
			public override string Title
			{
				get
				{
					return null;
				}
			}
		}

		public static void TextTypeGroupe()
		{
			var type = Factory.Get(GroupType());
			int number = RandomClient();
			if (number != 0)
			{
				Console.WriteLine("On va se baser sur le temps de la personne " + type.Title + "\n");
			}
			else
			{
				Console.Write("\n");
			}
		}

	}
}
