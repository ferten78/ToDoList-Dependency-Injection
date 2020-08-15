using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.DataAcccess.Concrete.EF.Mappings;
using ToDoList.Entities.Concrete;

namespace ToDoList.DataAcccess.Concrete.EF
{
    public class ToDoListContext : DbContext
    {
        public ToDoListContext()
        {
            Database.SetInitializer<ToDoListContext>(null);
        }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Status> Statuses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new JobMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new StatusMap());
        }
    }
}
