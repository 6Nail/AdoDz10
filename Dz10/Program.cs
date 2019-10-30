using Dz10.Domain;
using System;

namespace Dz10
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AirContext())
            {
                var airplane = new Airplane
                {
                    PlaneName = "Boing"
                };
                var person = new Person()
                {
                    FullName = "Иван"
                };
                var ticket = new Ticket
                {
                    Price = 1000,
                    Person = person,
                    Airplane = airplane
                };
                context.Airplanes.Add(airplane);
                context.People.Add(person);
                context.Tickets.Add(ticket);
                context.SaveChanges();
            }
        }
    }
}
