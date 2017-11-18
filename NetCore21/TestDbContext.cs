namespace NetCore21
{
    using Microsoft.EntityFrameworkCore;

    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<QuotingSession> QuotingSessions { get; set; }
        public DbSet<BackOfficeSession> BackOfficeSessions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ConfigureSession(modelBuilder);
            ConfigurePolicy(modelBuilder);
            ConfigureQuotingSession(modelBuilder);
            ConfigureBackOfficeSession(modelBuilder);
            ConfigureBackOfficePolicy(modelBuilder);
            ConfigureQuotingPolicy(modelBuilder);
        }
        
        public static void ConfigurePolicy(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Policy>();
            entity.ToTable("Policy", "dbo");
            entity.HasKey(x => x.Id);

            entity.HasDiscriminator<int>("SessionType")
                .HasValue<QuotingPolicy>(1)
                .HasValue<BackOfficePolicy>(2);
        }

        public static void ConfigureBackOfficePolicy(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<BackOfficePolicy>();
            entity.Property(x => x.BackOfficePolicyName);
        }
        
        public static void ConfigureQuotingPolicy(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<QuotingPolicy>();
            entity.Property(x => x.QuotingPolicyName);
        }
        
        public static void ConfigureSession(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Session>();
            entity.ToTable("Session", "dbo");
            entity.HasKey(x => x.Id);

            entity.HasDiscriminator<int>("SessionType")
                .HasValue<QuotingSession>(1)
                .HasValue<BackOfficeSession>(2);
        }

        public static void ConfigureBackOfficeSession(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<BackOfficeSession>();
            entity.Property(x => x.BackOfficeName);
            entity.HasMany(c => c.Policies).WithOne().HasForeignKey(c => c.SessionId);
        }
        
        public static void ConfigureQuotingSession(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<QuotingSession>();
            entity.Property(x => x.QuotingName);
            entity.HasMany(c => c.Policies).WithOne().HasForeignKey(c => c.SessionId);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
    }
}