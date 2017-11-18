namespace NetCore21
{
    public class QuotingPolicy : Policy
    {
        public string QuotingPolicyName { get; private set; }

        private QuotingPolicy()
        {
            
        }

        public QuotingPolicy(string name)
        {
            QuotingPolicyName = name;
        }
    }
}