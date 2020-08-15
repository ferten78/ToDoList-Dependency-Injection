namespace ToDoList.DataAcccess.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ToDoList.Entities.Concrete;

    internal sealed class Configuration : DbMigrationsConfiguration<ToDoList.DataAcccess.Concrete.EF.ToDoListContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ToDoList.DataAcccess.Concrete.EF.ToDoListContext context)
        {
            if (!context.Users.Any())
            {
                User user = new User();

                user.Id = 1;
                user.UserName = "Inveon";
                context.Users.Add(user);

                user.Id = 2;
                user.UserName = "User2"; 
                context.Users.Add(user);
            }
            if (!context.Statuses.Any())
            {
                List<Status> Status = new List<Status>();


                Status.Add(new Status { id = 1, Description = "Atandý" });
                Status.Add(new Status { id = 2, Description = "Yapýlýyor" });
                Status.Add(new Status { id = 3, Description = "Test" });
                Status.Add(new Status { id = 4, Description = "Bitti" });


                context.Statuses.AddRange(Status);
            }
            if (!context.Jobs.Any())
            {
                List<Job> Job = new List<Job>();

                Job.Add(new Job { id = 1, description = "görev1", finishDate = DateTime.Now, statusId = 1, userId = 1 });

                context.Jobs.AddRange(Job);
            }



            base.Seed(context);
        }
    }
}
