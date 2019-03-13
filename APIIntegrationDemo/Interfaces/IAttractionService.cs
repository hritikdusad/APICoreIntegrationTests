using System.Collections.Generic;
using APIIntegrationDemo.Entities;

namespace APIIntegrationDemo.Interfaces
{
    public interface IAttractionService
    {
        List<Attraction> GetTwoAttractions();
    }
}