using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Evento.Core.Domain;

namespace Evento.Core.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetAsync(Guid id);

        Task<User> GetAsync(string email);

        Task<IEnumerable<User>> BrowseAsync(string name = "");

        Task AddAsync(User user);

        Task UpdateAsync(User user);

        Task DeleteAsync(User user);
    }
}
