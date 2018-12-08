using System;

namespace Model
{
	public class Class1
	{
		static void Main(string[] args)
		{


			List<int> numberList = new List<int>();

			for (int i = 1; i <= 50; i++)
			{
				GroupClient(numberList);
				int groupType = GroupType();
				var type = Factory.Get(groupType);
				int number = RandomClient();
				if (number != 0)
				{
					Console.WriteLine("On va se baser sur le temps de la personne " + type.Title + "\n");
				}
				else
				{
					Console.Write("\n");
				}
				Log write = new Log();
				write.Logs(nombreClient);
				int t = DBConnector.Instance.GetTable(11);
				// int s = DBConnector.Instance.SetTable ( t );




				DBConnector.Instance.CloseConnection();
				Thread.Sleep(10000);
			}


		}
	}
}

