using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Infraestructura;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TutorialController : ControllerBase
    {
        private ITutorialDomain _tutorialDomain;

        public TutorialController(ITutorialDomain tutorialDomain)
        {
            _tutorialDomain = tutorialDomain;
        }
        
        // GET: api/Tutorial
        [HttpGet(Name = "GetTutorial")]
        
        public IEnumerable<string> Get()
        {  //Reglas de negocio
            //TutorialDomain tutorialDomain = new TutorialDomain();
            //return TutorialDomain.GetAll();
            return _tutorialDomain.GetAll();
        }

        // GET: api/Tutorial/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Tutorial
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Tutorial/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Tutorial/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
