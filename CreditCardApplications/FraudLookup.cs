namespace CreditCardApplications
{
    public class FraudLookup
    {
        public bool IsFraudRisk(CreditCardApplication application)
        {
            if (application.LastName == "Smith")
            {
                return true;
            }
            return false;
        }
    }
}
