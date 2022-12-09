using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Actio.Common.Events
{
    public class ActivityCraeted : IAuthenticatedEvent
    {
        public Guid UserId  {get;}
    }
}