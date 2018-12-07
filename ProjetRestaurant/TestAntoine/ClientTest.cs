using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAntoine
{
    [TestClass]
    public class ClientTest
    {
        [TestMethod]
        public void RandomTypeTest()
        {
            Random randClient = new Random();
            int nombreClient = randClient.Next(0, 10);
            Random randType = new Random();
            for (int i = 0; i <= nombreClient; i++)
            {
                int selection = randType.Next(0, 3);
                Assert.IsNotNull(selection);
            }

        }
    }
}
