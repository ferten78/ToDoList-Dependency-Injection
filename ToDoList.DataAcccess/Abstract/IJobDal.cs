
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Entities.ComplexTypes;
using ToDoList.Entities.Concrete;
using Core.DataAccess;

namespace ToDoList.DataAcccess.Abstract
{
    public interface IJobDal: IEntityRepository<Job>
    {
        List<JobDetail> GetJobDetails();
    }
}
