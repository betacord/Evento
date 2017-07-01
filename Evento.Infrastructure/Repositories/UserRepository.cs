using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Evento.Core.Domain;
using Evento.Core.Repositories;

namespace Evento.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private static readonly ISet<User> _users = new HashSet<User>();

        public async Task<User> GetAsync(Guid id)
            => await Task.FromResult(_users.SingleOrDefault(x => x.Id == id));

        public async Task<User> GetAsync(string name)
            => await Task.FromResult(_users.SingleOrDefault(x => x.Name.ToLowerInvariant() == name.ToLowerInvariant()));

        public async Task<IEnumerable<User>> BrowseAsync(string name = "")
        {
            var events = _users.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(name))
            {
                events = events.Where(x => x.Name.ToLowerInvariant().Contains(name.ToLowerInvariant()));
            }

            return await Task.FromResult(events);
        }

        public async Task AddAsync(User user)
        {
            _users.Add(user);

            await Task.CompletedTask;
        }

        public async Task DeleteAsync(User user)
        {
            _users.Remove(user);

            await Task.CompletedTask;
        }

        public async Task UpdateAsync(User user)
        {
            await Task.CompletedTask;
        }
    }
}
