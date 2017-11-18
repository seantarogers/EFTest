namespace NetFramework
{
    using System.Data.Entity;

    using NetFramework.Config;

    public class TestDbContext : DbContext
    {
        public TestDbContext() : base("EFTest")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<QuotingSession> QuotingSessions { get; set; }
        public DbSet<BackOfficeSession> BackOfficeSessions { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PolicyConfig());
            modelBuilder.Configurations.Add(new BackOfficePolicyConfig());
            modelBuilder.Configurations.Add(new QuotingPolicyConfig());
            modelBuilder.Configurations.Add(new SessionConfig());
            modelBuilder.Configurations.Add(new QuotingSessionConfig());
            modelBuilder.Configurations.Add(new BackOfficeSessionConfig());
            base.OnModelCreating(modelBuilder);
        }
    }    
}