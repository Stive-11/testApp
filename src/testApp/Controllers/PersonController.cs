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
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        private DBWriter db = new DBWriter();

        [HttpPost]
        public IActionResult Post([FromBody]PersonInfo request)
        {
           
            if (request == null)
            {
                return HttpBadRequest();
            }
            else {
                db.SavePerson(request);
                return new EmptyResult(); }
            }


    }
}
