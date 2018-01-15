﻿
namespace PaymentContext.Domain.ValueObjects
{
    using Enums;
    using Shared.ValueObjects;

    public class Document : ValueObject
    {
        
        public Document(string number, EDocumentType type)
        {
            Number = number;
            Type = type;
        }

        public string Number { get; private set; }
        public EDocumentType Type { get; private set; }
    }
}