using Core.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ToDoList.DataAcccess.Abstract;
using ToDoList.Entities.ComplexTypes;
using ToDoList.Entities.Concrete;

namespace ToDoList.DataAcccess.Concrete.EF
{
    public class EfJobDal : EfEntityRepositoryBase<Job, ToDoListContext>, IJobDal
    {
        public List<JobDetail> GetJobDetails()
        {
            using (ToDoListContext context= new ToDoListContext())
            {
                var result = from j in context.Jobs
                             join u in context.Users on j.userId equals u.Id
                             join s in context.Statuses on j.statusId equals s.id
                             select new JobDetail
                             {
                                 JobId = j.id,
                                 FinishDate = j.finishDate,
                                 Description = j.description,
                                 StatusDescription = s.Description,
                                 UserName = u.UserName
                             };
                return result.ToList();
            }
        }
    }
}
