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
    public class StatusManager : IStatusService
    {
        private IStatusDal _statusDal;
        public StatusManager(IStatusDal statusDal)
        {
            _statusDal = statusDal;
        }
        public Status Add(Status status)
        {
            return _statusDal.Add(status);
        }

        public void Delete(Status user)
        {
            _statusDal.Delete(user);
        }

        public List<Status> GetAll()
        {
            return _statusDal.GetList();
        }

        public Status GetById(int Id)
        {
            return _statusDal.Get(p => p.id == Id);
        }

        public Status Update(Status status)
        {
            return _statusDal.Update(status);
        }
    }
}
