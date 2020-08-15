using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Entities.Concrete;

namespace ToDoList.DataAcccess.Concrete.EF.Mappings
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            ToTable(@"Users", @"dbo");

            HasKey(x => x.Id);

            Property(p => p.UserName)
                .HasColumnType("nvarchar");
        }
    }
}
