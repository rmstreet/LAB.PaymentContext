
namespace PaymentContext.Tests.Entities
{
    using PaymentContext.Domain.Entities;
    using PaymentContext.Domain.Enums;
    using PaymentContext.Domain.ValueObjects;
    using Xunit;
    public class StudentTest
    {
        [Fact]
        public void AdicionarAssinatura()
        {
            var subscription = new Subscription(null);
            var student = new Student(new Name("Romulo", "Martins"), new Document("1234567890", EDocumentType.CPF), new Email("contato@romulomartins.net"));
            student.AddSubscription(subscription);
        }
    }
}
