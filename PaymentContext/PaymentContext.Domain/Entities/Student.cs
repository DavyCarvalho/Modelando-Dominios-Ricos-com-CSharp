namespace PaymentContext.Domain.Entities
{
    public class Student
    {
        private IList<Subscription> _subscription;

        public Student(string firstName, string lastName, string document, string email, string homeAddress)
        {
            FirstName = firstName;
            LastName = lastName;
            Document = document;
            Email = email;
            _subscription = new List<Subscription>();
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Document { get; private set; }
        public string Email { get; private set; }
        public string HomeAddress { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions
        {
            get { return _subscription.ToArray(); }
        }

        public void AddSubscription(Subscription subscription)
        {
            foreach (var sub in Subscriptions)
            {
                sub.Activate();
            }

            _subscription.Add(subscription);
        }
    }
}
