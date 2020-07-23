using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Microservice1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendController : ControllerBase
    {
        // GET: api/<SendController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            DateTime today = new DateTime(2020, 07, 22);
            PersonList list = new PersonList("Elad Ben Moshe", today, 25, "Software Developer"); 
            JObject json = (JObject)JToken.FromObject(list);
            json.Property("m_Age").Remove();
            Producer.sendMessage(json.ToString());

            return new string[] { "Sent", json.ToString() };
        }

        // GET api/<SendController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SendController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SendController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SendController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
