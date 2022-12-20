using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Actio.Common.Events
{
    public interface IEventHandler<in T> where T:IEvent
    {
        Task HandleAsync<TEvent>(TEvent msg) where TEvent : IEvent;
        Task HanldeAsync(T @event);
    }
}