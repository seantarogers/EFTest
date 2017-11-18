namespace NetFramework.Config
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;

    public class SessionConfig : EntityTypeConfiguration<Session>
    {
        public SessionConfig()
        {
            ToTable("Session", "dbo");
            HasKey(p => p.Id);
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            
            Map<BackOfficeSession>(m => m.Requires("SessionType").HasValue(1));
            Map<QuotingSession>(m => m.Requires("SessionType").HasValue(2));
        }
    }
}