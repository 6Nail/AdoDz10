using System;
using System.Collections.Generic;
using System.Text;

namespace Dz10.Domain
{
    public class Person : Entity
    {
        public string FullName { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}
