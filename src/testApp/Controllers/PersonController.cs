using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using testApp.Models;
using testApp.AppData;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace testApp.Controllers
{
    [Route("api/[controller]/[action]")]
    public class PersonController : Controller
    {
        private DBWriter db = new DBWriter();
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            
            Console.WriteLine(id);
            return "value - "+ id;
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] PersonInfo person)
        {
            //CreatePerson createPerson = new CreatePerson(jsonData);
            //db.SavePerson(createPerson.GetPerson());
           
            if (person == null)
            {
                return HttpBadRequest();
            }
            else {
                db.SavePerson(person);
                return new EmptyResult(); }
            }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
