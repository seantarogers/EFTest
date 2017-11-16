using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TestDbContext>();
            optionsBuilder.UseSqlServer("Server=.\\SqlServer2014;Database=EFTest;Trusted_Connection=True");
            using (var dbContext = new TestDbContext(optionsBuilder.Options))
            {
                var quotingPolicy = new QuotingPolicy("quotingPolicyname");
                var quotingSession = new QuotingSession("quotingSessionName", new List<QuotingPolicy> {quotingPolicy});

                dbContext.QuotingSessions.Add(quotingSession);
                dbContext.SaveChanges();
            }
        }
    }
}
