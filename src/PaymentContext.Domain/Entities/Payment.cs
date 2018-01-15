
namespace PaymentContext.Domain.Entities
{
    using ValueObjects;
    using Shared.Entities;
    using System;

    public abstract class Payment : Entity
    {
        protected Payment(DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, Address address, string payer, Document document, Email email)
        {
            Number = Guid.NewGuid().ToString().Replace("-","").Substring(0, 10).ToUpper();
            PaidDate = paidDate;
            ExpireDate = expireDate;
            Total = total;
            TotalPaid = totalPaid;
            Address = address;
            Payer = payer;
            Document = document;
            Email = email;
        }

        public string Number { get; private set; }
        public DateTime PaidDate { get; private set; }
        public DateTime ExpireDate { get; private set; }
        public decimal Total { get; private set; }
        public decimal TotalPaid { get; private set; }
        public Address Address { get; private set; }
        public string Payer { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
    }
}
