using System;
using System.Collections.Generic;
using System.Text;

namespace Dz10.Domain
{
    public class Ticket : Entity
    {
        public int Price { get; set; }
        public Person Person { get; set; }
        public Airplane Airplane { get; set; }
    }
}
