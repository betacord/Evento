using System;
using System.Collections.Generic;
using System.Text;

namespace Evento.Infrastructure.Commands.Users
{
    public class Login
    {
        public string Email { get; set; }

        public string Password { get; set; }
    }
}
