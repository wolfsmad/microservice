using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Actio.Common.Events
{
    public interface UserCreated : IEvent
    {
        public string Email { get; set; }
        public string Name { get; set; }
        protected UserCreated(){
            
        }
    }
}