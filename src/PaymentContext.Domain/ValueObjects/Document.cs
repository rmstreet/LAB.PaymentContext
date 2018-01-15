
namespace PaymentContext.Domain.ValueObjects
{
    using Enums;
    using Flunt.Validations;
    using Shared.ValueObjects;

    public abstract class Document : ValueObject
    {
        
        public Document(string number, EDocumentType type)
        {
            Number = number;
            Type = type;

            AddNotifications(new Contract()
                .Requires()
                .IsTrue(Validate(), "Document.Number", $"{type.ToString()} inválido."));
        }

        public string Number { get; private set; }
        public EDocumentType Type { get; private set; }

        protected abstract bool Validate();
    }
}
