namespace NetCore11
{
    using System.Collections.Generic;

    public class BackOfficeSession : Session
    {
        public List<BackOfficePolicy> Policies { get; private set; }
        public string BackOfficeName { get; private set; }

        private BackOfficeSession()
        {
        }

        public BackOfficeSession(string name, List<BackOfficePolicy> policies)
        {
            BackOfficeName = name;
            Policies = policies;
        }
    }
}