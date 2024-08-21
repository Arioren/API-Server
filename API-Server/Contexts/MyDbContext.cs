using API_Server.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection;

namespace LearnApiWeb1908.Contexts
{
    public class MyDbContext : DbContext
    {
        public DbSet<Agent> Agents { get; set; }
        public DbSet<Target> Targets { get; set; }
        public DbSet<Mission> Missions { get; set; }

        private void Seed()
        {
            //if (!Users.Any())
            //{
            //    User defence1 = new User { Email = "ari@", Name = "ari", Password = "oren" };
            //    Mission mission = new Mission {  Description="h", DueDate = DateTime.Now, Priority = 1, Status="hard", Title="hj", UserId = 1 };
            //    Users.Add(defence1);
            //    Missions.Add(mission);
            //    SaveChanges();
            //}
        }
        public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options)
        {
            // לוודא שהבסיס נתונים והטבלאות קיימות, אם לא תייצר את כולם ריקות
            Console.WriteLine("Database Exists: " + Database.EnsureCreated());
            Seed();
        }
    }

}
