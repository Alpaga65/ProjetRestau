using System;
using Model;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ModelTest
{
	[TestClass]
	public class ClientModelTest
	{
		
		[TestMethod]
		public void RandomClientTest() //Test si le random est entre 1 et 10
		{
			ClientModel clientModel = new ClientModel();
			int numberClient = clientModel.RandomClient();

			bool TrueFalse;
			if (numberClient >= 1 && numberClient <= 10)
			{
				TrueFalse = true;
			}
			else
			{
				TrueFalse = false;
			}
			Assert.IsTrue(TrueFalse);
		}

		[TestMethod]
		public void GroupClientTest() // Test pour vérifier si l'identifiant du groupe augmente si celui d'avant a été implémenté dans la liste
		{
			List<int> numberList = new List<int>();
			int id_group = 1;

			numberList.Add(id_group);

			if (numberList.Contains(id_group))
			{
				while (numberList.Contains(id_group))
				{
					id_group++;
				}

			}

			Assert.AreEqual(2, id_group);
		}

		[TestMethod]
		public void RandomTypeTest() // Test pour vérifier si la liste de type de personne se remplie correctement jusqu'au bout
		{

			String[] typepersonne = { "pressé", "normal", "cool" };
			List<string> randomList = new List<string>();
			bool TrueFalse = false;

			Random randType = new Random();
			for (int i = 1; i <= 5; i++)
			{
				int selection = randType.Next(0, 3);
				string type = typepersonne[selection];
				randomList.Add(type);
				if(i == 5)
				{
					TrueFalse = true;
				}
				else
				{
					TrueFalse = false;
				}
				

			}
			Assert.IsTrue(TrueFalse);
			Assert.IsNotNull(randomList);

		}

		[TestMethod]
		public void GroupTypeTest()// Test pour vérifier si la méthode récupère un seul type de groupe en focntion de la liste
		{
			ClientModel clientModel = new ClientModel();
			int groupType = clientModel.GroupType(5);

			Assert.AreNotEqual(0, groupType);
			Assert.AreNotEqual(4, groupType);
		}

		[TestMethod]
		public void TextTypeGroupe()// Test pour vérifier si le factory retourne bien un type pour le groupe
		{
			ClientModel clientModel = new ClientModel();
			var type = ClientModel.Factory.Get(clientModel.GroupType(5), 5);


			Assert.IsNotNull(type);
		}
	}
}
