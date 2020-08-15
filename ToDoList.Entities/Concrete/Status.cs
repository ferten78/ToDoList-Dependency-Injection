using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Entities.Concrete
{
    public class Status : IEntity
    {
        public int id { get; set; }
        public string Description { get; set; }
    }
}
