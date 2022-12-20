using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Actio.Common.Commands;
using Actio.Common.Events;
using RawRabbit;
using RawRabbit.Pipe;

namespace Actio.Common.RabbitMq
{
    public static class Exetnsions
    {
        public static Task WithCommandHandlerAsync<TCommand> (this IBusClient bus,
        ICommandHandler<TCommand> handler) where TCommand : ICommand =>
      bus.SubscribeAsync<TCommand> (msg => handler.HandleAsync (msg),
        ctx => ctx.UseConsumerConfiguration (cfg =>
          cfg.FromDeclaredQueue (q => q.WithName (GetQueueName<TCommand> ()))
        ));

    public static Task WithEventHandlerAsync<TEvent> (this IBusClient bus,
        IEventHandler<TEvent> handler) where TEvent : IEvent =>
      bus.SubscribeAsync<TEvent> (msg => handler.HandleAsync (msg),
        ctx => ctx.UseConsumerConfiguration (cfg =>
          cfg.FromDeclaredQueue (q => q.WithName (GetQueueName<TEvent> ()))
        ));

    private static string GetQueueName<T> () => $"{System.Reflection.Assembly.GetEntryAssembly().GetName()}/{typeof(T).Name}";
    }
}