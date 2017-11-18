namespace NetFramework
{
    public class QuotingPolicy : Policy
    {
        public int SessionId { get; set; }
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