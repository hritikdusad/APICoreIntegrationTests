using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using APIIntegrationDemo.Entities;
using APIIntegrationDemo.Interfaces;
using APIIntegrationDemo.Resources;
using Newtonsoft.Json;

namespace APIIntegrationDemo.Context

{
    public partial class DisneyContext : IDisneyContext
    {
        public void SeedFakeDatabase()
        {
            var attractions = JsonConvert.DeserializeObject<IEnumerable<Attraction>>(FakeData.FakeAttractions);
            
            this.Attraction.AddRange(attractions);
            this.SaveChanges();

        }
    }
}
