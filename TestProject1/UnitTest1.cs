
using System.IO;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using Newtonsoft.Json;

namespace Test
{
    struct Station
    {
        public string id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
        public int NumDeb { get; set; }
        public int NumEnd { get; set; }
    };
    [TestClass]
    public class CycleApitests
    {

        [TestMethod]
        public   void TestJourneyAPi()
        {
            HttpClient client = new ();
            HttpResponseMessage response =  client.GetAsync("https://functionapp220230415180354.azurewebsites.net/api/Journeys?page=1").Result;
            Assert.AreEqual(response.StatusCode, System.Net.HttpStatusCode.OK);
        }

        [TestMethod]
        public void TestStationsAPi()
        {
            HttpClient client = new();
            HttpResponseMessage response = client.GetAsync("https://functionapp220230415180354.azurewebsites.net/api/Stations?page=1").Result;
            Assert.AreEqual(response.StatusCode, System.Net.HttpStatusCode.OK);
        }

        [TestMethod]
        public void TestStationsdetailsAPi()
        {
            HttpClient client = new ();
            HttpResponseMessage response = client.GetAsync("https://functionapp220230415180354.azurewebsites.net/api/stationdetails?id=001").Result;
            Assert.AreEqual(response.StatusCode, System.Net.HttpStatusCode.OK);
        }

        [TestMethod]
        public void TestStationsdetailsContentAPi()
        {
            HttpClient client = new();
            HttpResponseMessage response = client.GetAsync("https://functionapp220230415180354.azurewebsites.net/api/stationdetails?id=001").Result;
            Station deserializedProduct = JsonConvert.DeserializeObject<Station>(response.Content.ReadAsStringAsync().Result);
            Assert.AreEqual(deserializedProduct.Name, "Kaivopuisto");
        }

    }
}