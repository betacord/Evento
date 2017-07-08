using System;
using System.Collections.Generic;
using System.Text;
using Evento.Core.Domain;

namespace Evento.Infrastructure.DTO
{
    public class EventDetailsDto : EventDto
    {
        public IEnumerable<Ticket> Tickets { get; set; }


    }
}
