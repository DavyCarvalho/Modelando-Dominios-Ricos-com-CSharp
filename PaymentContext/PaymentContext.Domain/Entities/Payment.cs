using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
    public abstract class Payment : Entity
    {
        protected Payment(DateTime paidDate,
            DateTime dateTime,
            decimal total,
            decimal totalPaid,
            string owner,
            Document document,
            Address billingAddress,
            Email email)
        {
            Number = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10).ToUpper();
            PaidDate = paidDate;
            DateTime = dateTime;
            Total = total;
            TotalPaid = totalPaid;
            Owner = owner;
            Document = document;
            BillingAddress = billingAddress;
            Email = email;
        }

        public string Number { get; private set; }
        public DateTime PaidDate { get; private set; }
        public DateTime DateTime { get; private set; }
        public decimal Total { get; private set; }
        public decimal TotalPaid { get; private set; }
        public string Owner { get; private set; }
        public Document Document { get; private set; }
        public Address BillingAddress { get; private set; }
        public Email Email { get; private set; }
    }
}
