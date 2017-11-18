namespace NetFramework
{
    public class BackOfficePolicy : Policy
    {
        public int SessionId { get; set; }
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