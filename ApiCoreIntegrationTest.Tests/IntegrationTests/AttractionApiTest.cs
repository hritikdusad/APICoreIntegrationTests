using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using ApiCoreIntegrationTest.Tests.Infrastructure;
using APIIntegrationDemo;
using APIIntegrationDemo.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace ApiCoreIntegrationTest.Tests.IntegrationTests
{
    [TestClass]
    public class AttractionApiTest
    {
        private TestHost<Startup> _server;
        private HttpClient _client;

        [TestInitialize]
        public void AttractionApiTestSetup()
        {
            _server = new TestHost<Startup>();
            _client = _server.CreateClient();
        }

        [TestCategory("Integration")]
        [TestMethod]
        public async Task GetTwoAttractionsTest()
        {
            // Arrange
            var httpResponse = await _client.GetAsync("/api/Attraction");

            // MUST be successful.
            httpResponse.EnsureSuccessStatusCode();

            // Act
            var stringResponse = await httpResponse.Content.ReadAsStringAsync();
            var attractions = JsonConvert.DeserializeObject<List<Attraction>>(stringResponse);

            // Assert
            Assert.IsNotNull(attractions);
            Assert.IsTrue(attractions.Count == 2);
        }

    }
}