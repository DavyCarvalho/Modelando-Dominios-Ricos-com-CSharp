namespace PaymentContext.Domain.Entities
{
    public class BoletoPayment : Payment
    {
        public BoletoPayment(string barCode,
            string boletoNumber,
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
            BarCode = barCode;
            BoletoNumber = boletoNumber;
        }

        public string BarCode { get; private set; }
        public string BoletoNumber { get; private set; }
    }

}
