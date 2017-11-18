namespace NetCore21
{
    public class BackOfficePolicy : Policy
    {
        public string BackOfficePolicyName { get; private set; }
        
        private BackOfficePolicy()
        {
        }

        public BackOfficePolicy(string name)
        {
            BackOfficePolicyName = name;
        }
    }
}