using Core.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.DataAcccess.Abstract;
using ToDoList.Entities.Concrete;

namespace ToDoList.DataAcccess.Concrete.EF
{
    public class EfUserDal : EfEntityRepositoryBase<User, ToDoListContext>, IUserDal
    {
    }
}
