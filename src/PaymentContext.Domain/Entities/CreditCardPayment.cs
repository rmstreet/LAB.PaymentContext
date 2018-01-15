
namespace PaymentContext.Domain.Entities
{
    using PaymentContext.Domain.ValueObjects;
    using System;

    public class CreditCardPayment : Payment
    {
        
        protected CreditCardPayment(string cardHolderName, string cardNumber, string lastTransactionNumber, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, Address address, string payer, Document document, Email email) 
            : base(paidDate, expireDate, total, totalPaid, address, payer, document, email)
        {
            CardHolderName = cardHolderName;
            CardNumber = cardNumber;
            LastTransactionNumber = lastTransactionNumber;
        }

        public string CardHolderName { get; private set; }
        public string CardNumber { get; private set; }
        public string LastTransactionNumber { get; private set; }
    }
}
