
namespace PaymentContext.Domain.ValueObjects
{
    using Shared.ValueObjects;

    public class Email : ValueObject
    {
        public Email(string address)
        {
            Address = address;
        }

        public string Address { get; private set; }
    }
}
