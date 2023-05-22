
using System.IO;

namespace Test
{
    [TestClass]
    public class CycleApitests
    {

        [TestMethod]
        public   void TestJourneyAPi()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response =  client.GetAsync("https://functionapp220230415180354.azurewebsites.net/api/Journeys?page=1").Result;
            Assert.AreEqual(response.StatusCode, System.Net.HttpStatusCode.OK);
        }

        [TestMethod]
        public void TestStationsAPi()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.GetAsync("https://functionapp220230415180354.azurewebsites.net/api/Stations?page=1").Result;
            Assert.AreEqual(response.StatusCode, System.Net.HttpStatusCode.OK);
        }

        [TestMethod]
        public void TestStationsdetailsAPi()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.GetAsync("https://functionapp220230415180354.azurewebsites.net/api/stationdetails?id=001").Result;
            Assert.AreEqual(response.StatusCode, System.Net.HttpStatusCode.OK);
        }

    }
}