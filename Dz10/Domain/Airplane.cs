using System;
using System.Collections.Generic;
using System.Text;

namespace Dz10.Domain
{
    public class Airplane : Entity
    {
        public string PlaneName { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}
