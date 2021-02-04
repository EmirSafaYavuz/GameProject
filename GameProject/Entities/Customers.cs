using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Customers
    {
        public int Id { get; set; }
        public string TCno { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthYear { get; set; }
        public bool Active { get; set; }

    }
}
