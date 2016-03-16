using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace testApp.Models
{
    public class PersonInfo
    {
       public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public string Company { get; set; }
        
        public string Email { get; set; }
        
        public bool Vip { get; set; }
    }
}
