using System;
using System.Collections.Generic;
using System.Text;

namespace Evento.Core.Domain
{
    public class User : Entity
    {
        public string Role { get; protected set; }

        public string Name { get; protected set; }

        public string Email { get; protected set; }

        public string Password { get; protected set; }

        public DateTime CreatedAt { get; protected set; }

        protected User()
        {

        }

        public User(Guid Id, string Role, string Name, string Email, string Password)
        {
            this.Id = Id;
            this.Role = Role;
            this.Name = Name;
            this.Email = Email;
            this.Password = Password;
            this.CreatedAt = DateTime.UtcNow;
        }
    }
}
