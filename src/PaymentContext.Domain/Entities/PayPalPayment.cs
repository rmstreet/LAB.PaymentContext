
namespace PaymentContext.Domain.Entities
{
    using PaymentContext.Domain.ValueObjects;
    using System;

    public class PayPalPayment : Payment
    {        
        protected PayPalPayment(string transactionCode, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, Address address, string payer, Document document, Email email) 
            : base(paidDate, expireDate, total, totalPaid, address, payer, document, email)
        {
            TransactionCode = transactionCode;
        }

        public string TransactionCode { get; private set; }
    }
}
