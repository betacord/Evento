using System;
using System.Collections.Generic;
using System.Text;

namespace Evento.Core.Domain
{
    public class Event : Entity
    {
        private ISet<Ticket> _tickets = new HashSet<Ticket>();

        public string Name { get; protected set; }

        public string Description { get; protected set; }

        public DateTime CreatedAt { get; protected set; }

        public DateTime StartDate { get; protected set; }

        public DateTime EndDate { get; protected set; }

        public DateTime UpdatedAt { get; protected set; }

        public IEnumerable<Ticket> Tickets => _tickets;

        protected Event()
        {

        }

        public Event(Guid Id, string Name, string Description, DateTime StartDate, DateTime EndDate)
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            this.CreatedAt = DateTime.UtcNow;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.UpdatedAt = DateTime.UtcNow;
        }

        public void AddTickets(int amount, decimal price)
        {
            var seating = _tickets.Count + 1;

            for (int i = 0; i < amount; i++)
            {
                _tickets.Add(new Ticket(this, seating++, price));
            }
        }
    }
}
