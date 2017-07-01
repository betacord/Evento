using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Evento.Core.Domain;

namespace Evento.Core.Repositories
{
    public interface IEventRepository
    {
        Task<Event> GetAsync(Guid id);

        Task<Event> GetAsync(string name);

        Task<IEnumerable<Event>> BrowseAsync(string name = "");

        Task AddAsync(Event @event);

        Task UpdateAsync(Event @event);

        Task DeleteAsync(Event @event);
    }
}
