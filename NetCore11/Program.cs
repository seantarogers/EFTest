using System;

namespace NetCore11
{
    using System.Collections.Generic;

    using Microsoft.EntityFrameworkCore;

    class Program
    {
        static void Main(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TestDbContext>();
            optionsBuilder.UseSqlServer("Server=.\\SqlServer2014;Database=EFTest;Trusted_Connection=True");
            using (var dbContext = new TestDbContext(optionsBuilder.Options))
            {
                var quotingPolicy = new QuotingPolicy("quotingPolicyname");
                var quotingSession = new QuotingSession("quotingSessionName", new List<QuotingPolicy> { quotingPolicy });

                dbContext.QuotingSessions.Add(quotingSession);
                try
                {
                    dbContext.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e);
                    Console.ReadLine();
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("NETCore21 Saved successfully");
                Console.ReadLine();
            }
            Console.WriteLine("Hello World!");
        }
    }
}
