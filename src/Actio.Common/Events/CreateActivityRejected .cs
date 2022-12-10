using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Actio.Common.Events
{
    public class CreateActivityRejected : IRejectedEvent
    {
        public Guid Id { get; }
        public string Reason { get; }

        public string Code { get; }
        protected CreateActivityRejected ()
        {
            
        }
        public CreateActivityRejected (Guid id,string reason,string code)
        {
            this.Code=code;
            this.Id=id;
            this.Reason=reason; 
        }
    }
}