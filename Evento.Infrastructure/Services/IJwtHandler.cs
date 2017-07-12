using System;
using System.Collections.Generic;
using System.Text;
using Evento.Infrastructure.DTO;

namespace Evento.Infrastructure.Services
{
    public interface IJwtHandler
    {
        JwtDto CreateToken(Guid userId, string role);
    }
}
