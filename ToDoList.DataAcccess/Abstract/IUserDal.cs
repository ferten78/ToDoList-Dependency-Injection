using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Entities.Concrete;

namespace ToDoList.DataAcccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
    }
}
