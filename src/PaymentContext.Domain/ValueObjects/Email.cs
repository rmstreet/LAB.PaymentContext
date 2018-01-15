﻿
namespace PaymentContext.Domain.ValueObjects
{
    using Flunt.Validations;
    using Shared.ValueObjects;

    public class Email : ValueObject
    {
        public Email(string address)
        {
            Address = address;

            AddNotifications(new Contract()
                                    .Requires()
                                    .IsEmail(Address, "Email.Address", "E-mail inválido")
                            );

        }

        public string Address { get; private set; }
    }
}
