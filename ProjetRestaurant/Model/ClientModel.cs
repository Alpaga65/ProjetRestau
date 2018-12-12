using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Model
{
	public class ClientModel
	{
		public List<int> numberList = new List<int>();

		//Création complète d'un groupe
		public  void CreationGroup(int number)
		{
			Log logs = new Log();
			int id_group = GroupClient(numberList);
			if (number != 0)
			{
				string idGroupName = "Groupe " + id_group + " de " + number + " personne(s) ";
				logs.Logs("Client", idGroupName);
			}
			else
			{
				Console.WriteLine("Pas de groupe"); 
			}
			GroupType(number);
			TextTypeGroupe(number);
		}

		//Nombre de client aléatoire entre 1 et 10
		public  int RandomClient()
		{
			Random randClient = new Random();
			int numberClient = randClient.Next(1, 11);
			return numberClient;
		}

		//Identifiant du groupe arrivant au restaurant
		public  int GroupClient(List<int> numberList)
		{
			int id_group = 1;

			if (numberList.Contains(id_group))
			{
				while (numberList.Contains(id_group))
				{
					id_group++;
				}

			}
			numberList.Add(id_group);

			return id_group;
		}

		//Types de client au sein du groupe
		public  string RandomType(int number)
		{
			String[] typepersonne = { "pressé", "normal", "cool" };
			List<string> randomList = new List<string>();

			
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

		//Le type de client que le groupe va utiliser
		public int GroupType(int number)
		{
			string listType = RandomType(number);
			bool type1 = listType.Contains("cool");
			bool type2 = listType.Contains("normal");
			bool type3 = listType.Contains("pressé");

			int groupType = 0;

			if (type1)
			{
				groupType = 1;

			}
			else if (!type1 & type2)
			{
				groupType = 2;
			}
			else if (!type1 & !type2 & type3)
			{
				groupType = 3;
			}
			else
			{
				groupType = 4;
			}
			return groupType;
		}

		//Factory permettant d'avoir en string le type du groupe
		public static class Factory
		{
			public static Type Get(int groupType, int number)
			{
				ClientModel clientModel = new ClientModel();
				clientModel.GroupType(number);

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

		public abstract class Type
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

		//Récupération du type du groupe
		public void TextTypeGroupe(int number)
		{
			Log logs = new Log();
			var type = Factory.Get(GroupType(number), number);
		}

	}
}
