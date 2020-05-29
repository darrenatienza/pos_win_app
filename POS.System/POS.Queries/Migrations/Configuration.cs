namespace POS.Queries.Migrations
{
    using POS.Queries.Core.Domain;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<POS.Queries.Persistence.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(POS.Queries.Persistence.DataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //



            #region Add Roles
            var roles = new Dictionary<string, Role>
            {
                //Users Lookup
                {"1", new Role {RoleID = 1, Description = "Administrator"}},
                {"2", new Role {RoleID = 1, Description = "Cashier"}},
                

            };
            foreach (var permission in roles.Values)
                context.Roles.AddOrUpdate(t => t.RoleID, permission);
            #endregion

            #region Add Members
            var members = new Dictionary<string, Member>
            {
                //Members
                {"1", new Member { MemberID = 1, FullName = "Walk-In", Address = "None", ContactNumber = "None" }}
               
                

            };

            foreach (var member in members.Values)
                context.Members.AddOrUpdate(t => t.MemberID, member);
            #endregion

            #region Add Users
            var users = new Dictionary<string, User>
            {
                {"admin", 
                    new User 
                    { UserID = 1, 
                        FirstName = "admin", 
                        MiddleName ="admin", 
                        LastName="admin",
                        UserName ="admin",
                        Password = "hhG78E33nyu+81r6HoIBtKfrFHq85FmR52igWa9Ii9rvkpPBzPx0wZM/5bjO+g1USqh2/UDgthyDUcYTLqZU9g==",
                        PasswordSalt="100000.VX80RHacuhEU/pBeUcAWgzdvgMu5UP17Gad8+Xf7ZuYWHQ=="
                    }
                }
            };

            foreach (var user in users.Values)
                context.Users.AddOrUpdate(t => t.UserID, user);
            #endregion

          

        }
    }
}
