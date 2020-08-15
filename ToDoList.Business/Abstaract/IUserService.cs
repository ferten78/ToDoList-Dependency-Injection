using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Entities.Concrete;

namespace ToDoList.Business.Abstaract
{
    public interface IUserService
    {
        List<User> GetAll();
        User GetById(int Id);
        User Add(User user);
        User Update(User user);
        void Delete(User user);
    }
}
