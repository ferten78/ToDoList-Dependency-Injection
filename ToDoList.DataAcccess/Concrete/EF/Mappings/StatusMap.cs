using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Entities.Concrete;

namespace ToDoList.DataAcccess.Concrete.EF.Mappings
{
    public class StatusMap : EntityTypeConfiguration<Status>
    {
        public StatusMap()
        {
            ToTable(@"Statuses", @"dbo");
            HasKey(x => x.id);

            Property(x => x.Description)
                .HasColumnType("nvarchar");
        }
    }
}
