using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC2.Models
{
    public class Couple
    {
        public int? Id { get; set; }
        public string Boy { get; set; }
        public string Bride { get; set; }
        public string Surname { get; set; }
        public DateTime RegistrationDay { get; set; }
    }
}