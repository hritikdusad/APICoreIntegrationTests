using System.Collections.Generic;
using System.Linq;
using APIIntegrationDemo.Dto;
using APIIntegrationDemo.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace APIIntegrationDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttractionController : ControllerBase
    {
        private readonly IAttractionService _service;

        public AttractionController(IAttractionService service)
        {
            _service = service;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<AttractionDto> Get()
        {
            var items = _service.GetTwoAttractions();

            return items.Select(e => new AttractionDto
            {
                AttractionId = e.AttractionId,
                Title = e.Title,
                Description = e.Description
            });
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}