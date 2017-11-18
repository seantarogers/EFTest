namespace NetFramework.Config
{
    using System.Data.Entity.ModelConfiguration;

    public class QuotingSessionConfig : EntityTypeConfiguration<QuotingSession>
    {
        public QuotingSessionConfig()
        {

            Property(p => p.QuotingName).IsRequired();

            HasMany(p => p.Policies)
                .WithRequired()
                .HasForeignKey(a => a.SessionId);

        }
    }
}