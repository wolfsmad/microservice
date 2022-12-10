using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Actio.Common.Events
{
    public class ActivityCraeted : IAuthenticatedEvent
    {
        public Guid UserId { get; }
        public Guid Id { get; }
        public string Category { get; }
        public string Name { get; }
        public string Description { get; }
        public DateTime CreatedAt { get; }
        protected ActivityCraeted()
        {

        }
        public ActivityCraeted(Guid id,Guid userId,string category,
        string name,string description,DateTime createdAt)
        {
            this.Id=id;
            this.UserId=userId;
            this.Category=category;
            this.CreatedAt=createdAt;
            this.Description=description;
            this.Name=name;
        }
    }
}