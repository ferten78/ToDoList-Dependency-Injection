using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Business.Abstaract;
using ToDoList.Business.Concrete.Managers;
using ToDoList.DataAcccess.Abstract;
using ToDoList.DataAcccess.Concrete.EF;

namespace ToDoList.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IJobService>().To<JobManager>().InSingletonScope();
            Bind<IJobDal>().To<EfJobDal>();

            Bind<IStatusService>().To<StatusManager>().InSingletonScope();
            Bind<IStatusDal>().To<EfStatusDal>();

            Bind<IUserService>().To<UserManager>().InSingletonScope();
            Bind<IUserDal>().To<EfUserDal>();

            Bind(typeof(IQueryableRepository<>)).To(typeof(EfQueryableRepository<>));
            Bind<DbContext>().To<ToDoListContext>();

        }
    }
}
