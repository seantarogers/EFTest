namespace NetFramework.Config
{
    using System.Data.Entity.ModelConfiguration;

    public class BackOfficePolicyConfig : EntityTypeConfiguration<BackOfficePolicy>
    {
        public BackOfficePolicyConfig()
        {
            Property(p => p.BackOfficePolicyName).IsRequired();
            Property(p => p.SessionId).IsRequired().HasColumnName("SessionId");
        }
    }
}