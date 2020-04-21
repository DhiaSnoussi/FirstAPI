using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstAPI.Modals
{
    public class User
    {
        public int ID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }
        public int Numtel { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
    }
}
