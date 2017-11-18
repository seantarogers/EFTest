namespace NetFramework.Config
{
    using System.Data.Entity.ModelConfiguration;

    public class BackOfficeSessionConfig : EntityTypeConfiguration<BackOfficeSession>
    {
        public BackOfficeSessionConfig()
        {

            Property(p => p.BackOfficeName).IsRequired();

            HasMany(p => p.Policies)
                .WithRequired()
                .HasForeignKey(a => a.SessionId);

        }
    }
}