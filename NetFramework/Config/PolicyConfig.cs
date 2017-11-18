namespace NetFramework.Config
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;

    public class PolicyConfig : EntityTypeConfiguration<Policy>
    {
        public PolicyConfig()
        {
            ToTable("Policy", "dbo");
            HasKey(p => p.Id);
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            
            Map<BackOfficePolicy>(m => m.Requires("SessionType").HasValue(1));
            Map<QuotingPolicy>(m => m.Requires("SessionType").HasValue(2));
        }
    }
}