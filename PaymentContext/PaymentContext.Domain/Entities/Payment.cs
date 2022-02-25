namespace PaymentContext.Domain.Entities
{
    public abstract class Payment
    {
        protected Payment(DateTime paidDate,
            DateTime dateTime,
            decimal total,
            decimal totalPaid,
            string owner,
            string document,
            string billingAddress,
            string email)
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
        public string Document { get; private set; }
        public string BillingAddress { get; private set; }
        public string Email { get; private set; }
    }
}
