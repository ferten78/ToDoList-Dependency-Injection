using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Entities.Concrete;

namespace ToDoList.Business.Abstaract
{
    public interface IStatusService
    {
        List<Status> GetAll();
        Status GetById(int Id);
        Status Add(Status status);
        Status Update(Status status);
        void Delete(Status user);
    }
}
