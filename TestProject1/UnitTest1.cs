
using System.IO;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public   void TestJourneyAPi()
        {
            HttpClient client = new HttpClient();
           
            HttpResponseMessage response =  client.GetAsync("https://functionapp220230415180354.azurewebsites.net/api/Journeys?page=1").Result;
Console.WriteLine(response.StatusCode); 
            Assert.AreEqual(response.StatusCode, System.Net.HttpStatusCode.OK);
        }

    }
}