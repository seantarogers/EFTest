namespace NetCore11
{
    using System.Collections.Generic;

    public class QuotingSession : Session
    {
        public string QuotingName { get; private set; }
        public List<QuotingPolicy> Policies { get; private set; }

        private QuotingSession()
        {
        }

        public QuotingSession(string name, List<QuotingPolicy> quotingPolicies)
        {
            QuotingName = name;
            Policies = quotingPolicies;

        }
    }
}