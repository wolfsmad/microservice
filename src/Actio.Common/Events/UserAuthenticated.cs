using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Actio.Common.Events
{
    public class UserAuthenticated : IEvent
    {
        public string Email { get; }
        protected UserAuthenticated()
        {

        }
        public UserAuthenticated(string email)
        {
            this.Email=email;
        }
    }
}