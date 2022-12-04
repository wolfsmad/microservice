using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Actio.Common.Events
{
    public interface IAuthenticatedEvent : IEvent
    {
        Guid UserId{get;}
    }
}