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
    public class UserManager : IUserService
    {
        private IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        
        public User Add(User user)
        {
            return _userDal.Add(user);
        }

        public void Delete(User user)
        {
            _userDal.Delete(user);
        }

        public List<User> GetAll()
        {
            return _userDal.GetList();
        }

        public User GetById(int Id)
        {
            return _userDal.Get(p => p.Id == Id);
        }

        public User Update(User user)
        {
            return _userDal.Update(user);
        }
    }
}
