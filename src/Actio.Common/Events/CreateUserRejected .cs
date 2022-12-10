using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Actio.Common.Events
{
    public class CreateUserRejected : IRejectedEvent
    {
        public string Email { get;  }
        public string Reason { get; }

        public string Code { get; }
        public CreateUserRejected ()
        {
            
        }
        public CreateUserRejected (string email,string reason,string code)
        {
            this.Code=code;
            this.Email=email;
            this.Reason=reason;
        }
    }
}