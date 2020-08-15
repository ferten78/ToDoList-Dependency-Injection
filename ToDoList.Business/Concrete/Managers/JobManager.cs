using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Business.Abstaract;
using ToDoList.DataAcccess.Abstract;
using ToDoList.Entities.Concrete;

namespace ToDoList.Business.Concrete.Managers
{
    public class JobManager : IJobService
    {
        private IJobDal _jobDal; 
        public JobManager(IJobDal jobDal)
        {
            _jobDal = jobDal;
        }
        public Job Add(Job job)
        {
            return _jobDal.Add(job);
        }
          
        public List<Job> GetAll()
        {
            return _jobDal.GetList();
        }

        public Job GetById(int Id)
        {
            return _jobDal.Get(p => p.id == Id);
        }

        public Job Update(Job Job)
        {
            return _jobDal.Update(Job);
        }

        void IJobService.Delete(Job Job)
        {
            _jobDal.Delete(Job);
        }
    }
}
