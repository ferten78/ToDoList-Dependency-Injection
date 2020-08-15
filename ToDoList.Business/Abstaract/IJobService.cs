using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Entities.Concrete;

namespace ToDoList.Business.Abstaract
{
    public interface IJobService
    {
        List<Job> GetAll();
        Job GetById(int Id);
        Job Add(Job job);
        Job Update(Job Job);
        void Delete(Job Job);

    }
}
