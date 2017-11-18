namespace NetFramework.Config
{
    using System.Data.Entity.ModelConfiguration;

    public class QuotingPolicyConfig : EntityTypeConfiguration<QuotingPolicy>
    {
        public QuotingPolicyConfig()
        {
            Property(p => p.QuotingPolicyName).IsRequired();
            Property(p => p.SessionId).IsRequired().HasColumnName("SessionId");
        }
    }
}