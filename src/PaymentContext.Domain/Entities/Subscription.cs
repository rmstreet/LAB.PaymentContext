
namespace PaymentContext.Domain.Entities
{
    using Shared.Entities;
    using System;
    using System.Collections.Generic;

    public class Subscription : Entity
    {
        private List<Payment> _payment;

        public Subscription(DateTime? expireDate)
        {
            CreateDate = DateTime.Now;
            LastUpdateDate = DateTime.Now;
            ExpireDate = expireDate;
            Active = true;
            _payment = new List<Payment>();
        }

        public DateTime CreateDate { get; private set; }
        public DateTime LastUpdateDate { get; private set; }
        public DateTime? ExpireDate { get; private set; }
        public bool Active { get; private set; }
        public IReadOnlyCollection<Payment> Payments { get { return _payment.ToArray(); } }

        public void AddPayment(Payment payment)
        {
            _payment.Add(payment);
        }

        public void Enabled()
        {
            Active = true;
            LastUpdateDate = DateTime.Now;
        }

        public void Disabled()
        {
            Active = false;
            LastUpdateDate = DateTime.Now;
        }
    }
}