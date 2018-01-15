
namespace PaymentContext.Shared.Entities
{
    using Flunt.Notifications;
    using System;
    public abstract class Entity : Notifiable
    {
        public Entity()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; private set; }
    }
}
