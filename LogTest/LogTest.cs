using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace LogTest
{
    [TestClass]
    public class LogTest
    {
        [TestMethod]
        public void TestMethod1()
        {

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
