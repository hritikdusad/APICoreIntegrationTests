using System.Collections.Generic;
using System.Linq;
using APIIntegrationDemo.Entities;
using APIIntegrationDemo.Interfaces;

namespace APIIntegrationDemo.Services
{
    public class AttractionService : IAttractionService
    {
        private readonly IDisneyContext _context;

        public AttractionService(IDisneyContext context)
        {
            _context = context;
        }

        public List<Attraction> GetTwoAttractions()
        {
            return _context.Attraction
                .Take(2)
                .ToList();
        }
    }
}
