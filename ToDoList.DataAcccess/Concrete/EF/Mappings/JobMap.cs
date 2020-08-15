using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Entities.Concrete;

namespace ToDoList.DataAcccess.Concrete.EF.Mappings
{
    public class JobMap : EntityTypeConfiguration<Job>
    {
        public JobMap()
        {
            ToTable(@"Jobs", @"dbo");

            HasKey(x => x.id);

            Property(x => x.finishDate)
                .HasColumnType("date")
                .IsRequired(); 

            Property(d => d.description)
                .HasColumnType("nvarchar")
                .IsRequired();

            Property(s => s.statusId)
                .HasColumnType("int")
                .IsRequired();

            Property(u => u.userId)
                .HasColumnType("int")
                .IsRequired();
        }
    }
}
