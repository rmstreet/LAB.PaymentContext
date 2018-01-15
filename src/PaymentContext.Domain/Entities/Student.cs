
namespace PaymentContext.Domain.Entities
{
    using ValueObjects;
    using Shared.Entities;
    using System.Collections.Generic;

    public class Student : Entity
    {
        private List<Subscription> _subscriptions;
        public Student(Name name, Document document, Email email)
        {
            Name = name;
            Document = document;
            Email = email;
            _subscriptions = new List<Subscription>();

            AddNotifications(name, document, email);
        }

        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public Address Address { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); } }

        public void AddSubscription(Subscription subscription)
        {
            // Se já tiver uma assinatura ativa, cacela

            // Cancela todas as outras assinaturas, e coloca esta
            // como principal
            foreach (var sub in _subscriptions)
                sub.Disabled();

            _subscriptions.Add(subscription);
        }


    }
}
