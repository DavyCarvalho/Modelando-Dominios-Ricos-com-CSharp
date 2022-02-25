namespace PaymentContext.Domain.Entities
{
    public class PayPalPayment : Payment
    {
        public PayPalPayment(string transactionCode,
            DateTime paidDate,
            DateTime dateTime,
            decimal total,
            decimal totalPaid,
            string owner,
            string document,
            string billingAddress,
            string email) : base(
                paidDate,
                dateTime,
                total,
                totalPaid,
                owner,
                document,
                billingAddress,
                email)
        {
            TransactionCode = transactionCode;
        }

        public string TransactionCode { get; private set; }
    }
}
