namespace NetFramework
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            using (var dbContext = new TestDbContext())
            {
                var quotingPolicy = new QuotingPolicy("quotingPolicyname");
                var quotingSession = new QuotingSession("quotingSessionName", new List<QuotingPolicy> {quotingPolicy});

                var backOfficePolicy = new BackOfficePolicy("quotingPolicyname");
                var backOfficeSession = new BackOfficeSession("quotingSessionName", new List<BackOfficePolicy> { backOfficePolicy });
                
                dbContext.BackOfficeSessions.Add(backOfficeSession);
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
                Console.WriteLine("NetFramework Saved successfully");
                Console.ReadLine();
            }
        }
    }
}
