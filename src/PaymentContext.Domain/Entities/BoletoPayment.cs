﻿
namespace PaymentContext.Domain.Entities
{
    using PaymentContext.Domain.ValueObjects;
    using System;

    public class BoletoPayment : Payment
    {        
        protected BoletoPayment(string barCode, string boletoNumber, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, Address address, string payer, Document document, Email email) 
            : base(paidDate, expireDate, total, totalPaid, address, payer, document, email)
        {
            BarCode = barCode;
            BoletoNumber = boletoNumber;
        }

        public string BarCode { get; private set; }
        public string BoletoNumber { get; private set; }
    }
}
