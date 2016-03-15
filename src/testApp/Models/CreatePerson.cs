using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testApp.Models
{
    public class CreatePerson
    {
        private PersonInfo person;
        public CreatePerson(string jsonData)
        {
            if(jsonData!=null)
            person = JsonConvert.DeserializeObject<PersonInfo>(jsonData);
            else
            {
                var str =@"{FirstName: 'den', LastName: 'gav', Company: 'home', Email: 'd@re.er', VIP: true}";
                person = JsonConvert.DeserializeObject<PersonInfo>(str);
            }
        }

        public PersonInfo GetPerson() {
             return person;
        }
    }
}
